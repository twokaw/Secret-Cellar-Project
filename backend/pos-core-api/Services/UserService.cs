using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebApi.Entities;
using WebApi.Helpers;
using Shared;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApi.Services
{
    public interface IUserService
    {
        User Authenticate(uint username, uint password);
        bool IsTokenValid(string token);
        IEnumerable<User> GetAll();
    }

    public class UserService : IUserService
    {
        readonly DbConn db = new DbConn();
        private readonly List<User> _users = new List<User>();
        private void GetCredentials()
        {
            User cred;
            db.OpenConnection();

            string sqlStatement = "SELECT emp_id, pin_number, admin FROM employee";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    _users.Add(new User
                    {
                        EmployeeID = reader.IsDBNull("emp_id") ? 0 : reader.GetUInt32("emp_id"),
                        Pin = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number"),
                        IsAdmin = !reader.IsDBNull("admin") && (0 != reader.GetUInt16("admin"))
                    });
                }
            }
            finally
            {
                reader.Close();
            }
            db.CloseConnnection();
        }


        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public User Authenticate(uint username, uint password)
        {

            GetCredentials();
            var user = _users.SingleOrDefault(x => x.EmployeeID == username && x.Pin == password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.EmployeeID.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(60),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            return user.WithoutPassword();
        }


        // check to see if token is still valid. If not, will need to re-authenticate
        public bool IsTokenValid(string token)
        {
            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appSettings.Secret));
            var tokenHandler = new JwtSecurityTokenHandler();

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    IssuerSigningKey = key
                }, out SecurityToken validatedToken);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable<User> GetAll()
        {
            return _users.WithoutPasswords();
        }
    }
}