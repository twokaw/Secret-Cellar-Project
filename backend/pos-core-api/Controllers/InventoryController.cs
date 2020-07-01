using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
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
                return Ok(GetInv());
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
                output = GetInv(id);
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
                output = GetInv(barcode);
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

            if (DoesBarcodeExist(inv.Barcode))
                return StatusCode(400, "Barcode already exist.");

            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                    INSERT INTO inventory_description 
                    (name, supplierID, barcode, retail_price, description, typeID, bottle_deposit_qty, nontaxable, nontaxable_local) 
                    VALUES 
                    (@name, @supplierID, @barcode, @Price, @description, @typeID, @bottles, @nonTaxable, @nonTaxableLocal);
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
                cmd.Parameters.Add(new MySqlParameter("description", inv.Description.Trim()));
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
            Inventory i = GetInv(inv.Id);

            if (string.IsNullOrWhiteSpace(inv.Barcode))
                inv.Barcode = inv.Name.Replace(" ", "").ToUpper();
            else
                inv.Barcode = inv.Barcode.Replace(" ", "").ToUpper();

            if (i == null)
                return Post(inv);
            else if(i.Barcode != inv.Barcode.Trim().ToUpper() && DoesBarcodeExist(inv.Barcode))
                return StatusCode(400, "Barcode already exist.");
        
            try
            {
                db.OpenConnection();

                string sql = @"
                    UPDATE inventory_description 
                    SET name = @name, supplierID = @supplierID, 
                        barcode = @barcode, retail_price = @Price, 
                        description = @description, typeID = @typeID, 
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
                cmd.Parameters.Add(new MySqlParameter("description", inv.Description));
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


        private List<Inventory> GetInv()
        {
            List<Inventory> output = new List<Inventory>();
            db.OpenConnection();
            try
            {
                //change to view that does sum
                string sqlStatement = @"
                        SELECT *
                        FROM v_inventory 
                   ";
                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                using MySqlDataReader reader = cmd.ExecuteReader();
                output = fetchInventory(reader);
            }
            finally
            {
                db.CloseConnnection();
            }
            
            return output;
        }

        private Inventory GetInv(uint id)
        {
            List<Inventory> output = null;

            try
            {
                db.OpenConnection();

                string sqlStatement = @"
                    SELECT *
                    FROM v_inventory 
                    WHERE Inventoryid = @id
                ";

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("id", id));
                using MySqlDataReader reader = cmd.ExecuteReader();
                output = fetchInventory(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output[0];
        }

        private Inventory GetInv(string barcode)
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

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", barcode));
                MySqlDataReader reader = cmd.ExecuteReader();

                output = fetchInventory(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output[0];
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
                    outputItem.BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0 : reader.GetDouble("bottle_deposit");
                    outputItem.IdTax = reader.IsDBNull("idTax") ? 0 : reader.GetUInt32("idTax");
                    outputItem.SalesTax = reader.IsDBNull("sales_tax") ? 0 : reader.GetDouble("sales_tax");
                    outputItem.LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0 : reader.GetDouble("local_sales_tax");
                    output.Add(outputItem);
                }

                if (!reader.IsDBNull("discountID"))
                    outputItem.Discounts.Add(new Discount()
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
                finally
                {
                    reader.Close();
                }
            }
            finally
            {
                db.CloseConnnection();
            }
        }
    }
}

