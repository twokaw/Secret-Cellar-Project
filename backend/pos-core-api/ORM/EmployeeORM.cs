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

        public EmployeeModel Get(String employeeID)
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
                (pin_number, typeID, first_name, last_name, email, addr1, addr2, city, state, zip, phone)
                VALUES 
                (@pinNumber, @typeID, @firstName, @lastName, @email, @addr1, @addr2, @city, @state, @zip, @phone)
            ");
            cmd.Parameters.Add(new MySqlParameter("pinNumber", emp.PinNumber));
            cmd.Parameters.Add(new MySqlParameter("typeid", emp.EmployeeType.TypeID));
            cmd.Parameters.Add(new MySqlParameter("firstName", emp.FirstName));
            cmd.Parameters.Add(new MySqlParameter("lastName", emp.LastName));
            cmd.Parameters.Add(new MySqlParameter("email", emp.Email));
            cmd.Parameters.Add(new MySqlParameter("addr1", emp.Address1));
            cmd.Parameters.Add(new MySqlParameter("addr2", emp.Address2));
            cmd.Parameters.Add(new MySqlParameter("city", emp.City));
            cmd.Parameters.Add(new MySqlParameter("state", emp.State));
            cmd.Parameters.Add(new MySqlParameter("zip", emp.ZipCode));
            cmd.Parameters.Add(new MySqlParameter("phone", emp.PhoneNumber));

            try
            {
                cmd.ExecuteNonQuery();

                return 0;
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
                SET pin_number = @pinNumber, typeid = @typeid, 
                    first_name = @firstName, last_name = @lastName, 
                    email = @email, addr1 = @addr1, addr2 = @addr2, 
                    city = @city, state = @state, zip = @zip, phone = @phone 
                WHERE emp_id = @empID
            ");

            cmd.Parameters.Add(new MySqlParameter("pinNumber", emp.PinNumber));
            cmd.Parameters.Add(new MySqlParameter("typeid", emp.EmployeeType.TypeID));
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
                        emp =  new EmployeeModel
                        {
                            EmpID = empid,
                            PinNumber = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number"),
                            FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name"),
                            LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name"),
                            Email = reader.IsDBNull("email") ? "" : reader.GetString("email"),
                            Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1"),
                            Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2"),
                            City = reader.IsDBNull("city") ? "" : reader.GetString("city"),
                            State = reader.IsDBNull("state") ? "" : reader.GetString("state"),
                            ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip"),
                            PhoneNumber = reader.IsDBNull("phone") ? "" : reader.GetString("phone"),
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
            }
            db.CloseCommand(cmd);
            return output;
        }
    }
}