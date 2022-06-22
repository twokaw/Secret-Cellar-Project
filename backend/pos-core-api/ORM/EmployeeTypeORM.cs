using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Shared;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;

namespace pos_core_api.ORM
{
    public class EmployeeTypeORM
    {
        readonly DbConn db = new();
        private const string EMPLOYEETYPESQL = @"
              SELECT *
              FROM employeetype
              join employeetyperole
              using(typeid)
              LEFT JOIN Employeerole
              USING(roleid)";

        // Get: api/employee
        public List<EmployeeTypeModel> Get()
        {
            MySqlCommand cmd = db.CreateCommand(EMPLOYEETYPESQL);

            return Get(cmd);
        }

        public EmployeeTypeModel Get(uint typeId)
        {
            MySqlCommand cmd = db.CreateCommand(@$"
              {EMPLOYEETYPESQL}
              WHERE typeid = @typeid
            ");
            cmd.Parameters.Add(new MySqlParameter("typeid", typeId));

            List<EmployeeTypeModel> list = Get(cmd);

            return list.Count > 0 ?list[0] : null;
        }

        public EmployeeTypeModel Get(string typeName)
        {
            MySqlCommand cmd = db.CreateCommand(@"
              SELECT * 
              FROM employeeType 
              WHERE TypeName = @TypeName
            ");
            cmd.Parameters.Add(new MySqlParameter("TypeName", typeName));

            List<EmployeeTypeModel> list = Get(cmd);

            return list.Count > 0 ? Get(cmd)[0] : null;
        }

        public uint Insert(EmployeeTypeModel empTyp)
        {
            EmployeeTypeModel checkEmp = Get(empTyp.TypeName);
            if (checkEmp != null)
            {
                empTyp.TypeID = checkEmp.TypeID;
                Update(empTyp);
                return empTyp.TypeID;
            }
            else
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
        }

        public uint InsertRole(EmployeeRoleModel role)
        {
            EmployeeRoleModel oldrole = GetRole(role.RoleName);

            if (oldrole == null)
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    INSERT INTO employeeRole 
                    (RoleName, RoleDescription)
                    VALUES 
                    (@RoleName, @RoleDescription)
                ");

                cmd.Parameters.Add(new MySqlParameter("RoleName", role.RoleName));
                cmd.Parameters.Add(new MySqlParameter("RoleDescription", role.RoleDescription));

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
            else
                return oldrole.RoleID;
        }

        public long AddRole(uint typeId, uint roleId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO employeeTypeRole
                (TypeId, RoleId)
                VALUES 
                (@TypeId, @RoleId)
            ");

            cmd.Parameters.Add(new MySqlParameter("TypeId", typeId));
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

        public EmployeeTypeModel Update( EmployeeTypeModel empType)
        {
            EmployeeTypeModel prev = Get(empType.TypeID);

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

            foreach (EmployeeRoleModel role in empType.Roles)
                if (!prev.Roles.Any(x => x.RoleID == role.RoleID))
                    AddRole(empType.TypeID, role.RoleID);

            foreach (EmployeeRoleModel role in prev.Roles)
                if (!empType.Roles.Any(x => x.RoleID == role.RoleID))
                    RemoveRole(empType.TypeID, role.RoleID);
            
            return empType;
        }

        public List<EmployeeRoleModel> GetRoles()
        {
            List<EmployeeRoleModel> empRoles = new List<EmployeeRoleModel>();
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT * 
                FROM employeerole         
            ");
            return FetchRoles(cmd);
        }

        public EmployeeRoleModel GetRole(int roleId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT * 
                FROM employeerole            
                WHERE rolename = @roleID
            ");
            cmd.Parameters.AddWithValue("RoleID", roleId);
            List<EmployeeRoleModel> empRoles = FetchRoles(cmd);
            return (empRoles.Count > 0) ? empRoles[0] : null;
        }

        public EmployeeRoleModel GetRole(string roleName)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT * 
                FROM employeerole            
                WHERE roleName = @roleName
            ");
            cmd.Parameters.AddWithValue("roleName", roleName);
            List<EmployeeRoleModel> empRoles = FetchRoles(cmd);
            return (empRoles.Count > 0) ? empRoles[0] : null;
        }

        public List<EmployeeRoleModel> FetchRoles(MySqlCommand cmd)
        {
            List<EmployeeRoleModel> empRoles = new List<EmployeeRoleModel>();
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                    empRoles.Add(new EmployeeRoleModel()
                    {
                        RoleID = reader.IsDBNull("roleID") ? 0 : reader.GetUInt32("roleID"),
                        RoleName = reader.IsDBNull("roleName") ? "" : reader.GetString("roleName"),
                        RoleDescription = reader.IsDBNull("roleDescription") ? "" : reader.GetString("roleDescription")
                    });

            }
            finally { reader.Close(); }
            return empRoles;
        }

        public EmployeeRoleModel UpdateRole(EmployeeRoleModel empRole)
        {

            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE employeeRole 
                SET RoleName = @Rolename,
                    RoleDescription = @RoleDescription
                WHERE roleid = @roleID
            ");

            cmd.Parameters.Add(new MySqlParameter("roleID", empRole.RoleID ));
            cmd.Parameters.Add(new MySqlParameter("roleName", empRole.RoleName));
            cmd.Parameters.Add(new MySqlParameter("roleDescription", empRole.RoleDescription));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            return empRole;
        }
        public void RemoveRole(uint typeId, uint roleId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                DELETE FROM  employeeTypeRole
                WHERE TypeId = @TypeId
                AND   RoleId = @RoleId
            ");

            cmd.Parameters.Add(new MySqlParameter("TypeId", typeId));
            cmd.Parameters.Add(new MySqlParameter("RoleId", roleId));

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
                    typeid = reader.GetUInt32("typeid");

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