using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class TransactionORM
    {
        readonly DbConn db = new DbConn();

        private const string SQLGET = @"
            SELECT receiptID, register, sold_datetime, customerID, empID, location, tax_exempt, discount, shipping
            FROM transaction
        ";

        public List<Transaction> GetTransactions(DateTime start, DateTime end, bool includeItems = true, bool includePayments = true)
        {
            db.OpenConnection();
            try
            {
                string sqlStatement = SQLGET;

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());

                if (start > DateTime.MinValue)
                {
                    cmd.Parameters.Add(new MySqlParameter("start", start));
                    cmd.CommandText += " AND sold_datetime >= @start";

                    if (end >= start)
                    {
                        cmd.CommandText += " AND sold_datetime <= @end";
                        cmd.Parameters.Add(new MySqlParameter("end", end));
                    }
                }
                return GetTransactions(cmd, includeItems, includePayments);
            }
            finally
            {
                db.CloseConnnection();
            }
        }
        public Transaction GetTransaction(uint invoiceID, bool includeItems = true, bool includePayments = true)
        {
            db.OpenConnection();
            try
            {
                string sqlStatement = @$"
                 {SQLGET}
                 WHERE receiptID = @invoiceID;
                ";

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("invoiceID", invoiceID));
                List<Transaction> transaction = GetTransactions(cmd, includeItems, includePayments);

                return (transaction.Count > 0) ? transaction[0] : null;
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public List<Transaction> GetTransactions(MySqlCommand cmd, bool includeItems, bool includePayments)
        {
            Transaction transaction;
            List<Transaction> output = new List<Transaction>();

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transaction = new Transaction
                    {
                        InvoiceID = reader.IsDBNull("receiptID") ? 0 : reader.GetUInt32("receiptID"),
                        RegisterID = reader.IsDBNull("register") ? 0 : reader.GetUInt32("register"),
                        TransactionDateTime = reader.IsDBNull("sold_datetime") ? new DateTime() : reader.GetDateTime("sold_datetime"),
                        CustomerID = reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID"),
                        EmployeeID = reader.IsDBNull("empID") ? 0 : reader.GetUInt32("empID"),
                        Location = reader.IsDBNull("location") ? "" : reader.GetString("location"),
                        TaxExempt = reader.IsDBNull("tax_exempt") ? false : reader.GetBoolean("tax_exempt"),
                        Discount = reader.IsDBNull("discount") ? 0.0 : reader.GetDouble("discount"),
                        Shipping = reader.IsDBNull("shipping") ? 0.0 : reader.GetDouble("shipping")
                    };
                    output.Add(transaction);
                }
            }
            finally
            {
            }

            if (includeItems) output.ForEach(x => GetItems(x));
            if (includePayments) output.ForEach(x => GetPayments(x));

            return output;
        }
        public void GetItems(Transaction transaction)
        {
            string itemSQLStatement = @"
                SELECT receiptID, name, InventoryID, barcode, sold_qty, sold_price, supplier_price, 
                        bottles, inventory_type_name, nontaxable, nontaxable_local, inventory_qty
                FROM v_transaction_items
                WHERE receiptID = @receiptID
                ORDER BY InventoryID
            ";

            using MySqlCommand cmd = new MySqlCommand(itemSQLStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));

            using MySqlDataReader itemReader = cmd.ExecuteReader();
            Item item = null;
            while (itemReader.Read())
            {
                if (item?.Id != itemReader.GetUInt32("inventoryid"))
                {
                    item = new Item()
                    {
                        Name = itemReader.IsDBNull("name") ? "" : itemReader.GetString("name"),
                        Id = itemReader.GetUInt32("inventoryid"),
                        Barcode = itemReader.IsDBNull("barcode") ? "" : itemReader.GetString("barcode"),
                        Price = itemReader.IsDBNull("sold_price") ? 0.0 : itemReader.GetDouble("sold_price"),
                        Bottles = itemReader.IsDBNull("bottles") ? 0 : itemReader.GetUInt32("bottles"),
                        ItemType = itemReader.IsDBNull("inventory_type_name") ? "" : itemReader.GetString("inventory_type_name"),
                        NonTaxable = itemReader.IsDBNull("nontaxable") ? false : itemReader.GetBoolean("nontaxable"),
                        NonTaxableLocal = itemReader.IsDBNull("nontaxable_local") ? false : itemReader.GetBoolean("nontaxable_local")
                    };
                    transaction.Items.Add(item);
                }

                item.NumSold += itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty");

                item.AllQty.Add(new InventoryQty
                {
                    PurchasedDate = DateTime.Now,
                    Qty = itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty"),
                    SupplierPrice = itemReader.IsDBNull("supplier_price") ? 0.0 : itemReader.GetDouble("supplier_price"),
                });
            }
        }
        public void GetPayments(Transaction transaction)
        {
            string itemSQLStatement = @"
                SELECT PayId, Method, Number, Amount
                FROM payments
                WHERE receiptID = @receiptID
            ";

            using MySqlCommand cmd = new MySqlCommand(itemSQLStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));

            using MySqlDataReader itemReader = cmd.ExecuteReader();
            while (itemReader.Read())
            {
                transaction.Payments.Add(new Payment
                {
                    Method = itemReader.IsDBNull("method") ? "" : itemReader.GetString("method"),
                    PayId = itemReader.IsDBNull("payid") ? 0 : itemReader.GetUInt32("payid"),
                    Number = itemReader.IsDBNull("Number") ? "" : itemReader.GetString("Number"),
                    Amount = itemReader.IsDBNull("Amount") ? 0 : itemReader.GetUInt32("Amount")
                });
            }
        }

        public uint InsertTransaction(Transaction transaction)
        {
            db.OpenConnection();
            try
            {
                string sql = @"
                  INSERT INTO transaction
                  (register,  sold_datetime,  customerID,  empID,  location,  tax_exempt,  discount, shipping)
                  VALUES
                  (@register, @sold_datetime, @customerID, @empID, @location, @tax_exempt, @discount, @shipping)
                ";

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("register", transaction.RegisterID));
                cmd.Parameters.Add(new MySqlParameter("sold_datetime", transaction.TransactionDateTime));
                cmd.Parameters.Add(new MySqlParameter("customerID", transaction.CustomerID));
                cmd.Parameters.Add(new MySqlParameter("empID", transaction.EmployeeID));
                cmd.Parameters.Add(new MySqlParameter("location", transaction.Location));
                cmd.Parameters.Add(new MySqlParameter("tax_exempt", transaction.TaxExempt));
                cmd.Parameters.Add(new MySqlParameter("discount", transaction.Discount)); ;
                cmd.Parameters.Add(new MySqlParameter("shipping", transaction.Shipping));

                cmd.ExecuteNonQuery();
                transaction.InvoiceID = Convert.ToUInt32(cmd.LastInsertedId);
            }
            finally
            {
                db.CloseConnnection();
            }
            InsertItems(transaction);
            InsertPayments(transaction);

            return transaction.InvoiceID;
        }
        public void InsertItems(Transaction transaction)
        {
            MySqlCommand cmd;
            string sql;
            db.OpenConnection();
            try
            {
                foreach (Item item in transaction.Items)
                {
                    sql = @"
                     INSERT INTO transaction_items
                     ( receiptID,  inventoryID,  sold_price,  supplier_price,  sold_qty)
                     VALUES
                     (@receiptID, @inventoryID, @sold_price, @supplier_price, @sold_qty)
                    ";

                    cmd = new MySqlCommand(sql, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));
                    cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));
                    cmd.Parameters.Add(new MySqlParameter("sold_price", item.Price));
                    cmd.Parameters.Add(new MySqlParameter("supplier_price", item.SupplierPrice));
                    cmd.Parameters.Add(new MySqlParameter("sold_qty", item.NumSold));

                    cmd.ExecuteNonQuery();
                    DecrementInventoryQty(item);
                    cmd.Dispose();
                }
            }
            finally
            {
                db.CloseConnnection();
            }
        }


        public void UpdateItemQty(uint receiptId, uint itemId, int qty)
        {
            db.OpenConnection();
            try
            {
                using MySqlCommand cmd = new MySqlCommand(@"
                    UPDATE transaction_items
                    SET sold_qty = GREATER(sold_qty, 0)
                    WHERE  receiptID = @receiptID
                    AND    inventoryID = @inventoryID
                ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("receiptID", receiptId));
                cmd.Parameters.Add(new MySqlParameter("inventoryID", itemId));
                cmd.Parameters.Add(new MySqlParameter("sold_qty", qty));

                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }


        public void DecrementInventoryQty(Item item)
        {
            string sql = @"
                UPDATE Inventory_price
                SET Inventory_qty = GREATEST(Inventory_qty - @qty, 0 ) 
                WHERE inventoryID = @inventoryID 
            ";

            using MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("qty", item.NumSold));
            cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));

            cmd.ExecuteNonQuery();
        }

        public void AddInventoryQty(Item item, int qty)
        {
            string sql = @"
                UPDATE Inventory_price 
                SET Inventory_qty = Inventory_qty + @qty 
                WHERE inventoryID = @inventoryID 
            ";

            db.OpenConnection();
            try
            {
                using MySqlCommand cmd = new MySqlCommand(sql, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("qty", Math.Min(item.NumSold, qty)));
                cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));

                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public void InsertPayments(Transaction transaction)
        {
            MySqlCommand cmd;
            string sql = @"
                INSERT INTO Payments
                ( ReceiptID,  Method,  Number,  Amount)
                VALUES
                (@ReceiptID, @Method, @Number, @Amount)
            ";

            db.OpenConnection();
            try
            {
                foreach (Payment pay in transaction.Payments)
                {
                    cmd = new MySqlCommand(sql, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));
                    cmd.Parameters.Add(new MySqlParameter("Method", pay.Method));
                    cmd.Parameters.Add(new MySqlParameter("Number", pay.Number));
                    cmd.Parameters.Add(new MySqlParameter("Amount", pay.Amount));

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                db.CloseConnnection();
            }
        }
    }
}
