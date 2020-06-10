using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Helpers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        DbConn db = new DbConn();

        /// <summary>
        /// A get all request that retrieves all the suppliers. 
        /// </summary>
        /// <returns>
        /// Returns a list of supplier. 
        /// </returns>
        // GET: api/Supplier
        [HttpGet]
        public IActionResult Get()
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
                using (MySqlDataReader reader = cmd.ExecuteReader())
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
            return Ok(output);
        }

        /// <summary>
        /// A get request that retrieves a specific supplier. 
        /// </summary>
        /// <returns>
        /// Returns a list of iventory items. 
        /// </returns>
        // GET: api/Supplier
        [HttpGet("{supplierID}", Name = "Get Supplier")]
        public IActionResult GetSupplier(uint supplierID)
        {
            Supplier output = Get_Supplier(supplierID);

            if (output == null)
                return StatusCode(400, $"The '{supplierID}' does not exist. ");
            else
                return Ok(output);
        }

        /// <summary>
        /// Creates a new Supplier.
        /// </summary>
        /// <param name="supplier"></param>
        /// <returns></returns>
        // PUT: api/Supplier
        [HttpPut]
        public IActionResult Put([FromBody] Supplier supplier)
        {
            if (supplier.SupplierID != 0 && Get_Supplier(supplier.SupplierID) != null)
            {
                try
                {
                    UpdateSupplier(supplier);
                }
                catch(Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
                return StatusCode(201, supplier.SupplierID);
            }
            
            // The Id is invalid and the supplier name is in the system
            if(Get_Supplier(supplier.Name) != null)
            {
                return StatusCode(500, "Supplier already in the system");
            }

            // The Supplier is not in the system so insert it
            try
            {
                return StatusCode(201, InsertSupplier(supplier));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        private uint InsertSupplier(Supplier supplier)
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

        private void  UpdateSupplier(Supplier supplier)
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


        private Supplier Get_Supplier(uint supplierID)
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
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        output = new Supplier()
                        {
                            SupplierID = uint.Parse(reader["supplierID"].ToString()),
                            Name = reader["name"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Web = reader["web"].ToString()
                        };
                }
            }
            finally
            {
                db.CloseConnnection();
            }

            return output;
        }

        private Supplier Get_Supplier(string name)
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
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        output = new Supplier()
                        {
                            SupplierID = uint.Parse(reader["supplierID"].ToString()),
                            Name = reader["name"].ToString(),
                            Phone = reader["phone"].ToString(),
                            Web = reader["web"].ToString()
                        };
                }
            }
            finally
            {
                db.CloseConnnection();
            }

            return output;
        }

        private List<Supplier> GetSuppliers()
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
                using (MySqlDataReader reader = cmd.ExecuteReader())
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
            return output ;
        }

    }
}
