using System;
using Microsoft.AspNetCore.Mvc;
using Shared;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        DbConn db = new DbConn();

        // Get: api/employee
        [HttpGet]
        public List<EmployeeModel> Get()
        {

            List<EmployeeModel> output = new List<EmployeeModel>();
            EmployeeModel outputItem;
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM employee";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    outputItem = new EmployeeModel();
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


        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] EmployeeUpdateModel emp)
        {
            // first, check if employee ID already exists
            /*if (DoesEmployeeExist(tester.EmpID))
            {
                return StatusCode(400, "Employee ID already exists.");
            }*/

            try
            {
                db.OpenConnection();

                string sqlStatementDesc =
                    "SET SQL_MODE = '';" +
                    "INSERT INTO employee (pin_number, admin, first_name, last_name, email, addr1, addr2, city, state, zip, phone) " +
                    "VALUES (@pinNumber, @admin, @firstName, @lastName, @email, @addr1, @addr2, @city, @state, @zip, @phone)";
                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("pinNumber", emp.PinNumber));
                cmd.Parameters.Add(new MySqlParameter("admin", emp.IsAdmin));
                cmd.Parameters.Add(new MySqlParameter("firstName", emp.FirstName));
                cmd.Parameters.Add(new MySqlParameter("lastName", emp.LastName));
                cmd.Parameters.Add(new MySqlParameter("email", emp.Email));
                cmd.Parameters.Add(new MySqlParameter("addr1", emp.Address1));
                cmd.Parameters.Add(new MySqlParameter("addr2", emp.Address2));
                cmd.Parameters.Add(new MySqlParameter("city", emp.City));
                cmd.Parameters.Add(new MySqlParameter("state", emp.State));
                cmd.Parameters.Add(new MySqlParameter("zip", emp.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("phone", emp.PhoneNumber));
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

        // PUT: api/Employee/{EmpID}
        [HttpPut("{empID}")]
        public IActionResult Put(uint empID, [FromBody] EmployeeUpdateModel emp)
        {
            db.OpenConnection();

            try
            {
                string sqlStatementDesc = "UPDATE employee SET pin_number = @pinNumber, admin = @admin, first_name = @firstName, last_name = @lastName, email = @email, addr1 = @addr1, addr2 = @addr2, city = @city, state = @state, zip = @zip, phone = @phone WHERE emp_id = @empID";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("pinNumber", emp.PinNumber));
                cmd.Parameters.Add(new MySqlParameter("admin", emp.IsAdmin));
                cmd.Parameters.Add(new MySqlParameter("firstName", emp.FirstName));
                cmd.Parameters.Add(new MySqlParameter("lastName", emp.LastName));
                cmd.Parameters.Add(new MySqlParameter("email", emp.Email));
                cmd.Parameters.Add(new MySqlParameter("addr1", emp.Address1));
                cmd.Parameters.Add(new MySqlParameter("addr2", emp.Address2));
                cmd.Parameters.Add(new MySqlParameter("city", emp.City));
                cmd.Parameters.Add(new MySqlParameter("state", emp.State));
                cmd.Parameters.Add(new MySqlParameter("zip", emp.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("phone", emp.PhoneNumber));
                cmd.Parameters.Add(new MySqlParameter("empID", empID));
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

        // Delete: api/Employee/{EmpID}
        [HttpDelete("{EmpID}")]
        public void Delete(uint EmpID)
        {
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = "DELETE FROM employee WHERE emp_id = @EmpID";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("EmpID", EmpID));
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

        private bool DoesEmployeeExist(uint empID)
        {
            try {
                
                db.OpenConnection();
                string sqlStatement = "SELECT emp_id FROM employee WHERE emp_id = @empID";
            
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("empID", empID));
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    return reader.Read();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConnnection();
            }
        }
    }
}