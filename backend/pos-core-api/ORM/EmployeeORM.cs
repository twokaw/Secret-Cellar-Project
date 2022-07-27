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
        readonly DbConn db = new();

        // Get: api/employee
        public List<EmployeeModel> Get()
        {            
            string sqlStatement = @"
              SELECT * FROM v_employee
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);

            return Get(cmd);
        }

        public EmployeeModel Get(string userName)
        {
            //  EmployeeModel outputItem;

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT * 
              FROM v_employee 
              WHERE user_name = @userName
            ");
            cmd.Parameters.Add(new MySqlParameter("userName", userName));

            return Get(cmd)?[0];
        }
        public EmployeeModel Get(int employeeID)
        {
            //  EmployeeModel outputItem;

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT * 
              FROM v_employee 
              WHERE emp_id = @empID
            ");
            cmd.Parameters.Add(new MySqlParameter("empID", employeeID));

            return Get(cmd)?[0];
        }

        // POST: api/Employee
        public long Insert(EmployeeModel emp)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SET SQL_MODE = '';
                INSERT INTO employee 
                (pin_number, typeID, user_name, first_name, last_name, email, addr1, addr2, city, state, zip, phone)
                VALUES 
                (@pinNumber, @typeID, @username, @firstName, @lastName, @email, @addr1, @addr2, @city, @state, @zip, @phone)
            ");
            cmd.Parameters.Add(new MySqlParameter("pinNumber", emp.PinNumber));
            cmd.Parameters.Add(new MySqlParameter("typeid", emp.EmployeeType.TypeID));
            cmd.Parameters.Add(new MySqlParameter("userName", emp.UserName?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("firstName", emp.FirstName.Trim()));
            cmd.Parameters.Add(new MySqlParameter("lastName", emp.LastName?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("email", emp.Email?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("addr1", emp.Address1?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("addr2", emp.Address2?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("city", emp.City?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("state", emp.State?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("zip", emp.ZipCode?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("phone", emp.PhoneNumber?.Trim()));

            try
            {
                cmd.ExecuteNonQuery();

                return cmd.LastInsertedId;
            }
            finally 
            {
                db.CloseCommand(cmd);
            }
        }

        public void Update( EmployeeModel emp)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE employee 
                SET pin_number = @pinNumber, typeid = @typeid, user_name = @userName, 
                    first_name = @firstName, last_name = @lastName, 
                    email = @email, addr1 = @addr1, addr2 = @addr2, 
                    city = @city, state = @state, zip = @zip, phone = @phone, end_date = @end_date 
                WHERE emp_id = @empID
            ");

            cmd.Parameters.Add(new MySqlParameter("pinNumber", emp.PinNumber));
            cmd.Parameters.Add(new MySqlParameter("typeid", emp.EmployeeType.TypeID));
            cmd.Parameters.Add(new MySqlParameter("userName", emp.UserName?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("firstName", emp.FirstName?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("lastName", emp.LastName?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("email", emp.Email?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("addr1", emp.Address1?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("addr2", emp.Address2?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("city", emp.City?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("state", emp.State?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("zip", emp.ZipCode?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("phone", emp.PhoneNumber?.Trim()));
            cmd.Parameters.Add(new MySqlParameter("empID", emp.EmpID));
            cmd.Parameters.Add(new MySqlParameter("end_date", emp.EndDate));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void Delete(uint EmpID)
        {
            // Disable instead of delete
            // Verify no transaction were made
            // Change the tranasction to generic user
            MySqlCommand cmd = db.CreateCommand(@"
              DELETE FROM employee 
              WHERE emp_id = @EmpID
            ");
            cmd.Parameters.Add(new MySqlParameter("EmpID", EmpID));            

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        /* Obsolete
        public bool DoesEmployeeExist(uint empID)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT emp_id 
                FROM   employee 
                WHERE  emp_id = @empID
            ");
            cmd.Parameters.Add(new MySqlParameter("empID", empID));
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
        */

        // Helper: get SQL 
        private List<EmployeeModel> Get(MySqlCommand cmd)
        {
            List<EmployeeModel> output = new();
            EmployeeModel emp = null;
            MySqlDataReader reader = cmd.ExecuteReader();
            uint empid;

            try
            {
                while (reader.Read())
                {
                    empid = reader.GetUInt32("emp_id");

                    if (emp is null || emp.EmpID != empid)
                    {
                        emp = new EmployeeModel
                        {
                            EmpID = empid,
                            PinNumber = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number"),
                            UserName = reader.IsDBNull("user_name") ? "" : reader.GetString("user_name"),
                            FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name"),
                            LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name"),
                            Email = reader.IsDBNull("email") ? "" : reader.GetString("email"),
                            Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1"),
                            Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2"),
                            City = reader.IsDBNull("city") ? "" : reader.GetString("city"),
                            State = reader.IsDBNull("state") ? "" : reader.GetString("state"),
                            ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip"),
                            PhoneNumber = reader.IsDBNull("phone") ? "" : reader.GetString("phone"),
                            StartDate = reader.IsDBNull("start_date") ? DateTime.MinValue : reader.GetDateTime("start_date"),
                            EndDate = reader.IsDBNull("end_date") ? null : reader.GetDateTime("end_date"),
                            EmployeeType = new EmployeeTypeModel() 
                            { 
                                TypeID = reader.IsDBNull("TypeID") ? 0 : reader.GetUInt32("TypeID"),
                                TypeName = reader.IsDBNull("TypeName") ? "" : reader.GetString("TypeName")
                            }
                        };

                        output.Add(emp);
                    }

                    emp.EmployeeType.Roles.Add(new EmployeeRoleModel()
                    {
                        RoleID = reader.IsDBNull("RoleID") ? 0 : reader.GetUInt32("RoleID"),
                        RoleName = reader.IsDBNull("RoleName") ? "" : reader.GetString("RoleName"),
                        RoleDescription = reader.IsDBNull("RoleDescription") ? "" : reader.GetString("RoleDescription")
                    });
                }
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
            
            return output;
        }
    }
}