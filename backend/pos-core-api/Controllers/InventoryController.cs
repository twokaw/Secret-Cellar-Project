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
                    outputItem.InventoryID = reader.GetUInt32("inventoryID");
                    outputItem.Name = reader.GetString("name");
                    outputItem.SupplierID = reader.GetUInt32("supplierID");
                    outputItem.Barcode = reader.GetString("barcode");
                    outputItem.RetailPrice = reader.GetDouble("retail_price");
                    outputItem.Description = reader.GetString("description");
                    outputItem.TypeID = reader.GetUInt32("typeID");
                    outputItem.BottleDepositQty = reader.GetUInt32("bottle_deposit_qty");
                    outputItem.NonTaxable = (0 != reader.GetInt16("nontaxable"));
                    outputItem.NonTaxableLocal = (0 != reader.GetInt16("nontaxable_local"));
                    outputItem.InventoryQty = reader.GetUInt32("inventory_qty");
                    outputItem.SupplierPrice = reader.GetDouble("supplier_price");
                    outputItem.PurchasedDate = reader.GetDateTime("purchased_date");
                    outputItem.InventoryType = reader.GetString("inventory_type_name");
                    outputItem.DiscountDown = reader.GetDouble("6_to_11_case_discount");
                    outputItem.DiscountUp = reader.GetDouble("12_or_more_case_discount");
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

        // GET: api/Inventory/id
        [HttpGet("{id}", Name = "Get")]
        public Inventory Get(String id)
        {
            Inventory item = new Inventory();

            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT * FROM inventory_description LEFT OUTER JOIN inventory_price USING(inventoryID) LEFT OUTER JOIN inventory_type USING(typeID) WHERE barcode = @bar";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", id));
                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        item.InventoryID = reader.GetUInt32("inventoryID");
                        item.Name = reader.GetString("name");
                        item.SupplierID = reader.GetUInt32("supplierID");
                        item.Barcode = reader.GetString("barcode");
                        item.RetailPrice = reader.GetDouble("retail_price");
                        item.Description = reader.GetString("description");
                        item.TypeID = reader.GetUInt32("typeID");
                        item.BottleDepositQty = reader.GetUInt32("bottle_deposit_qty");
                        item.NonTaxable =(0 != reader.GetInt16("nontaxable"));
                        item.NonTaxableLocal = (0 != reader.GetInt16("nontaxable_local"));
                        item.InventoryQty = reader.GetUInt32("inventory_qty");
                        item.SupplierPrice = reader.GetDouble("supplier_price");
                        item.PurchasedDate = reader.GetDateTime("purchased_date");
                        item.InventoryType = reader.GetString("inventory_type_name");
                        item.DiscountDown = reader.GetDouble("6_to_11_case_discount");
                        item.DiscountUp = reader.GetDouble("12_or_more_case_discount");
                    }

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
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");
            return item;
        }

        // POST: api/Inventory
        [HttpPost]
        public void Post([FromBody] Inventory tester)
        {
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
                cmdPrice.Parameters.Add(new MySqlParameter("purchasedDate", tester.PurchasedDate));
                MySqlDataReader reader1 = cmdPrice.ExecuteReader();
                reader1.Read();
                reader1.Close();

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
                throw ex;
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");
        }

        // PUT: api/Inventory/5
        [HttpPut("{id}")]
        public void Put(String id, [FromBody] Inventory tester)
        {
            try
            {
                db.OpenConnection();

                string sqlStatement = "UPDATE inventory_description SET name = @name WHERE barcode = @bar";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("name", tester.Name));
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
