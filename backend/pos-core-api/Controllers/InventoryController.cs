using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;
using Shared;
using pos_core_api.ORM;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        // Initializing a new database connection objection from the DbConn helper.
        // This class allows me to open and close a connection to the database via methods. 
        readonly DbConn db = new DbConn();


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
            try
            {
                return Ok(DataAccess.Instance.Inventory.GetInv());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Returns a single item that matches the barcode that is sent. 
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>
        /// A single inventory item that matches the barcode. 
        /// </returns>
        // GET: api/Inventory/barcode
        [HttpGet("id/{id}", Name = "GetInventory")]
        public IActionResult Get(uint id)
        {
            Inventory output;
            try
            {
                output = DataAccess.Instance.Inventory.GetInv(id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            if (output == null)
                return StatusCode(400, $"The item with the id '{id}' does not exist.");
            else
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
        [HttpGet("{barcode}", Name = "GetInventoryBarcode")]
        public IActionResult Get(string barcode)
        {
            Inventory output;

            try
            {
                output = DataAccess.Instance.Inventory.GetInv(barcode);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

            if (output == null) 
                return StatusCode(400, $"That item with the barcode '{barcode}' does not exist.");
            else
                return Ok(output);
        }

        /// <summary>
        /// Creates a new inventory item and stores it in the inventory description table.
        /// </summary>
        /// <param name="inv"></param>
        /// <returns></returns>
        // POST: api/Inventory
        [HttpPost]
        public IActionResult Post([FromBody] Inventory inv)
        {
            long lastID = -1;

            if (DataAccess.Instance.Inventory.DoesBarcodeExist(inv.Barcode))
                return StatusCode(400, "Barcode already exist.");

            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                    INSERT INTO inventory_description 
                    (name, supplierID, barcode, retail_price, typeID, bottle_deposit_qty, nontaxable, nontaxable_local) 
                    VALUES 
                    (@name, @supplierID, @barcode, @Price, @typeID, @bottles, @nonTaxable, @nonTaxableLocal);
                ";

                if (string.IsNullOrWhiteSpace(inv.Barcode))
                    inv.Barcode = inv.Name.Replace(" ", "").ToUpper();
                else
                    inv.Barcode = inv.Barcode.Replace(" ", "").ToUpper();

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());

                //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("name", inv.Name.Trim()));
                cmd.Parameters.Add(new MySqlParameter("supplierID", inv.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", inv.Barcode.Trim().ToUpper()));
                cmd.Parameters.Add(new MySqlParameter("Price", inv.Price));
                cmd.Parameters.Add(new MySqlParameter("typeID", inv.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottles", inv.Bottles));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", inv.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", inv.NonTaxableLocal));
                cmd.ExecuteNonQuery();

                inv.Id = Convert.ToUInt32(cmd.LastInsertedId);
                cmd.Dispose();


                //Inserting into inventory_description
                sql = @"
                    INSERT INTO inventory_price 
                    (name, Inventory_Qty, Supplier_price) 
                    VALUES 
                    (@id, @qty, @supplier_price);
                ";

                cmd = new MySqlCommand(sql, db.Connection());
                //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("Qty", inv.Qty));
                cmd.Parameters.Add(new MySqlParameter("Supplier_price", inv.SupplierPrice));
                cmd.ExecuteNonQuery();

                UpdateDiscount(inv);
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

        private void UpdateDiscount(Inventory inv)
        {
            //Inserting into inventory_description
           string sql = @"                   
                DELETE FROM Discount_Inventory WHERE InventoryID = @InventoryID;
            ";

            inv.Discounts.ForEach(x => sql += @$"                   
                INSERT INTO Discount_Inventory
                (discountID, InventoryID) 
                VALUES 
                ({x.DiscountID}, @InventoryID);
            ");

            MySqlCommand cmd = new MySqlCommand(sql, db.Connection()); 
            
            cmd = new MySqlCommand(sql, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("InventoryID", inv.Id));
            cmd.ExecuteNonQuery();
        }

        //Create a post method for adding items to the inventory_price.
        /// <summary>
        /// Udpates and existing item in the inventory_description table.
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="inv"></param>
        /// <returns></returns>
        // PUT: api/Inventory/barcode
        [HttpPut("{barcode}", Name = "PutDescription")]
        public IActionResult Put([FromBody] Inventory inv)
        {
            Inventory i = DataAccess.Instance.Inventory.GetInv(inv.Id);

            if (string.IsNullOrWhiteSpace(inv.Barcode))
                inv.Barcode = inv.Name.Replace(" ", "").ToUpper();
            else
                inv.Barcode = inv.Barcode.Replace(" ", "").ToUpper();

            if (i == null)
                return Post(inv);
            else if(i.Barcode != inv.Barcode.Trim().ToUpper() && DataAccess.Instance.Inventory.DoesBarcodeExist(inv.Barcode))
                return StatusCode(400, "Barcode already exist.");
        
            try
            {
                db.OpenConnection();

                string sql = @"
                    UPDATE inventory_description 
                    SET name = @name, supplierID = @supplierID, 
                        barcode = @barcode, retail_price = @Price, 
                        typeID = @typeID, 
                        bottle_deposit_qty = @bottleDepositQty,
                        nontaxable = @nonTaxable, 
                        nontaxable_local = @nonTaxableLocal 
                    WHERE InventoryId = @id;
                ";

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", inv.Barcode));
                cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("name", inv.Name));
                cmd.Parameters.Add(new MySqlParameter("supplierID", inv.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", inv.Barcode));
                cmd.Parameters.Add(new MySqlParameter("Price", inv.Price));
                cmd.Parameters.Add(new MySqlParameter("typeID", inv.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottleDepositQty", inv.Bottles));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", inv.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", inv.NonTaxableLocal));
                cmd.ExecuteNonQuery();

                //Inserting into inventory_description
                sql = @"
                   UPDATE inventory_price 
                      Inventory_Qty  = @qty, 
                      Supplier_price = @supplier_price
                   WHERE InventoryId = @id;
                ";
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                cmd = new MySqlCommand(@"
                  UPDATE inventory_price 
                  SET Inventory_Qty = @qty, 
                      Supplier_price = @supplier_price 
                  WHERE InventoryId = @id;
                ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("Qty", inv.Qty));
                cmd.Parameters.Add(new MySqlParameter("Supplier_price", inv.SupplierPrice));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                UpdateDiscount(inv);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }

            return Ok(inv.Id);
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



    }
}

