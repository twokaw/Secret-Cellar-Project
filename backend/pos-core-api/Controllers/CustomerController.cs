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
using System.Linq.Expressions;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        DbConn db = new DbConn();

        // Get: api/Customer
        [HttpGet]
        public List<CustomerModel> Get()
        {

            List<CustomerModel> output = new List<CustomerModel>();
            CustomerModel outputItem;
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM customer";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    outputItem = new CustomerModel();
                    outputItem.CustomerID = reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID");
                    outputItem.CustomerDiscount = reader.IsDBNull("customer_discount") ? 0.0 : reader.GetDouble("customer_discount");
                    outputItem.FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name");
                    outputItem.LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name");
                    outputItem.BusinessName = reader.IsDBNull("business_name") ? "" : reader.GetString("business_name");
                    outputItem.Email = reader.IsDBNull("email") ? "" : reader.GetString("email");
                    outputItem.IsWholesale = reader.IsDBNull("isWholesale") ? false : reader.GetBoolean("isWholesale");
                    outputItem.Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1");
                    outputItem.Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2");
                    outputItem.City = reader.IsDBNull("city") ? "" : reader.GetString("city");
                    outputItem.State = reader.IsDBNull("state") ? "" : reader.GetString("state");
                    outputItem.ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip");
                    outputItem.PhoneNumber = reader.IsDBNull("phone") ? "" : reader.GetString("phone");
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

        // GET: api/Customer/ID
        [HttpGet("{customerID}")]
        public IActionResult Get(String customerID)
        {
            CustomerModel outputItem = new CustomerModel();
            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT * FROM customer WHERE customerID = @custID";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("custID", customerID));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        outputItem.CustomerID = reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID");
                        outputItem.CustomerDiscount = reader.IsDBNull("customer_discount") ? 0.0 : reader.GetDouble("customer_discount");
                        outputItem.FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name");
                        outputItem.LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name");
                        outputItem.BusinessName = reader.IsDBNull("business_name") ? "" : reader.GetString("business_name");
                        outputItem.Email = reader.IsDBNull("email") ? "" : reader.GetString("email");
                        outputItem.IsWholesale = reader.IsDBNull("isWholesale") ? false : reader.GetBoolean("isWholesale");
                        outputItem.Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1");
                        outputItem.Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2");
                        outputItem.City = reader.IsDBNull("city") ? "" : reader.GetString("city");
                        outputItem.State = reader.IsDBNull("state") ? "" : reader.GetString("state");
                        outputItem.ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip");
                        outputItem.PhoneNumber = reader.IsDBNull("phone") ? "" : reader.GetString("phone");

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


        // POST: api/Customer
        [HttpPost]
        public IActionResult Post([FromBody] CustomerUpdateModel cust)
        {

            try
            {
                db.OpenConnection();

                string sqlStatementDesc =
                    "SET SQL_MODE = '';" +
                    "INSERT INTO customer (customer_discount, first_name, last_name, business_name, email, isWholesale, addr1, addr2, city, state, zip, phone)" +
                    "VALUES (@customerDiscount, @firstName, @lastName, @businessName, @email, @isWholesale, @addr1, @addr2, @city, @state, @zip, @phone)";
                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("customerDiscount", cust.CustomerDiscount));
                cmd.Parameters.Add(new MySqlParameter("firstName", cust.FirstName));
                cmd.Parameters.Add(new MySqlParameter("lastName", cust.LastName));
                cmd.Parameters.Add(new MySqlParameter("businessName", cust.BusinessName));
                cmd.Parameters.Add(new MySqlParameter("email", cust.Email));
                cmd.Parameters.Add(new MySqlParameter("isWholesale", cust.IsWholesale));
                cmd.Parameters.Add(new MySqlParameter("addr1", cust.Address1));
                cmd.Parameters.Add(new MySqlParameter("addr2", cust.Address2));
                cmd.Parameters.Add(new MySqlParameter("city", cust.City));
                cmd.Parameters.Add(new MySqlParameter("state", cust.State));
                cmd.Parameters.Add(new MySqlParameter("zip", cust.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("phone", cust.PhoneNumber));
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");

            return Ok();
        }

        // PUT: api/Customer/{custID}
        [HttpPut("{custID}")]
        public IActionResult Put(uint custID, [FromBody] CustomerUpdateModel cust)
        {
            db.OpenConnection();

            try
            {
                string sqlStatementDesc = 
                    "UPDATE customer " +
                    "SET customer_discount = @customerDiscount, first_name = @firstName, last_name = @lastName, business_name = @businessName," +
                    "email = @email, isWholesale = @isWholesale, addr1 = @addr1, addr2 = @addr2, city = @city, state = @state, zip = @zip, phone = @phone " +
                    "WHERE customerID = @custID";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("customerDiscount", cust.CustomerDiscount));
                cmd.Parameters.Add(new MySqlParameter("firstName", cust.FirstName));
                cmd.Parameters.Add(new MySqlParameter("lastName", cust.LastName));
                cmd.Parameters.Add(new MySqlParameter("businessName", cust.BusinessName));
                cmd.Parameters.Add(new MySqlParameter("email", cust.Email));
                cmd.Parameters.Add(new MySqlParameter("isWholesale", cust.IsWholesale));
                cmd.Parameters.Add(new MySqlParameter("addr1", cust.Address1));
                cmd.Parameters.Add(new MySqlParameter("addr2", cust.Address2));
                cmd.Parameters.Add(new MySqlParameter("city", cust.City));
                cmd.Parameters.Add(new MySqlParameter("state", cust.State));
                cmd.Parameters.Add(new MySqlParameter("zip", cust.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("phone", cust.PhoneNumber));
                cmd.Parameters.Add(new MySqlParameter("custID", custID));
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");
            return Ok();
        }

        // Delete: api/Customer/{custID}
        [HttpDelete("{custID}")]
        public void Delete(uint custID)
        {
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = "DELETE FROM customer WHERE customerID = @CustID";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("custID", custID));
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");
        }
    }
}