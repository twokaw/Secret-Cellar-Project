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
        private readonly DbConn db = new DbConn();
        private readonly CustomerORM CustORM;

        private const string SQLGET = @"
            SELECT receiptID, register, sold_datetime, customerID, empID, location, tax_exempt, discount, shipping, tranTypeid
            FROM transaction
        ";

        public TransactionORM(CustomerORM customerORM)
        {
            CustORM = customerORM;
        }


        public List<Transaction> GetTransactions(DateTime start, DateTime end, bool includeItems = true, bool includePayments = true)
        {
            MySqlCommand cmd = db.CreateCommand(SQLGET);

            if (start > DateTime.MinValue)
            {
                cmd.Parameters.Add(new MySqlParameter("start", start));
                cmd.CommandText += " WHERE sold_datetime >= @start";

                if (end >= start)
                {
                    cmd.CommandText += " AND sold_datetime <= @end";
                    cmd.Parameters.Add(new MySqlParameter("end", end));
                }
            }
            try
            {
                return GetTransactions(cmd, includeItems, includePayments);
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public List<Transaction> GetTransactions(List<Transaction.TranactionType> TranTypes, DateTime start, DateTime end, bool includeItems = true, bool includePayments = true)
        {
            MySqlCommand cmd = db.CreateCommand(SQLGET);

            if (start > DateTime.MinValue)
            {
                cmd.Parameters.Add(new MySqlParameter("start", start));
                cmd.CommandText += " WHERE sold_datetime >= @start";

                if (end >= start)
                {
                    cmd.CommandText += " AND sold_datetime <= @end";
                    cmd.Parameters.Add(new MySqlParameter("end", end));
                }
            }
            try
            {
                return GetTransactions(cmd, includeItems, includePayments);
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public Transaction GetTransaction(uint invoiceID, bool includeItems = true, bool includePayments = true)
        {
            MySqlCommand cmd = db.CreateCommand(@$"
                {SQLGET}
                WHERE receiptID = @invoiceID;
            ");
            cmd.Parameters.Add(new MySqlParameter("invoiceID", invoiceID));

            try
            {
                List<Transaction> transaction = GetTransactions(cmd, includeItems, includePayments);

                return (transaction.Count > 0) ? transaction[0] : null;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public List<Transaction> GetSuspendedTransactions(bool includeItems = true, bool includePayments = true)
        {
            MySqlCommand cmd = db.CreateCommand(@$"{SQLGET}
                JOIN v_suspendedtransaction
                USING(ReceiptID);
            ");

            try
            {
                return GetTransactions(cmd, includeItems, includePayments);
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public List<Transaction> GetSuspendedTransactions(uint customerid, bool includeItems = true, bool includePayments = true)
        {
            MySqlCommand cmd = db.CreateCommand(@$"{SQLGET}
                JOIN v_suspendedtransaction
                USING(ReceiptID)
                WHERE customerid = @cid;
            ");

            cmd.Parameters.Add(new MySqlParameter("cid", customerid));
            try
            {
                return GetTransactions(cmd, includeItems, includePayments);
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public List<Transaction> GetCustomerTransactions(uint customerID, bool includeItems = true, bool includePayments = true)
        {
            return GetCustomerTransactions(customerID, DateTime.MinValue, DateTime.MinValue, includeItems, includePayments);
        }
        public List<Transaction> GetCustomerTransactions(uint customerID, DateTime start, DateTime end, bool includeItems = true, bool includePayments = true)
        {
            MySqlCommand cmd = db.CreateCommand(@$"
                {SQLGET}
                WHERE customerID = @customerID
            ");

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

            cmd.Parameters.Add(new MySqlParameter("customerID", customerID));

            try
            {
                List<Transaction> transaction = GetTransactions(cmd, includeItems, includePayments);

                return transaction;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public List<Transaction> GetTransactions(MySqlCommand cmd, bool includeItems, bool includePayments)
        {
            Transaction transaction;
            List<Transaction> output = new();

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
                    TaxExempt = !reader.IsDBNull("tax_exempt") && reader.GetBoolean("tax_exempt"),
                    Discount = reader.IsDBNull("discount") ? 0.0 : reader.GetDouble("discount"),
                    Shipping = reader.IsDBNull("shipping") ? 0.0 : reader.GetDouble("shipping"),
                    TranType = (Transaction.TranactionType)(reader.IsDBNull("tranTypeid") ? 0 : reader.GetByte("tranTypeid"))
                };
                output.Add(transaction);
            }

            if (includeItems) output.ForEach(x => GetItems(x));
            if (includePayments) output.ForEach(x => GetPayments(x));

            return output;
        }

        public void GetItems(Transaction transaction)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT *
                FROM v_transaction_items
                WHERE receiptID = @receiptID
                ORDER BY InventoryID, sold_price
            ");

            cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));

            try
            {
                using MySqlDataReader itemReader = cmd.ExecuteReader();
                Item item = null;
                while (itemReader.Read())
                {
                    if (item?.Id != itemReader.GetUInt32("inventoryid") || item?.Price != itemReader.GetUInt32("sold_price"))
                    {
                        item = new Item()
                        {
                            Name = itemReader.IsDBNull("name") ? "" : itemReader.GetString("name"),
                            Id = itemReader.GetUInt32("inventoryid"),
                            Barcode = itemReader.IsDBNull("barcode") ? "" : itemReader.GetString("barcode"),
                            Price = itemReader.IsDBNull("sold_price") ? 0.0 : itemReader.GetDouble("sold_price"),
                            Bottles = itemReader.IsDBNull("bottles") ? 0 : itemReader.GetUInt32("bottles"),
                            ItemType = itemReader.IsDBNull("inventory_type_name") ? "" : itemReader.GetString("inventory_type_name"),
                            NonTaxable = !itemReader.IsDBNull("nontaxable") && itemReader.GetBoolean("nontaxable"),
                            NonTaxableLocal = !itemReader.IsDBNull("nontaxable_local") && itemReader.GetBoolean("nontaxable_local"),
                            BottleDeposit = itemReader.IsDBNull("bottle_deposit") ? 0 : itemReader.GetDouble("bottle_deposit"),
                            SalesTax = itemReader.IsDBNull("sales_tax") ? 0 : itemReader.GetDouble("sales_tax"),
                            LocalSalesTax = itemReader.IsDBNull("local_sales_tax") ? 0 : itemReader.GetDouble("local_sales_tax")
                        };
                        item.QtySold = 0;
                        transaction.Items.Add(item);
                    }

                    item.QtySold += itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty");
                    item.QtyRefunded += itemReader.IsDBNull("refunded_qty") ? 0 : itemReader.GetUInt32("refunded_qty");

                    item.AllQty.Add(new InventoryQty
                    {
                        PurchasedDate = DateTime.Now,
                        Qty = itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty"),
                        SupplierPrice = itemReader.IsDBNull("supplier_price") ? 0.0 : itemReader.GetDouble("supplier_price"),
                    });
                }
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void GetPayments(Transaction transaction)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT PayId, Method, Number, Amount
                FROM payments
                WHERE receiptID = @receiptID
            ");
            cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));

            try
            {
                using MySqlDataReader itemReader = cmd.ExecuteReader();
                while (itemReader.Read())
                {
                    transaction.Payments.Add(new Payment
                    {
                        ReciptId = transaction.InvoiceID,
                        Method = itemReader.IsDBNull("method") ? "" : itemReader.GetString("method"),
                        PayId = itemReader.IsDBNull("payid") ? 0 : itemReader.GetUInt32("payid"),
                        Number = itemReader.IsDBNull("Number") ? "" : itemReader.GetString("Number"),
                        Amount = itemReader.IsDBNull("Amount") ? 0 : itemReader.GetDouble("Amount")
                    });
                }
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public Payment GetPayment(uint payId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT receiptID, PayId, Method, Number, Amount
                FROM payments
                WHERE payID = @payId
            ");
            cmd.Parameters.Add(new MySqlParameter("payId", payId));

            try
            {
                using MySqlDataReader itemReader = cmd.ExecuteReader();
                if (itemReader.Read())
                {
                    return new Payment
                    {
                        ReciptId = itemReader.IsDBNull("receiptID") ? 0 : itemReader.GetUInt32("receiptID"),
                        Method = itemReader.IsDBNull("method") ? "" : itemReader.GetString("method"),
                        PayId = itemReader.IsDBNull("payid") ? 0 : itemReader.GetUInt32("payid"),
                        Number = itemReader.IsDBNull("Number") ? "" : itemReader.GetString("Number"),
                        Amount = itemReader.IsDBNull("Amount") ? 0 : itemReader.GetUInt32("Amount")
                    };
                }
                else
                    return null;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public uint InsertTransaction(Transaction transaction, bool decrementItems = true)
        {

            if (transaction.TranType == Transaction.TranactionType.Closed && transaction.Total > transaction.Payments.Sum(x => x.Amount))
                transaction.TranType = Transaction.TranactionType.Suspended;

            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO transaction
                (register,  sold_datetime,  customerID,  empID,  location,  tax_exempt,  discount, shipping, tranTypeid)
                VALUES
                (@register, @sold_datetime, @customerID, @empID, @location, @tax_exempt, @discount, @shipping, @TranType)
            ");

            cmd.Parameters.Add(new MySqlParameter("register", transaction.RegisterID));
            cmd.Parameters.Add(new MySqlParameter("sold_datetime", transaction.TransactionDateTime));
            cmd.Parameters.Add(new MySqlParameter("customerID", transaction.CustomerID));
            cmd.Parameters.Add(new MySqlParameter("empID", transaction.EmployeeID));
            cmd.Parameters.Add(new MySqlParameter("location", transaction.Location));
            cmd.Parameters.Add(new MySqlParameter("tax_exempt", transaction.TaxExempt));
            cmd.Parameters.Add(new MySqlParameter("discount", transaction.Discount));
            cmd.Parameters.Add(new MySqlParameter("shipping", transaction.Shipping));
            cmd.Parameters.Add(new MySqlParameter("tranType", transaction.TranType));

            try
            {
                cmd.ExecuteNonQuery();
                transaction.InvoiceID = Convert.ToUInt32(cmd.LastInsertedId);
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            InsertItems(transaction, FullyPaid(transaction) && decrementItems);
            InsertPayments(transaction);

            return transaction.InvoiceID;
        }

        public uint UpdateTransaction(Transaction transaction)
        {
            return UpdateTransaction(transaction, GetTransaction(transaction.InvoiceID));
        }

        public uint UpdateTransaction(Transaction transaction, Transaction previousTransaction)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE transaction
                SET register = @register,  
                    sold_datetime = @sold_datetime,  
                    customerID = @customerID,   
                    empID = @empID,  
                    location = @location,  
                    tax_exempt = @tax_exempt,  
                    discount = @discount, 
                    shipping = @shipping, 
                    tranTypeid= @transType
                WHERE Receiptid = @InvoiceID
            ");
            cmd.Parameters.Add(new MySqlParameter("register", transaction.RegisterID));
            cmd.Parameters.Add(new MySqlParameter("sold_datetime", transaction.TransactionDateTime));
            cmd.Parameters.Add(new MySqlParameter("customerID", transaction.CustomerID));
            cmd.Parameters.Add(new MySqlParameter("empID", transaction.EmployeeID));
            cmd.Parameters.Add(new MySqlParameter("location", transaction.Location));
            cmd.Parameters.Add(new MySqlParameter("tax_exempt", transaction.TaxExempt));
            cmd.Parameters.Add(new MySqlParameter("discount", transaction.Discount));
            cmd.Parameters.Add(new MySqlParameter("shipping", transaction.Shipping));
            cmd.Parameters.Add(new MySqlParameter("transType", transaction.TranType));
            cmd.Parameters.Add(new MySqlParameter("InvoiceID", transaction.InvoiceID));      
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
            InsertItems(transaction, FullyPaid(transaction), previousTransaction);
            InsertPayments(transaction, previousTransaction);

            return transaction.InvoiceID;
        }

        public void InsertItems(Transaction transaction, bool updateDecrementInvQty)
        {
            foreach (Item item in transaction.Items)
                UpdateItemQty(transaction.InvoiceID, item, 
                              transaction.TranType == Transaction.TranactionType.Invoice 
                           || transaction.TranType == Transaction.TranactionType.Hold
                           || updateDecrementInvQty);
        }

        public void InsertItems(Transaction transaction, bool updateDecrementInvQty, Transaction previousTransaction )
        {
            InsertItems(transaction, updateDecrementInvQty);

            MySqlCommand cmd;
            
            foreach (Item item in previousTransaction.Items.Where(x=>transaction.Items.FirstOrDefault(y => y.Id == x.Id) == null))
            {
                cmd = db.CreateCommand (@"
                    DELETE FROM transaction_items
                    WHERE receiptID = @receiptID
                    AND   inventoryID =  @inventoryID
                ");
                cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));
                cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));

                try
                {
                    cmd.ExecuteNonQuery();

                    // if (updateDecrementInvQty)
                    //    DecrementInventoryQty(item);
                }
                finally
                {
                    db.CloseCommand(cmd);
                }
            }
        }

        public void UpdateItemQty(uint receiptId, uint itemId, uint qty, uint qtyRefunded)
        {
            using MySqlCommand cmd = db.CreateCommand(@"
                UPDATE transaction_items
                SET    sold_qty     = GREATEST(@sold_qty, 0),
                       Refunded_Qty = GREATEST(@Refunded_Qty, 0)
                WHERE  receiptID = @receiptID
                AND    inventoryID = @inventoryID
            ");

            cmd.Parameters.Add(new MySqlParameter("receiptID", receiptId));
            cmd.Parameters.Add(new MySqlParameter("inventoryID", itemId));
            cmd.Parameters.Add(new MySqlParameter("sold_qty", qty));
            cmd.Parameters.Add(new MySqlParameter("Refunded_qty", qtyRefunded));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
        public void UpdateItemQty(uint receiptId, Item item, bool updateDecrementInvQty)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                REPLACE INTO transaction_items
                ( receiptID,  inventoryID,  sold_price,  supplier_price,  sold_qty, Refunded_Qty)
                VALUES
                (@receiptID, @inventoryID, @sold_price, @supplier_price, @sold_qty, @Refunded_Qty)
            ");
            cmd.Parameters.Add(new MySqlParameter("receiptID", receiptId));
            cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));
            cmd.Parameters.Add(new MySqlParameter("sold_price", item.Price));
            cmd.Parameters.Add(new MySqlParameter("supplier_price", item.SupplierPrice));
            cmd.Parameters.Add(new MySqlParameter("sold_qty", item.QtySold));
            cmd.Parameters.Add(new MySqlParameter("refunded_Qty", item.QtyRefunded));

            try
            {
                cmd.ExecuteNonQuery();

                if (updateDecrementInvQty)
                    DecrementInventoryQty(item);
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void DecrementInventoryQty(Item item)
        {
            if (item.DecrementInventory)
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    UPDATE Inventory_price
                    SET Inventory_qty = GREATEST(Inventory_qty - @qty, 0 ) 
                    WHERE inventoryID = @inventoryID 
                ");
                cmd.Parameters.Add(new MySqlParameter("qty", item.NumSold));
                cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));
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

        public void AddInventoryQty(Item item, int qty)
        {
            using MySqlCommand cmd = db.CreateCommand(@"
                UPDATE Inventory_price 
                SET Inventory_qty = Inventory_qty + @qty 
                WHERE inventoryID = @inventoryID 
            ");
            cmd.Parameters.Add(new MySqlParameter("qty", Math.Min(item.NumSold, qty)));
            cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        private void InsertPayments(Transaction transaction)
        {
            MySqlCommand cmd;
            string insert = @"
                INSERT INTO Payments
                ( ReceiptID,  Method,  Number,  Amount)
                VALUES
                (@ReceiptID, @Method, @Number, @Amount)
            ";

            string update = @"
                UPDATE Payments
                SET  ReceiptID = @ReceiptID,
                     Method = @Method,
                     Number = @Number,
                     Amount = @Amount
                WHERE PayID = @PayID
            ";
            
            foreach (Payment pay in transaction.Payments)
            {
                if(pay.PayId > 0)
                {
                    cmd = db.CreateCommand(update);
                    cmd.Parameters.Add(new MySqlParameter("PayID", pay.PayId));
                }
                else
                {
                    cmd = db.CreateCommand(insert);

                    if (pay.Method == "CUSTOMER CREDIT")
                        CustORM.AddCredit(transaction.CustomerID, pay.Amount * -1);
                }
                cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));
                cmd.Parameters.Add(new MySqlParameter("Method", pay.Method));
                cmd.Parameters.Add(new MySqlParameter("Number", pay.Number));
                cmd.Parameters.Add(new MySqlParameter("Amount", pay.Amount));

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

        private void InsertPayments(Transaction transaction, Transaction previousTransaction)
        { 
            InsertPayments(transaction);

            foreach (Payment pay in previousTransaction.Payments.Where(x => transaction.Payments.FirstOrDefault(y => y.PayId == x.PayId) == null))
                DeletePayment(pay.PayId);
        }

        public bool DeleteTransaction(uint transactionId)
        {
            Transaction t = GetTransaction(transactionId);

            return t == null || DeleteTransaction(t);
        }

        public bool DeleteTransaction(Transaction transaction)
        {
            if (transaction.Payments.Count == 0)
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    DELETE FROM Transaction_items 
                    WHERE ReceiptID = @ReceiptID;

                    DELETE FROM Transaction 
                    WHERE ReceiptID = @ReceiptID;
                ");

                try
                {
                    cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseCommand(cmd);
                }
                return true;
            }
            else
                return false;
        }

        public bool DeletePayment(uint payId)
        {
            return DeletePayment(GetPayment(payId));
        }

        public bool DeletePayment(Payment pay)
        {
            if (pay.PayId > 0)
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    DELETE FROM Payments
                    WHERE payID = @payId
                ");

                try
                {
                    if (pay.Method == "CUSTOMER CREDIT")
                    {
                        uint customerId = GetTransactionCustomerId(pay.ReciptId);
                        if(customerId > 0)
                            CustORM.AddCredit(customerId, pay.Amount);
                    }

                    cmd.Parameters.Add(new MySqlParameter("payId", pay.PayId));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseCommand(cmd);
                }
                return true;
            }
            else
                return false;
        }

        public  uint GetTransactionCustomerId(uint invoiceId)
        {
            return GetTransaction(invoiceId, false, false)?.CustomerID ?? 0;
        }

        public bool FullyPaid(Transaction transaction)
        {
            double payments = 0;
            transaction.Payments.ForEach(x => payments += x.Amount);

            return transaction.Total <= payments;
        }
        public List<PaymentMethod> GetPaymentMethods()
        {
            List<PaymentMethod> result = new();
            string itemSQLStatement = @"
                SELECT PaymentMethodid, PaymentMethod, PercentOffset
                FROM paymentMethod
            ";
            
            using MySqlCommand cmd = db.CreateCommand(itemSQLStatement);
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add(new PaymentMethod
                    {
                        PaymentMethodId = reader.IsDBNull("PaymentMethodid") ? 0 : reader.GetUInt32("PaymentMethodid"),
                        PayMethod = reader.IsDBNull("PaymentMethod") ? "" : reader.GetString("PaymentMethod"),
                        PercentOffset = reader.IsDBNull("PercentOffset") ? 0 : reader.GetDecimal("PercentOffset")
                    });
            }
            finally { db.CloseCommand(cmd); }

            return result;
        }
        public PaymentMethod GetPaymentMethod(uint id)
        {
            PaymentMethod result = null;
            string itemSQLStatement = @"
                SELECT PaymentMethodid, PaymentMethod, PercentOffset
                FROM paymentMethod
                WHERE PaymentMethodid = @id
            ";

            using MySqlCommand cmd = db.CreateCommand(itemSQLStatement);
            cmd.Parameters.AddWithValue("id", id);

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    result = new PaymentMethod
                    {
                        PaymentMethodId = reader.IsDBNull("PaymentMethodid") ? 0 : reader.GetUInt32("PaymentMethodid"),
                        PayMethod = reader.IsDBNull("PaymentMethod") ? "" : reader.GetString("PaymentMethod"),
                        PercentOffset = reader.IsDBNull("PercentOffset") ? 0 : reader.GetDecimal("PercentOffset")
                    };
            }
            finally { db.CloseCommand(cmd); }

            return result;
        }

        public PaymentMethod PutPaymentMethod(PaymentMethod paymentMethod)
        {
            if (null == paymentMethod || null == GetPaymentMethod(paymentMethod.PaymentMethodId))
                return null;

            string itemSQLStatement = @"
                UPDATE paymentMethod
                SET    PaymentMethod = @method, 
                       PercentOffset = @offset
                WHERE  PaymentMethodid = @id
            ";

            using MySqlCommand cmd = db.CreateCommand(itemSQLStatement);
            cmd.Parameters.AddWithValue("method", paymentMethod.PayMethod);
            cmd.Parameters.AddWithValue("offset", paymentMethod.PercentOffset);
            cmd.Parameters.AddWithValue("id", paymentMethod.PaymentMethodId);

            try
            {
                int rows = cmd.ExecuteNonQuery();
            }
            finally { db.CloseCommand(cmd); }

            return GetPaymentMethod(paymentMethod.PaymentMethodId);
        }
    }
}
