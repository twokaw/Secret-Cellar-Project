using System;
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
        /*
         * Initializing a new database connection objection from the DbConn helper.
         * This class allows me to open and close a connection to the database via methods. 
         */
        DbConn db = new DbConn();

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
            Inventory outputItem;
            db.OpenConnection();
            //change to view that does sum
            //string sqlStatement = "SELECT * FROM inventory_quantity;";
            string sql = @"
                SELECT *
                FROM inventory_description
                JOIN  inventory_price
                using(inventoryID)
                JOIN inventory_type
                USING (typeID);";
            MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    outputItem = new Shared.Inventory
                    {
                        InventoryID = reader.IsDBNull("inventoryID") ? 0 : reader.GetUInt32("inventoryID"),
                        Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                        SupplierID = reader.IsDBNull("supplierID") ? 0 : reader.GetUInt32("supplierID"),
                        Barcode = reader.IsDBNull("barcode") ? "" : reader.GetString("barcode"),
                        RetailPrice = reader.IsDBNull("retail_price") ? 0.00 : reader.GetDouble("retail_price"),
                        Description = reader.IsDBNull("description") ? "" : reader.GetString("description"),
                        TypeID = reader.IsDBNull("typeID") ? 0 : reader.GetUInt32("typeID"),
                        BottleDepositQty = reader.IsDBNull("bottle_deposit_qty") ? 0 : reader.GetUInt32("bottle_deposit_qty"),
                        NonTaxable = reader.IsDBNull("nontaxable") ? false : (0 != reader.GetInt16("nontaxable")),
                        NonTaxableLocal = reader.IsDBNull("nontaxable_local") ? false : (0 != reader.GetInt16("nontaxable_local")),
                        InventoryQty = reader.IsDBNull("inventory_qty") ? 0 : reader.GetUInt32("inventory_qty"),
                        SupplierPrice = reader.IsDBNull("supplier_price") ? 0.00 : reader.GetDouble("supplier_price"),
                        PurchasedDate = reader.IsDBNull("purchased_date") ? DateTime.Now : reader.GetDateTime("purchased_date"),
                        InventoryType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name"),
                        DiscountDown = reader.IsDBNull("6_to_11_case_discount") ? 0.00 : reader.GetDouble("6_to_11_case_discount"),
                        DiscountUp = reader.IsDBNull("12_or_more_case_discount") ? 0.00 : reader.GetDouble("12_or_more_case_discount")
                    };

                    output.Add(outputItem);
                }
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
            Inventory outputItem = new Inventory();

            if (!DoesBarcodeExist(barcode)) return StatusCode(400, String.Format("That item with the barcode '{0}' does not exist. Please enter a valid barcode.", barcode));

            try
            {
                db.OpenConnection();

                string sqlStatement = @"
                SELECT *
                FROM inventory_description
                JOIN  inventory_price
                using (inventoryID)
                    JOIN inventory_type
                USING(typeID)
                WHERE barcode = @bar LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", barcode));
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {

                    while (reader.Read())
                    {

                        outputItem.InventoryID = reader.IsDBNull("inventoryID") ? 0 : reader.GetUInt32("inventoryID");
                        outputItem.Name = reader.IsDBNull("name") ? "" : reader.GetString("name");
                        outputItem.SupplierID = reader.IsDBNull("supplierID") ? 0 : reader.GetUInt32("supplierID");
                        outputItem.Barcode = reader.IsDBNull("barcode") ? "" : reader.GetString("barcode");
                        outputItem.RetailPrice = reader.IsDBNull("retail_price") ? 0.00 : reader.GetDouble("retail_price");
                        outputItem.Description = reader.IsDBNull("description") ? "" : reader.GetString("description");
                        outputItem.TypeID = reader.IsDBNull("typeID") ? 0 : reader.GetUInt32("typeID");
                        outputItem.BottleDepositQty = reader.IsDBNull("bottle_deposit_qty") ? 0 : reader.GetUInt32("bottle_deposit_qty");
                        outputItem.NonTaxable = reader.IsDBNull("nontaxable") ? false : (0 != reader.GetInt16("nontaxable"));
                        outputItem.NonTaxableLocal = reader.IsDBNull("nontaxable_local") ? false : (0 != reader.GetInt16("nontaxable_local"));
                        outputItem.InventoryQty = reader.IsDBNull("inventory_qty") ? 0 : reader.GetUInt32("inventory_qty");
                        outputItem.SupplierPrice = reader.IsDBNull("supplier_price") ? 0.00 : reader.GetDouble("supplier_price");
                        outputItem.PurchasedDate = reader.IsDBNull("purchased_date") ? DateTime.Now : reader.GetDateTime("purchased_date");
                        outputItem.InventoryType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name");
                        outputItem.DiscountDown = reader.IsDBNull("6_to_11_case_discount") ? 0.00 : reader.GetDouble("6_to_11_case_discount");
                        outputItem.DiscountUp = reader.IsDBNull("12_or_more_case_discount") ? 0.00 : reader.GetDouble("12_or_more_case_discount");

                    }

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
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");
            return Ok(outputItem);
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
            if (DoesBarcodeExist(tester.Barcode))
            {
                return StatusCode(400, "Barcode already exist.");
            }
            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sqlStatementDesc = "SET SQL_MODE = '';INSERT INTO inventory_description (name, supplierID, barcode, retail_price, description, typeID, bottle_deposit_qty, nontaxable, nontaxable_local) VALUES (@name, @supplierID, @barcode, @retailPrice, @description, @typeID, @bottleDepositQty, @nonTaxable, @nonTaxableLocal)";
                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                //cmd.Parameters.Add(new MySqlParameter("id", tester.InventoryID));
                cmd.Parameters.Add(new MySqlParameter("name", tester.Name));
                cmd.Parameters.Add(new MySqlParameter("supplierID", tester.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", tester.Barcode));
                cmd.Parameters.Add(new MySqlParameter("retailPrice", tester.RetailPrice));
                cmd.Parameters.Add(new MySqlParameter("description", tester.Description));
                cmd.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottleDepositQty", tester.BottleDepositQty));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", tester.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", tester.NonTaxableLocal));
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");

            return StatusCode(201, "Item succesfully created.");
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
            try
            {
                db.OpenConnection();

                string sqlStatementType = "UPDATE inventory_description SET name = @name, supplierID = @supplierID, barcode = @barcode, retail_price = @retailPrice, description = @description, typeID = @typeID, bottle_deposit_qty = @bottleDepositQty, nontaxable = @nonTaxable, nontaxable_local = @nonTaxableLocal WHERE barcode = @bar";
                MySqlCommand cmd = new MySqlCommand(sqlStatementType, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", barcode));
                cmd.Parameters.Add(new MySqlParameter("id", tester.InventoryID));
                cmd.Parameters.Add(new MySqlParameter("name", tester.Name));
                cmd.Parameters.Add(new MySqlParameter("supplierID", tester.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", tester.Barcode));
                cmd.Parameters.Add(new MySqlParameter("retailPrice", tester.RetailPrice));
                cmd.Parameters.Add(new MySqlParameter("description", tester.Description));
                cmd.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottleDepositQty", tester.BottleDepositQty));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", tester.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", tester.NonTaxableLocal));
                MySqlDataReader reader2 = cmd.ExecuteReader();
                reader2.Read();
                reader2.Close();

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");

            return Ok("Item succesfully updated.");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

