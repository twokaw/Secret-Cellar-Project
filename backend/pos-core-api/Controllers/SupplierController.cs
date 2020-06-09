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
        // POST: api/Supplier
        [HttpPost]
        public IActionResult Post([FromBody] Supplier supplier)
        {
            long lastID = -1;
            if (supplier.SupplierID != 0 && Get_Supplier(supplier.SupplierID) == null)
            {
                return StatusCode(400, "Supplier already exist.");
            }
            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                    INSERT INTO inventory_description 
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
                lastID = cmd.LastInsertedId;

                supplier.SupplierID = Convert.ToUInt32(cmd.LastInsertedId);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }

            return StatusCode(201, lastID);
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
