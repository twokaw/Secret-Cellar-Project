using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class SupplierORM
    {
        readonly DbConn db = new DbConn();

        /// <summary>
        /// A get all request that retrieves all the suppliers. 
        /// </summary>
        /// <returns>
        /// Returns a list of supplier. 
        /// </returns>
        public List<Supplier> Get()
        {
            List<Supplier> output = new List<Supplier>();
            db.OpenConnection();

            //change to view that does sum
            string sqlStatement = @"
                    SELECT *
                    FROM supplier
               ";
            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output.Add(new Supplier()
                    {
                        SupplierID = uint.Parse(reader["supplierID"].ToString()),
                        Name = reader["name"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Web = reader["web"].ToString()
                    });
            }
            finally
            {
                db.CloseConnnection();
            }
            return output;
        }


        public uint Insert(Supplier supplier)
        {
            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                    INSERT INTO supplier
                    (name,  web, phone) 
                    VALUES 
                    (@name,  @Web, @phone);
                ";

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
                //cmd.Parameters.Add(new MySqlParameter("id", tester.Id));
                cmd.Parameters.Add(new MySqlParameter("name", supplier.Name));
                cmd.Parameters.Add(new MySqlParameter("web", supplier.Web));
                cmd.Parameters.Add(new MySqlParameter("phone", supplier.Phone));

                cmd.ExecuteNonQuery();

                return Convert.ToUInt32(cmd.LastInsertedId);
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

        public uint Update(Supplier supplier)
        {
            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                    UPDATE Supplier
                    SET name = @name,
                        web  =  @Web,
                        phone = @phone
                    WHERE SupplierID = @SupplierID;
                ";

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("SupplierID", supplier.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("name", supplier.Name));
                cmd.Parameters.Add(new MySqlParameter("web", supplier.Web));
                cmd.Parameters.Add(new MySqlParameter("phone", supplier.Phone));

                cmd.ExecuteNonQuery();
                return supplier.SupplierID;
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


        public Supplier Get(uint supplierID)
        {
            Supplier output = null;
            db.OpenConnection();

            //change to view that does sum
            string sqlStatement = @"
                SELECT *
                FROM supplier
                WHERE supplierID = @id
            ";
            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("id", supplierID));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    output = new Supplier()
                    {
                        SupplierID = uint.Parse(reader["supplierID"].ToString()),
                        Name = reader["name"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Web = reader["web"].ToString()
                    };
            }
            finally
            {
                db.CloseConnnection();
            }

            return output;
        }

        public Supplier Get(string name)
        {
            Supplier output = null;
            db.OpenConnection();

            //change to view that does sum
            string sqlStatement = @"
                SELECT *
                FROM supplier
                WHERE name = @name
            ";
            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("name", name));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    output = new Supplier()
                    {
                        SupplierID = uint.Parse(reader["supplierID"].ToString()),
                        Name = reader["name"].ToString(),
                        Phone = reader["phone"].ToString(),
                        Web = reader["web"].ToString()
                    };
            }
            finally
            {
                db.CloseConnnection();
            }

            return output;
        }

       //public List<Supplier> Get()
       // {
       //     List<Supplier> output = new List<Supplier>();
       //     db.OpenConnection();

       //     //change to view that does sum
       //     string sqlStatement = @"
       //             SELECT *
       //             FROM supplier
       //        ";
       //     MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
       //     try
       //     {
       //         using (MySqlDataReader reader = cmd.ExecuteReader())
       //             while (reader.Read())
       //                 output.Add(new Supplier()
       //                 {
       //                     SupplierID = uint.Parse(reader["supplierID"].ToString()),
       //                     Name = reader["name"].ToString(),
       //                     Phone = reader["phone"].ToString(),
       //                     Web = reader["web"].ToString()
       //                 });
       //     }
       //     finally
       //     {
       //         db.CloseConnnection();
       //     }
       //     return output;
       // }
    }
}
