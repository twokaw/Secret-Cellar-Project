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
        public IActionResult GetSupplier(int supplierID)
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

            if (output == null)
                return StatusCode(400, $"The '{supplierID}' does not exist. ");
            else
                return Ok(output);
        }



        /// <summary>
        /// Creates a new Supplier.
        /// </summary>
        /// <param name="tester"></param>
        /// <returns></returns>
        // POST: api/Supplier
        [HttpPost]
        public IActionResult Post([FromBody] Inventory tester)
        {
            long lastID = -1;
            if (DoesBarcodeExist(tester.Barcode))
            {
                return StatusCode(400, "Barcode already exist.");
            }
            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                    INSERT INTO inventory_description 
                    (name, supplierID, barcode, retail_price, description, typeID, bottle_deposit_qty, nontaxable, nontaxable_local) 
                    VALUES 
                    (@name, @supplierID, @barcode, @retailPrice, @description, @typeID, @bottles, @nonTaxable, @nonTaxableLocal);
                ";

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
                //cmd.Parameters.Add(new MySqlParameter("id", tester.Id));
                cmd.Parameters.Add(new MySqlParameter("name", tester.Name));
                cmd.Parameters.Add(new MySqlParameter("supplierID", tester.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", tester.Barcode));
                cmd.Parameters.Add(new MySqlParameter("retailPrice", tester.RetailPrice));
                cmd.Parameters.Add(new MySqlParameter("description", tester.Description));
                cmd.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottles", tester.Bottles));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", tester.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", tester.NonTaxableLocal));
                cmd.ExecuteNonQuery();
                lastID = cmd.LastInsertedId;

                tester.Id = Convert.ToUInt32(cmd.LastInsertedId);

                updateDiscount(tester);
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


    }
}
