using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shared;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;

namespace pos_core_api.ORM
{
    public class EmployeeTypeORM
    {
        readonly DbConn db = new();

        // Get: api/employee
        public List<EmployeeTypeModel> Get()
        {
            List<EmployeeModel> output = new();
            
            string sqlStatement = @"
              SELECT * 
              FROM employee_type
              LEFT JOIN Employee_role
              USING(typeid)
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
           
            return Get(cmd);
        }

        public EmployeeTypeModel Get(uint employeeID)
        {
          //  EmployeeModel outputItem;

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT * 
              FROM employee 
              WHERE emp_id = @empID
            ");
            cmd.Parameters.Add(new MySqlParameter("empID", employeeID));

            return Get(cmd)[0];
        }

        public uint Insert(EmployeeTypeModel empTyp)
        {
            uint id;
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO employeeType 
                (TypeName)
                VALUES 
                (@TypeName)
            ");

            cmd.Parameters.Add(new MySqlParameter("TypeName", empTyp.TypeName));

            try
            {
                cmd.ExecuteNonQuery();
                id = Convert.ToUInt32(cmd.LastInsertedId);

                empTyp.Roles.ForEach(x => AddRole(id, x.RoleID));
                return id;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public uint InsertRole(string roleName, string roleDescription)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO employeeRole 
                (RoleName, RoleDecription)
                VALUES 
                (@RoleName, RoleDecription)
            ");

            cmd.Parameters.Add(new MySqlParameter("RoleName", roleName));
            cmd.Parameters.Add(new MySqlParameter("RoleDescription", roleDescription));

            try
            {
                cmd.ExecuteNonQuery();
                return Convert.ToUInt32(cmd.LastInsertedId);
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public long AddRole(uint empId, uint roleId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO employeeTypeRole
                (TypeId, RoleId)
                VALUES 
                (@TypeId, @RoleId)
            ");

            cmd.Parameters.Add(new MySqlParameter("TypeId", empId));
            cmd.Parameters.Add(new MySqlParameter("RoleId", roleId));

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

        public void Update( EmployeeTypeModel empType)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE employeetype 
                SET typeName = @typeName
                WHERE typeid = @typeID
            ");

            cmd.Parameters.Add(new MySqlParameter("typeID", empType.TypeID));
            cmd.Parameters.Add(new MySqlParameter("typeName", empType.TypeName));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void UpdateTypeRoles(EmployeeTypeModel empType)
        {

            EmployeeTypeModel prev = Get(empType.TypeID);

            MySqlCommand cmd = db.CreateCommand(@"
                 employeetypeRole 
                SET typeName = @typeName
                WHERE typeid = @typeID
            ");

            cmd.Parameters.Add(new MySqlParameter("typeID", empType.TypeID));
            cmd.Parameters.Add(new MySqlParameter("typeName", empType.TypeName));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void RemoveRoles(EmployeeTypeModel empType)
        {

            EmployeeTypeModel prev = Get(empType.TypeID);

            MySqlCommand cmd = db.CreateCommand(@"
                INSERT employeetypeRole 
                (TypeId, RoleId)
                (@typeid, @RoleID)
            ");

            cmd.Parameters.Add(new MySqlParameter("typeID", empType.TypeID));
            cmd.Parameters.Add(new MySqlParameter("RoleID", empType.TypeName));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
        public void Delete(uint typeId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
              DELETE FROM employeeRole 
              WHERE roleid = @typeID;

              DELETE FROM employeeType 
              WHERE typeid = @typeID;
            ");

            cmd.Parameters.Add(new MySqlParameter("typeID", typeId));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public bool DoesEmployeeTypeExist(uint typeId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT typeid 
                FROM   employeeType 
                WHERE  typeid = @typeid
            ");

            cmd.Parameters.Add(new MySqlParameter("typeid", typeId));
            
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
        private List<EmployeeTypeModel> Get(MySqlCommand cmd)
        {
            List<EmployeeTypeModel> output = new();
            EmployeeTypeModel empType = null;
            MySqlDataReader reader = cmd.ExecuteReader();
            uint typeid;

            try
            {
                while (reader.Read())
                {
                    typeid = reader.GetUInt32("emp_id");

                    if (empType is null || empType.TypeID != typeid)
                    {
                        empType = new EmployeeTypeModel
                        {
                                TypeID = reader.IsDBNull("TypeID") ? 0 : reader.GetUInt32("TypeID"),
                                TypeName = reader.IsDBNull("TypeName") ? "" : reader.GetString("TypeName")
                        };

                        output.Add(empType);
                    }

                    empType.Roles.Add(new EmployeeRoleModel()
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