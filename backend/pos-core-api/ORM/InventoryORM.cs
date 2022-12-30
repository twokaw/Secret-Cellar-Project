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
                ORDER BY inventoryid, discountid
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
                WHERE inventoryid = @id
                ORDER BY inventoryid, discountid
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
                ORDER BY inventoryid, discountid
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
                SELECT hashvalue
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
                            DiscountPrice = reader.IsDBNull("discount_price") ? 0.00 : reader.GetDouble("discount_price"),
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
                            RequiredQty = reader.IsDBNull("RequiredQty") ? 0 : reader.GetUInt32("RequiredQty"),
                            SuspendedQty = reader.IsDBNull("SuspendedQty") ? 0 : reader.GetUInt32("SuspendedQty")
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
                (name, supplierid, barcode, retail_price, discount_price, typeid, bottle_deposit_qty, nontaxable, nontaxable_local, invmax, invmin, orderqty, hidden) 
                VALUES 
                (@name, @supplierid, @barcode, @price, @discount_price, @typeid, @bottles, @nontaxable, @nontaxablelocal, @invmax, @invmin, @orderqty, @hidden);
            ");

            //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
            cmd.Parameters.Add(new MySqlParameter("name", inv.Name.Trim()));
            cmd.Parameters.Add(new MySqlParameter("supplierID", inv.SupplierID));
            cmd.Parameters.Add(new MySqlParameter("barcode", inv.Barcode.Trim().ToUpper()));
            cmd.Parameters.Add(new MySqlParameter("Price", inv.Price));
            cmd.Parameters.Add(new MySqlParameter("discount_price", inv.DiscountPrice));
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
                (inventoryid, inventory_qty, supplier_price) 
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
                SET name = @name,
                    supplierid = @supplierid, 
                    barcode = @barcode,
                    retail_price = @price,
                    discount_price = @discount_price,
                    typeid = @typeid, 
                    bottle_deposit_qty = @bottledepositqty,
                    nontaxable = @nontaxable, 
                    nontaxable_local = @nontaxablelocal,
                    invmax = @invmax, 
                    invmin = @invmin, 
                    orderqty = @orderqty, 
                    hidden = @hidden
                WHERE inventoryid = @id;
            ");

            cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
            cmd.Parameters.Add(new MySqlParameter("name", inv.Name));
            cmd.Parameters.Add(new MySqlParameter("supplierID", inv.SupplierID));
            cmd.Parameters.Add(new MySqlParameter("barcode", inv.Barcode));
            cmd.Parameters.Add(new MySqlParameter("Price", inv.Price));
            cmd.Parameters.Add(new MySqlParameter("discount_price", inv.DiscountPrice));
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
                INSERT INTO inventory_price 
                (inventoryid, inventory_qty, supplier_price)
                VALUES 
                (@id, @qty, @supplier_price)
                ON DUPLICATE KEY UPDATE inventory_qty  = @qty, 
                        supplier_price = @supplier_price;
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
                WHERE inventoryid = @id
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
            uint discountId;
            MySqlCommand cmd = db.CreateCommand(@"                   
              SELECT i.discountid, i.inventoryid, i.typeid, dt.discountid type_discount, di.discountid inv_discount, enabled
              FROM 
               (
                 SELECT discountid, inventoryid, typeid 
                 FROM   inventory_description
                 CROSS JOIN
                  (
                    SELECT discountid
                    FROM discount
                  ) d
                 WHERE inventoryid = @invid
               ) i
               LEFT JOIN discount_type dt
               ON  i.typeid = dt.typeid 
               AND i.discountid = dt.discountid
 
               LEFT JOIN discount_inventory di
               ON  i.inventoryid = di.inventoryid 
               AND i.discountid = di.discountid;
            ");

            cmd.Parameters.Add(new MySqlParameter("invid", inv.Id));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    discountId  = reader.GetUInt32("discountid");

                    Discount d = inv.Discounts.FirstOrDefault(x => x.DiscountID == discountId);
                    if (d == null)
                    {
                        if (!reader.IsDBNull("type_discount"))
                        {
                            if (reader.IsDBNull("inv_discount"))
                                InsertInvDiscount(inv.Id, discountId, false);
                            else if (reader.GetUInt32("enabled") != 0)
                                UpdateInvDiscount(inv.Id, discountId, false);
                        }
                        else if (!reader.IsDBNull("inv_discount"))
                            DeleteInvDiscount(inv.Id, discountId);
                    }
                    else
                    {
                        if (reader.IsDBNull("type_discount"))
                        {
                            if(reader.IsDBNull("inv_discount"))
                                InsertInvDiscount(inv.Id, discountId, true);
                            else if(reader.GetUInt32("enabled") == 0)
                                UpdateInvDiscount(inv.Id, discountId, true);
                        }
                        else if (!reader.IsDBNull("inv_discount") && reader.GetUInt32("enabled") == 0)
                            DeleteInvDiscount(inv.Id, discountId);
                    }
                }
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        private void DeleteInvDiscount(uint id, uint discountId)
        {
            MySqlCommand cmd = db.CreateCommand(@"                   
                DELETE FROM discount_inventory 
                WHERE inventoryid = @inventoryid
                AND   discountid  = @discountid;
            ");

            cmd.Parameters.Add(new MySqlParameter("inventoryid", id));
            cmd.Parameters.Add(new MySqlParameter("discountid", discountId));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        private void InsertInvDiscount(uint id, uint discountId, bool enabled)
        {
            MySqlCommand cmd = db.CreateCommand(@"                   
                INSERT INTO discount_inventory 
                 ( inventoryid,  discountid,  enabled)
                VALUES
                 (@inventoryid, @discountid, @enabled);
            ");

            cmd.Parameters.Add(new MySqlParameter("inventoryid", id));
            cmd.Parameters.Add(new MySqlParameter("discountid", discountId));
            cmd.Parameters.Add(new MySqlParameter("enabled", enabled ? 1 : 0));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
        private void UpdateInvDiscount(uint id, uint discountId, bool enabled)
        {
            MySqlCommand cmd = db.CreateCommand(@"                   
                UPDATE discount_inventory 
                SET    enabled = :enabled
                WHERE  inventoryid = @inventoryid
                AND    discountid =  @discountid;
            ");

            cmd.Parameters.Add(new MySqlParameter("inventoryid", id));
            cmd.Parameters.Add(new MySqlParameter("discountid", discountId));
            cmd.Parameters.Add(new MySqlParameter("enabled", enabled ? 1 : 0));

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