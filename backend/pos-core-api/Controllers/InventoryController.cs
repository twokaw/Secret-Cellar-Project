using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;

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

        // GET: api/Inventory
        [HttpGet]
        public List<Inventory> Get()
        {
            List<Inventory> output = new List<Inventory>();
            Inventory outputItem;
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM inventory_description LEFT OUTER JOIN inventory_price USING(inventoryID) LEFT OUTER JOIN inventory_type USING(typeID);";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                

                while (reader.Read())
                {
                    outputItem = new Inventory();
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
                    output.Add(outputItem);
                    
                }
            }
            finally
            {
                reader.Close();
            }
            db.CloseConnnection();
            return output;
        }

        

        /*//GET: api/Inventory/barcode/exist
        [HttpGet("{barcode}", Name = "Get")]
        [Route("/api/Inventory/barcode/exist")]
        public bool Get(string barcode)
        {
            return DoesBarcodeExist(barcode);
        }*/
   
        // GET: api/Inventory/barcode
        [HttpGet("{barcode}", Name = "Get")]
        public IActionResult Get(String barcode)
        {
            Inventory outputItem = new Inventory();

            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT * FROM inventory_description LEFT OUTER JOIN inventory_price USING(inventoryID) LEFT OUTER JOIN inventory_type USING(typeID) WHERE barcode = @bar";

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

                string sqlInventoryID = "SET SQL_MODE = '';SELECT * FROM inventory_description WHERE barcode = @bar";
                MySqlCommand cmdID = new MySqlCommand(sqlInventoryID, db.Connection());
                cmdID.Parameters.Add(new MySqlParameter("bar", tester.Barcode));
                MySqlDataReader read = cmdID.ExecuteReader();
                read.Read();
                uint grabbedID = read.GetUInt32("inventoryID");
                Console.WriteLine(grabbedID);
                read.Close();

                //Inserting into inventory_price
                string sqlStatementPrice = "SET SQL_MODE = '';INSERT INTO inventory_price VALUES (@id, @inventoryQty, @supplierPrice, @purchasedDate)";
                MySqlCommand cmdPrice = new MySqlCommand(sqlStatementPrice, db.Connection());
                cmdPrice.Parameters.Add(new MySqlParameter("id", grabbedID));
                cmdPrice.Parameters.Add(new MySqlParameter("inventoryQty", tester.InventoryQty));
                cmdPrice.Parameters.Add(new MySqlParameter("supplierPrice", tester.SupplierPrice));
                cmdPrice.Parameters.Add(new MySqlParameter("purchasedDate", DateTime.Now));
                MySqlDataReader reader1 = cmdPrice.ExecuteReader();
                reader1.Read();
                reader1.Close();


                //Not needed to be created with item when a new item is added. the types will be managed on their own. The type will get selected
                //as a drop down...... so not necessary for us to manage*.. 
                //Inserting into inventory_type
                string sqlStatementType = "SET SQL_MODE = '';INSERT INTO inventory_type VALUES (@typeID, @inventoryType, @discountDown, @discountUp)";
                MySqlCommand cmdType = new MySqlCommand(sqlStatementType, db.Connection());

                cmdType.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmdType.Parameters.Add(new MySqlParameter("inventoryType", tester.InventoryType));
                cmdType.Parameters.Add(new MySqlParameter("discountDown", tester.DiscountDown));
                cmdType.Parameters.Add(new MySqlParameter("discountUp", tester.DiscountUp));
                MySqlDataReader reader2 = cmdType.ExecuteReader();
                reader2.Read();
                reader2.Close();

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");

            return Ok();
        }

        //Create a post method for adding items to the inventory_price.

        // PUT: api/Inventory/5
        [HttpPut("{id}")]
        public void Put(String id, [FromBody] Inventory tester)
        {




            try
            {
                db.OpenConnection();

                //This was a test for adding to the bottle deposit qty.
                //Either work on new controllers and models or for the other table of the database

                string sqlStatement = "UPDATE inventory_description SET bottle_deposit_qty = bottle_deposit_qty + @quantity WHERE barcode = @bar";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("quantity", tester.BottleDepositQty));
                cmd.Parameters.Add(new MySqlParameter("bar", id));
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

//Create model and controllor for inventory_type.
//Create model and controller for users (customer, employee).
//Create model and controller for transaction(transaction, transaction_items).
