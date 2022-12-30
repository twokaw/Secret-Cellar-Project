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
            

            //change to view that does sum
            string sqlStatement = @"
                    SELECT *
                    FROM supplier
               ";
            MySqlCommand cmd = db.CreateCommand(sqlStatement);
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
                db.CloseCommand(cmd);
            }
            return output;
        }


        public uint Insert(Supplier supplier)
        { 
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO supplier
                (name,  web, phone) 
                VALUES 
                (@name,  @web, @phone);
            ");

            //cmd.Parameters.Add(new MySqlParameter("id", tester.Id));
            cmd.Parameters.Add(new MySqlParameter("name", supplier.Name));
            cmd.Parameters.Add(new MySqlParameter("web", supplier.Web));
            cmd.Parameters.Add(new MySqlParameter("phone", supplier.Phone));

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

        public uint Update(Supplier supplier)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE supplier
                SET name  = @name,
                    web   = @web,
                    phone = @phone
                WHERE supplierid = @supplierid;
            ");
            cmd.Parameters.Add(new MySqlParameter("SupplierID", supplier.SupplierID));
            cmd.Parameters.Add(new MySqlParameter("name", supplier.Name));
            cmd.Parameters.Add(new MySqlParameter("web", supplier.Web));
            cmd.Parameters.Add(new MySqlParameter("phone", supplier.Phone));

            try
            {
                cmd.ExecuteNonQuery();
                return supplier.SupplierID;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }


        public Supplier Get(uint supplierID)
        {
            Supplier output = null;
            

            //change to view that does sum
            string sqlStatement = @"
                SELECT *
                FROM supplier
                WHERE supplierid = @id
            ";
            MySqlCommand cmd = db.CreateCommand(sqlStatement);
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
                db.CloseCommand(cmd);
            }

            return output;
        }

        public Supplier Get(string name)
        {
            Supplier output = null;
            

            //change to view that does sum
            string sqlStatement = @"
                SELECT *
                FROM supplier
                WHERE name = @name
            ";
            MySqlCommand cmd = db.CreateCommand(sqlStatement);
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
                db.CloseCommand(cmd);
            }

            return output;
        }

       //public List<Supplier> Get()
       // {
       //     List<Supplier> output = new List<Supplier>();
       //     

       //     //change to view that does sum
       //     string sqlStatement = @"
       //             SELECT *
       //             FROM supplier
       //        ";
       //     MySqlCommand cmd = db.CreateCommand(sqlStatement);
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
       //         db.CloseCommand(cmd);
       //     }
       //     return output;
       // }
    }
}
