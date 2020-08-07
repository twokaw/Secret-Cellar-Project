using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shared;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;

namespace pos_core_api.ORM
{
    public class EmployeeORM
    {
        readonly DbConn db = new DbConn();

        // Get: api/employee
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
                    outputItem = new EmployeeModel
                    {
                        EmpID = reader.IsDBNull("emp_id") ? 0 : reader.GetUInt32("emp_id"),
                        PinNumber = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number"),
                        IsAdmin = !reader.IsDBNull("admin") && (0 != reader.GetInt16("admin")),
                        FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name"),
                        LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name"),
                        Email = reader.IsDBNull("email") ? "" : reader.GetString("email"),
                        Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1"),
                        Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2"),
                        City = reader.IsDBNull("city") ? "" : reader.GetString("city"),
                        State = reader.IsDBNull("state") ? "" : reader.GetString("state"),
                        ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip"),
                        PhoneNumber = reader.IsDBNull("phone") ? "" : reader.GetString("phone")
                    };
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

        public EmployeeModel Get(String employeeID)
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
                        outputItem.IsAdmin = !reader.IsDBNull("admin") && (0 != reader.GetInt16("admin"));
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
            finally
            {
                db.CloseConnnection();
            }
    
            return outputItem;
        }

        // POST: api/Employee
        [HttpPost]
        public long Insert(EmployeeModel emp)
        {
            try
            {
                db.OpenConnection();

                string sqlStatementDesc = @"
                    SET SQL_MODE = '';
                    INSERT INTO employee 
                    (pin_number, admin, first_name, last_name, email, addr1, addr2, city, state, zip, phone)
                    VALUES 
                    (@pinNumber, @admin, @firstName, @lastName, @email, @addr1, @addr2, @city, @state, @zip, @phone)
                ";

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

                cmd.ExecuteNonQuery();

                return 0;
            }
            finally 
            {
                db.CloseConnnection();
            }
        }

        public void Update( EmployeeModel emp)
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
                cmd.Parameters.Add(new MySqlParameter("empID", emp.EmpID));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public void Delete(uint EmpID)
        {
            db.OpenConnection();

            try
            {
                string sqlStatementDesc = "DELETE FROM employee WHERE emp_id = @EmpID";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("EmpID", EmpID));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public bool DoesEmployeeExist(uint empID)
        {
            try
            {

                db.OpenConnection();

                string sqlStatement = @"
                    SELECT emp_id 
                    FROM   employee 
                    WHERE  emp_id = @empID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("empID", empID));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    return reader.Read();
                }
                finally
                {
                    reader.Close();
                }
            }
            finally
            {
                db.CloseConnnection();
            }
        }
    }
}