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
    public class InventoryORM
    {
        readonly DbConn db = new DbConn();

        /// <summary>
        /// Method that checks if the barcode already exist.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>True if the barcode exist.</returns>
        public bool DoesBarcodeExist(string barcode)
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


        public List<Inventory> GetInv()
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

        public Inventory GetInv(uint id)
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

        public Inventory GetInv(string barcode)
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
                using MySqlDataReader reader = cmd.ExecuteReader();

                output = fetchInventory(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output[0];
        }

        public List<Inventory> fetchInventory(MySqlDataReader reader)
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
                    outputItem.TypeID = reader.IsDBNull("typeID") ? 0 : reader.GetUInt32("typeID");
                    outputItem.Bottles = reader.IsDBNull("bottles") ? 0 : reader.GetUInt32("bottles");
                    outputItem.NonTaxable = !reader.IsDBNull("nontaxable") && (0 != reader.GetInt16("nontaxable"));
                    outputItem.NonTaxableLocal = !reader.IsDBNull("nontaxable_local") && (0 != reader.GetInt16("nontaxable_local"));
                    outputItem.ItemType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name");
                    outputItem.BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0 : reader.GetDouble("bottle_deposit");
                    outputItem.IdTax = reader.IsDBNull("idTax") ? 0 : reader.GetUInt32("idTax");
                    outputItem.SalesTax = reader.IsDBNull("sales_tax") ? 0 : reader.GetDouble("sales_tax");
                    outputItem.LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0 : reader.GetDouble("local_sales_tax");
                    output.Add(outputItem);
                }

                if (!reader.IsDBNull("discountID")
                && outputItem.Discounts.FirstOrDefault(x => x.DiscountID == reader.GetUInt32("discountID")) == null)
                    outputItem.Discounts.Add(new Discount()
                    {
                        DiscountID = reader.GetUInt32("discountID"),
                        DiscountName = reader.GetString("discountName"),
                        Min = reader.IsDBNull("minqty") ? 0 : reader.GetUInt32("minqty"),
                        Max = reader.IsDBNull("maxqty") ? 99999999 : reader.GetUInt32("maxqty"),
                        Amount = reader.GetDouble("Discount"),
                        Enabled = reader.IsDBNull("minqty") && reader.IsDBNull("maxqty")
                    });

                if (!reader.IsDBNull("supplier_Price")
                && outputItem.AllQty.FirstOrDefault(x => x.SupplierPrice == reader.GetDouble("supplier_Price")) == null)
                    outputItem.AllQty.Add(new InventoryQty()
                    {
                        PurchasedDate = reader.GetDateTime("purchased_date"),
                        SupplierPrice = reader.GetDouble("Supplier_price"),
                        Qty = reader.IsDBNull("Inventory_Qty") ? 0 : reader.GetUInt32("Inventory_Qty")
                    });
            }
            return output;
        }
    }
}