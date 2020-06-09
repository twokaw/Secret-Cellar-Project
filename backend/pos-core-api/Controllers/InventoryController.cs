﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using Shared;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        // Initializing a new database connection objection from the DbConn helper.
        // This class allows me to open and close a connection to the database via methods. 
        DbConn db = new DbConn();


        /// <summary>
        /// A get all request that retrieves all the items in the inventory. 
        /// </summary>
        /// <returns>
        /// Returns a list of iventory items. 
        /// </returns>
        // GET: api/Inventory
        [HttpGet]
        public IActionResult Get()
        {
            List<Inventory> output = new List<Inventory>();
            db.OpenConnection();

            //change to view that does sum
            string sqlStatement = @"
                    SELECT *
                    FROM v_inventory 
               ";
            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                output = fetchInventory(reader);
            }
            finally
            {
                reader.Close();
            }
            db.CloseConnnection();
            return Ok(output);
        }
      
        /// <summary>
        /// Returns a single item that matches the barcode that is sent. 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>
        /// A single inventory item that matches the barcode. 
        /// </returns>
        // GET: api/Inventory/barcode
        [HttpGet("{barcode}", Name = "GetInventory")]
        public IActionResult Get(String barcode)
        {
            List<Inventory> output = null;

            try
            {
                db.OpenConnection();

                string sqlStatement = @"
                    SELECT *
                    FROM v_inventory 
                    WHERE barcode = @bar
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", barcode));
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    output = fetchInventory(reader);
                }
                finally
                {
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }

            if (output == null || output.Count == 0) 
                return StatusCode(400, $"That item with the barcode '{barcode}' does not exist. Please enter a valid barcode.");
            else
                return Ok(output[0]);
        }

        /// <summary>
        /// Creates a new inventory item and stores it in the inventory description table.
        /// </summary>
        /// <param name="tester"></param>
        /// <returns></returns>
        // POST: api/Inventory
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


        private void updateDiscount(Inventory inv)
        {
            //Inserting into inventory_description
           string sql = @"                   
                    DELETE FROM Discount_Inventory WHERE InventoryID = @InventoryID;
                ";

            MySqlCommand cmd = new MySqlCommand(sql, db.Connection()); 
            
            inv.Discount.ForEach(x => sql += @$"                   
                    INSERT INTO inventory_description 
                    (discountID, InventoryID) 
                    VALUES 
                    ({x.DiscountID}, @InventoryID);
                ");

            cmd = new MySqlCommand(sql, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("InventoryID", inv.Id));
            cmd.ExecuteNonQuery();
        }


        //Create a post method for adding items to the inventory_price.
        /// <summary>
        /// Udpates and existing item in the inventory_description table.
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="tester"></param>
        /// <returns></returns>
        // PUT: api/Inventory/barcode
        [HttpPut("{barcode}", Name = "PutDescription")]
        public IActionResult Put(String barcode, [FromBody] Inventory tester)
        {
            if(DoesBarcodeExist(tester.Barcode))
                return Post(tester);

            try
            {
                db.OpenConnection();

                string sqlStatementType = @"
                    UPDATE inventory_description 
                    SET name = @name, supplierID = @supplierID, 
                        barcode = @barcode, retail_price = @retailPrice, 
                        description = @description, typeID = @typeID, 
                        bottle_deposit_qty = @bottleDepositQty,
                        nontaxable = @nonTaxable, 
                        nontaxable_local = @nonTaxableLocal 
                    WHERE barcode = @bar;
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementType, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", barcode));
                cmd.Parameters.Add(new MySqlParameter("id", tester.Id));
                cmd.Parameters.Add(new MySqlParameter("name", tester.Name));
                cmd.Parameters.Add(new MySqlParameter("supplierID", tester.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", tester.Barcode));
                cmd.Parameters.Add(new MySqlParameter("retailPrice", tester.RetailPrice));
                cmd.Parameters.Add(new MySqlParameter("description", tester.Description));
                cmd.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottleDepositQty", tester.Bottles));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", tester.NonTaxable));
                
                cmd.ExecuteNonQuery();
                updateDiscount(tester);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }

            return Ok(tester.Id);
        }

        // DELETE: api/[controller]/id
        [HttpDelete("{Invid}")]
        public IActionResult Delete(int Invid)
        {

            try
            {
                db.OpenConnection();

                string sqlStatementType = "DELETE FROM inventory_description WHERE InventoryID = @id";
                MySqlCommand cmd = new MySqlCommand(sqlStatementType, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("id", Invid));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            db.CloseConnnection();

            return Ok("Item succesfully Deleted.");
        }

        private List<Inventory> fetchInventory(MySqlDataReader reader)
        {
            List<Inventory> output = new List<Inventory>();

            Inventory outputItem = null;
            while (reader.Read())
            {
                outputItem = output.FirstOrDefault(x => x.Id == reader.GetUInt32("InventoryId"));

                if (outputItem == null)
                {
                    outputItem = new Inventory();
                    outputItem.Id = reader.IsDBNull("InventoryId") ? 0 : reader.GetUInt32("InventoryId");
                    outputItem.Name = reader.IsDBNull("name") ? "" : reader.GetString("name");
                    outputItem.SupplierID = reader.IsDBNull("supplierID") ? 0 : reader.GetUInt32("supplierID");
                    outputItem.Barcode = reader.IsDBNull("barcode") ? "" : reader.GetString("barcode");
                    outputItem.Price = reader.IsDBNull("retail_price") ? 0.00 : reader.GetDouble("retail_price");
                    outputItem.Description = reader.IsDBNull("description") ? "" : reader.GetString("description");
                    outputItem.TypeID = reader.IsDBNull("typeID") ? 0 : reader.GetUInt32("typeID");
                    outputItem.Bottles = reader.IsDBNull("bottles") ? 0 : reader.GetUInt32("bottles");
                    outputItem.NonTaxable = reader.IsDBNull("nontaxable") ? false : (0 != reader.GetInt16("nontaxable"));
                    outputItem.NonTaxableLocal = reader.IsDBNull("nontaxable_local") ? false : (0 != reader.GetInt16("nontaxable_local"));
                    outputItem.Qty = reader.IsDBNull("inventory_qty") ? 0 : reader.GetUInt32("inventory_qty");
                    outputItem.SupplierPrice = reader.IsDBNull("supplier_price") ? 0.00 : reader.GetDouble("supplier_price");
                    outputItem.PurchasedDate = reader.IsDBNull("purchased_date") ? DateTime.Now : reader.GetDateTime("purchased_date");
                    outputItem.ItemType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name");
                    output.Add(outputItem);
                }

                if (!reader.IsDBNull("discountID"))
                    outputItem.Discount.Add(new Discount()
                    {
                        DiscountID = reader.GetUInt32("discountID"),
                        DiscountName = reader.GetString("discountName"),
                        Min = reader.IsDBNull("minqty") ? 0 : reader.GetUInt32("minqty"),
                        Max = reader.IsDBNull("maxqty") ? 99999999 : reader.GetUInt32("maxqty"),
                        Amount = reader.GetDouble("Discount"),
                        Enabled = reader.IsDBNull("minqty") && reader.IsDBNull("maxqty")
                    }) ;
            }
            return output;
        }

        /// <summary>
        /// Method that checks if the barcode already exist.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>True if the barcode exist.</returns>
        private bool DoesBarcodeExist(string barcode)
        {
            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT barcode FROM inventory_description WHERE barcode = @barcode";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("barcode", barcode));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    return reader.Read();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
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

        /// <summary>
        /// Method that checks if the id already exist.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>True if the barcode exist.</returns>
        private bool DoesIDExist(uint id)
        {
            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT id FROM inventory_description WHERE InventoryID = @id";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("id", id));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    return reader.Read();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
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
    }
}

