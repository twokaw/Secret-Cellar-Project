using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class InventoryORM
    {
        readonly DbConn db = new DbConn();

        /// <summary>
        /// Method that checks if the barcode already exist.
        /// </summary>
        /// <param name="barcode">Item Barcode to check</param>
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
                    outputItem = new Inventory
                    {
                        Id = reader.IsDBNull("InventoryId") ? 0 : reader.GetUInt32("InventoryId"),
                        Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                        SupplierID = reader.IsDBNull("supplierID") ? 0 : reader.GetUInt32("supplierID"),
                        Barcode = reader.IsDBNull("barcode") ? "" : reader.GetString("barcode"),
                        Price = reader.IsDBNull("retail_price") ? 0.00 : reader.GetDouble("retail_price"),
                        TypeID = reader.IsDBNull("typeID") ? 0 : reader.GetUInt32("typeID"),
                        Bottles = reader.IsDBNull("bottles") ? 0 : reader.GetUInt32("bottles"),
                        NonTaxable = !reader.IsDBNull("nontaxable") && (0 != reader.GetInt16("nontaxable")),
                        NonTaxableLocal = !reader.IsDBNull("nontaxable_local") && (0 != reader.GetInt16("nontaxable_local")),
                        ItemType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name"),
                        BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0 : reader.GetDouble("bottle_deposit"),
                        IdTax = reader.IsDBNull("idTax") ? 0 : reader.GetUInt32("idTax"),
                        Hidden = reader.IsDBNull("hidden") ? false : reader.GetBoolean("hidden"),
                        SalesTax = reader.IsDBNull("sales_tax") ? 0 : reader.GetDouble("sales_tax"),
                        LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0 : reader.GetDouble("local_sales_tax"),
                        InvMax = reader.IsDBNull("InvMax") ? 0 : reader.GetUInt32("InvMax"),
                        InvMin = reader.IsDBNull("InvMin") ? 0 : reader.GetUInt32("InvMin"),
                        OrderQty = reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty")
                    };
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
     
        public long Insert(Inventory inv)
        {
            long lastID = -1;

            if (DoesBarcodeExist(inv.Barcode))
                throw new Exception ("Barcode already exist.");

            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                    INSERT INTO inventory_description 
                    (name, supplierID, barcode, retail_price, typeID, bottle_deposit_qty, nontaxable, nontaxable_local, InvMax, InvMin, OrderQty) 
                    VALUES 
                    (@name, @supplierID, @barcode, @Price, @typeID, @bottles, @nonTaxable, @nonTaxableLocal, @InvMax, OrderQty);
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
                cmd.Parameters.Add(new MySqlParameter("InvMax", inv.InvMax));
                cmd.Parameters.Add(new MySqlParameter("InvMin", inv.InvMin));
                cmd.Parameters.Add(new MySqlParameter("OrderQty", inv.OrderQty));
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
            finally
            {
                db.CloseConnnection();
            }

            return lastID;
        }

        public long Update(Inventory inv) {
            Inventory i = DataAccess.Instance.Inventory.GetInv(inv.Id);

            if (string.IsNullOrWhiteSpace(inv.Barcode))
                inv.Barcode = inv.Name.Replace(" ", "").ToUpper();
            else
                inv.Barcode = inv.Barcode.Replace(" ", "").ToUpper();

            if (i == null)
                return Insert(inv);
            else if (i.Barcode != inv.Barcode.Trim().ToUpper() && DoesBarcodeExist(inv.Barcode))
                throw new Exception("Barcode already exist.");

            try
            {
                db.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE inventory_description 
                    SET name = @name, supplierID = @supplierID, 
                        barcode = @barcode, retail_price = @Price, 
                        typeID = @typeID, 
                        bottle_deposit_qty = @bottleDepositQty,
                        nontaxable = @nonTaxable, 
                        nontaxable_local = @nonTaxableLocal,
                        InvMax = @InvMax, 
                        InvMin = @InvMin, 
                        OrderQty = @OrderQty
                    WHERE InventoryId = @id;
                ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("name", inv.Name));
                cmd.Parameters.Add(new MySqlParameter("supplierID", inv.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", inv.Barcode));
                cmd.Parameters.Add(new MySqlParameter("Price", inv.Price));
                cmd.Parameters.Add(new MySqlParameter("typeID", inv.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottleDepositQty", inv.Bottles));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", inv.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", inv.NonTaxableLocal));
                cmd.Parameters.Add(new MySqlParameter("InvMax", inv.InvMax));
                cmd.Parameters.Add(new MySqlParameter("InvMin", inv.InvMin));
                cmd.Parameters.Add(new MySqlParameter("OrderQty", inv.OrderQty));
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                cmd = new MySqlCommand(@"
                   UPDATE inventory_price 
                   SET    Inventory_Qty  = @qty, 
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
            finally
            {
                db.CloseConnnection();
            }

            return inv.Id;
        }

        public void Delete(uint invId)
        {
            try
            {
                db.OpenConnection();

                string sqlStatementType = "DELETE FROM inventory_description WHERE InventoryID = @id";
                MySqlCommand cmd = new MySqlCommand(sqlStatementType, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("id", invId));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
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
    }
}