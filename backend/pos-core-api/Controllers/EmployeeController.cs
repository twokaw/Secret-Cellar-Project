using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Models;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        DbConn db = new DbConn();

        [HttpGet]
        public List<EmployeeModel> Get()
        {

            List<EmployeeModel> output = new List<EmployeeModel>();
            EmployeeModel outputItem = new EmployeeModel();
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM employee";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while(reader.Read())
                {
                    outputItem.EmpID = reader.IsDBNull("emp_id") ? 0 : reader.GetUInt32("emp_id");
                    outputItem.PinNumber = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number");
                    outputItem.IsAdmin = reader.IsDBNull("admin") ? false : (0 != reader.GetInt16("admin"));
                    outputItem.FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name");
                    outputItem.LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name");
                    outputItem.Email = reader.IsDBNull("email") ? "" : reader.GetString("email");
                    outputItem.Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1");
                    outputItem.Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2");
                    outputItem.City = reader.IsDBNull("city") ? "" : reader.GetString("city");
                    outputItem.State = reader.IsDBNull("state") ? "" : reader.GetString("state");
                    outputItem.ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip");
                    outputItem.PhoneNumber = reader.IsDBNull("phone") ? 0 : reader.GetUInt32("phone");
                    output.Add(outputItem);
                }
            }
            finally
            {
                reader.Close();
            }
            db.CloseConnnection();
            return output;
        }

        // GET: api/Employee/ID
        [HttpGet("{employeeID}")]
        public IActionResult Get(String employeeID)
        {
            EmployeeModel outputItem = new EmployeeModel();
            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT * FROM employee WHERE emp_id = @empID";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("empID", employeeID));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        outputItem.EmpID = reader.IsDBNull("emp_id") ? 0 : reader.GetUInt32("emp_id");
                        outputItem.PinNumber = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number");
                        outputItem.IsAdmin = reader.IsDBNull("admin") ? false : (0 != reader.GetInt16("admin"));
                        outputItem.FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name");
                        outputItem.LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name");
                        outputItem.Email = reader.IsDBNull("email") ? "" : reader.GetString("email");
                        outputItem.Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1");
                        outputItem.Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2");
                        outputItem.City = reader.IsDBNull("city") ? "" : reader.GetString("city");
                        outputItem.State = reader.IsDBNull("state") ? "" : reader.GetString("state");
                        outputItem.ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip");
                        outputItem.PhoneNumber = reader.IsDBNull("phone") ? 0 : reader.GetUInt32("phone");
                    }

                }
                finally
                {
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

            db.CloseConnnection();
            Console.WriteLine("\nConnection Closed.");
            return Ok(outputItem);
        }

    }
}