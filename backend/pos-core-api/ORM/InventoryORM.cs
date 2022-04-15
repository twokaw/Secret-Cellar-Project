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
        readonly DbConn db = new();

        /// <summary>
        /// Method that checks if the barcode already exist.
        /// </summary>
        /// <param name="barcode">Item Barcode to check</param>
        /// <returns>True if the barcode exist.</returns>
        public bool DoesBarcodeExist(string barcode)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT barcode 
                FROM inventory_description 
                WHERE barcode = @barcode
            ");
            cmd.Parameters.Add(new MySqlParameter("barcode", barcode));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                    return reader.Read();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public List<Inventory> GetInv()
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT *
                FROM v_inventory 
            ");   
            
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                return FetchInventory(reader);
            }
            finally 
            {
                db.CloseCommand(cmd);
            }
        }

        public Inventory GetInv(uint id)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT *
                FROM v_inventory 
                WHERE Inventoryid = @id
            ");

            cmd.Parameters.Add(new MySqlParameter("id", id));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                return FetchInventory(reader)[0];
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public Inventory GetInv(string barcode)
        {
            using MySqlCommand cmd = db.CreateCommand(@"
                SELECT *
                FROM v_inventory 
                WHERE barcode = @bar
            ");

            cmd.Parameters.Add(new MySqlParameter("bar", barcode));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();

                return FetchInventory(reader)[0];
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public string GetInvHash()
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT HashValue
                FROM v_inventory_hash
            "); 

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return reader.GetString("HashValue");
                else
                    return "";
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public List<Inventory> FetchInventory(MySqlDataReader reader)
        {
            List<Inventory> output = new();

            Inventory outputItem = null;
            while (reader.Read())
            {
                outputItem = output.FirstOrDefault(x => x.Id == reader.GetUInt32("InventoryId"));

                if (outputItem == null)
                {
                    try
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
                            Hidden = !reader.IsDBNull("hidden") && reader.GetBoolean("hidden"),
                            SalesTax = reader.IsDBNull("sales_tax") ? 0 : reader.GetDouble("sales_tax"),
                            LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0 : reader.GetDouble("local_sales_tax"),
                            InvMax = reader.IsDBNull("InvMax") ? 0 : reader.GetUInt32("InvMax"),
                            InvMin = reader.IsDBNull("InvMin") ? 0 : reader.GetUInt32("InvMin"),
                            OrderIncrement = reader.GetUInt32("OrderIncrement"),
                            OrderQty = reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty"),
                            RequestQty = reader.IsDBNull("RequestQty") ? 0 : reader.GetUInt32("RequestQty"),
                            RequiredQty = reader.IsDBNull("RequiredQty") ? 0 : reader.GetUInt32("RequiredQty")
                        };
                        output.Add(outputItem);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        throw;
                    }
                }

                try
                {
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
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }

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
            if (DoesBarcodeExist(inv.Barcode))
                throw new Exception ("Barcode already exist.");

            if (string.IsNullOrWhiteSpace(inv.Barcode))
                inv.Barcode = inv.Name.Replace(" ", "").ToUpper();
            else
                inv.Barcode = inv.Barcode.Replace(" ", "").ToUpper();

            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO inventory_description 
                (name, supplierID, barcode, retail_price, typeID, bottle_deposit_qty, nontaxable, nontaxable_local, InvMax, InvMin, OrderQty, Hidden) 
                VALUES 
                (@name, @supplierID, @barcode, @Price, @typeID, @bottles, @nonTaxable, @nonTaxableLocal, @InvMax, @InvMin, @OrderQty, @Hidden);
            ");

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
            cmd.Parameters.Add(new MySqlParameter("Hidden", inv.Hidden));

            try
            {
                cmd.ExecuteNonQuery();

                inv.Id = Convert.ToUInt32(cmd.LastInsertedId);
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            //Inserting into inventory_description

            cmd = db.CreateCommand(@"
                INSERT INTO inventory_price 
                (inventoryID, Inventory_Qty, Supplier_price) 
                VALUES 
                (@id, @qty, @supplier_price);
            ");

            //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
            cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
            cmd.Parameters.Add(new MySqlParameter("Qty", inv.Qty));
            cmd.Parameters.Add(new MySqlParameter("Supplier_price", inv.SupplierPrice));
            
            try
            {
                cmd.ExecuteNonQuery();

                UpdateDiscount(inv);
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            return inv.Id;
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

            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE inventory_description 
                SET name = @name, supplierID = @supplierID, 
                    barcode = @barcode, retail_price = @Price, 
                    typeID = @typeID, 
                    bottle_deposit_qty = @bottleDepositQty,
                    nontaxable = @nonTaxable, 
                    nontaxable_local = @nonTaxableLocal,
                    InvMax = @InvMax, 
                    InvMin = @InvMin, 
                    OrderQty = @OrderQty, 
                    Hidden = @Hidden
                WHERE InventoryId = @id;
            ");

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
            cmd.Parameters.Add(new MySqlParameter("Hidden", inv.Hidden));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            cmd = db.CreateCommand(@"
                INSERT INTO  inventory_price 
                (inventoryid, Inventory_Qty, Supplier_price)
                VALUES 
                (@id, @Qty, @Supplier_price)
                ON DUPLICATE KEY UPDATE Inventory_Qty  = @qty, 
                        Supplier_price = @supplier_price;
            ");

            cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
            cmd.Parameters.Add(new MySqlParameter("Qty", inv.Qty));
            cmd.Parameters.Add(new MySqlParameter("Supplier_price", inv.SupplierPrice));

            try
            {
                cmd.ExecuteNonQuery();

                UpdateDiscount(inv);
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            return inv.Id;
        }

        public void Delete(uint invId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                DELETE FROM inventory_description 
                WHERE InventoryID = @id
            ");
            cmd.Parameters.Add(new MySqlParameter("id", invId));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        private void UpdateDiscount(Inventory inv)
        {
            //Inserting into inventory_description
            string sql = @"                   
                DELETE FROM Discount_Inventory 
                WHERE InventoryID = @InventoryID;
            ";

            inv.Discounts.ForEach(x => sql += @$"                   
                INSERT INTO Discount_Inventory
                (discountID, InventoryID) 
                VALUES 
                ({x.DiscountID}, @InventoryID);
            ");

            MySqlCommand cmd = db.CreateCommand(sql);

            cmd = db.CreateCommand(sql);
            cmd.Parameters.Add(new MySqlParameter("InventoryID", inv.Id));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
    }
}