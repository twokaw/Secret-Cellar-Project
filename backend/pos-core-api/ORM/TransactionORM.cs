﻿using MySql.Data.MySqlClient;
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
        private readonly DbConn db = new();
        private readonly CustomerORM CustORM;

        private const string SQLGET = @"
            SELECT receiptid, register, sold_datetime, customerid, empid, location, tax_exempt, discount, shipping, trantypeid, enableBulkDiscount
            FROM transaction
        ";
        private const string SQLGETPAYMENTS = @"
                SELECT  p.receiptid, p.payid, pm.paymentmethod method, p.number, p.amount, paymentmethodid
                FROM payments p
                JOIN paymentmethod pm
                USING (paymentmethodid)
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
                USING(receiptid);
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
                USING(receiptid)
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
                WHERE customerid = @customerid
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
                    TranType = (Transaction.TranactionType)(reader.IsDBNull("tranTypeid") ? 0 : reader.GetByte("tranTypeid")),
                    EnableBulkDiscount = reader.IsDBNull("enableBulkDiscount") ? false : reader.GetBoolean("enableBulkDiscount")
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
                WHERE receiptid = @receiptid
                ORDER BY inventoryid, sold_price
            ");

            cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));

            try
            {
                using MySqlDataReader itemReader = cmd.ExecuteReader();
                Item item = null;
                while (itemReader.Read())
                {
                    if (item?.Id != itemReader.GetUInt32("inventoryid") || item?.Price != itemReader.GetDouble("sold_price"))
                    {
                        item = new Item()
                        {
                            Name = itemReader.IsDBNull("name") ? "" : itemReader.GetString("name"),
                            Id = itemReader.GetUInt32("inventoryid"),
                            Barcode = itemReader.IsDBNull("barcode") ? "" : itemReader.GetString("barcode"),
                            Price = itemReader.IsDBNull("sold_price") ? 0.0 : itemReader.GetDouble("sold_price"),
                            DiscountPrice = itemReader.IsDBNull("discount_price") ? 0.0 : itemReader.GetDouble("discount_price"),
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

                        item.QtySold += itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty");
                        item.QtyRefunded += itemReader.IsDBNull("refunded_qty") ? 0 : itemReader.GetUInt32("refunded_qty");

                        item.AllQty.Add(new InventoryQty
                        {
                            PurchasedDate = DateTime.Now,
                            Qty = itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty"),
                            SupplierPrice = itemReader.IsDBNull("supplier_price") ? 0.0 : itemReader.GetDouble("supplier_price"),
                        });
                    }

                    if (!itemReader.IsDBNull("discountID") 
                        && item.Discounts.FirstOrDefault(x => x.DiscountID == itemReader.GetUInt32("discountID")) == null)
                        item.Discounts.Add(new Discount()
                        {
                            DiscountID = itemReader.GetUInt32("discountID"),
                            DiscountName = itemReader.GetString("discountName"),
                            Min = itemReader.IsDBNull("minqty") ? 0 : itemReader.GetUInt32("minqty"),
                            Max = itemReader.IsDBNull("maxqty") ? 99999999 : itemReader.GetUInt32("maxqty"),
                            Amount = itemReader.GetDouble("Discount"),
                            Enabled = itemReader.IsDBNull("minqty") && itemReader.IsDBNull("maxqty")
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
            MySqlCommand cmd = db.CreateCommand(@$"{SQLGETPAYMENTS}
                WHERE p.receiptid = @receiptid
            ");
            cmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));

            transaction.Payments = FetchPayment(cmd);
        }

        public Payment GetPayment(uint payId)
        {
            MySqlCommand cmd = db.CreateCommand(@$"
                {SQLGETPAYMENTS}
                WHERE payid = @payid
            ");
            cmd.Parameters.Add(new MySqlParameter("payId", payId));

            List<Payment> payments = FetchPayment(cmd);
            return (payments.Count > 0) ? payments[0]: null;
        }


        public List<Payment> FetchPayment(MySqlCommand cmd)
        {
            List<Payment> payments = new();
            try
            {
                using MySqlDataReader itemReader = cmd.ExecuteReader();
                while (itemReader.Read())
                {
                    payments.Add(new Payment
                    {
                        ReciptId = itemReader.IsDBNull("receiptID") ? 0 : itemReader.GetUInt32("receiptID"),
                        Method = itemReader.IsDBNull("method") ? "" : itemReader.GetString("method"),
                        PayId = itemReader.IsDBNull("payid") ? 0 : itemReader.GetUInt32("payid"),
                        Number = itemReader.IsDBNull("Number") ? "" : itemReader.GetString("Number"),
                        Amount = itemReader.IsDBNull("Amount") ? 0 : itemReader.GetDouble("Amount"),
                        PaymentMethodId = itemReader.IsDBNull("PaymentMethodId") ? 0 : itemReader.GetUInt32("PaymentMethodId")
                    });
                }
            }
            finally
            {
                db.CloseCommand(cmd);
            }
            return payments;
        }

        public uint InsertTransaction(Transaction transaction, bool decrementItems = true)
        {

            if (transaction.TranType == Transaction.TranactionType.Closed && transaction.Total > transaction.Payments.Sum(x => x.Amount))
                transaction.TranType = Transaction.TranactionType.Suspended;

            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO transaction
                (register,  sold_datetime,  customerid,  empid,  location,  tax_exempt,  discount, shipping, trantypeid, enableBulkDiscount)
                VALUES
                (@register, @sold_datetime, @customerid, @empid, @location, @tax_exempt, @discount, @shipping, @trantype, @enableBulkDiscount)
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
            cmd.Parameters.Add(new MySqlParameter("enableBulkDiscount", transaction.EnableBulkDiscount));

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
            if (FullyPaid(transaction)) {
                if (transaction.TranType == Transaction.TranactionType.Suspended)
                    transaction.TranType = Transaction.TranactionType.Closed;
                else if (transaction.TranType == Transaction.TranactionType.Invoice)
                    transaction.TranType = Transaction.TranactionType.ClosedInvoice;
            }

            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE transaction
                SET register = @register,  
                    sold_datetime = @sold_datetime,  
                    customerid = @customerid,   
                    empid = @empid,  
                    location = @location,  
                    tax_exempt = @tax_exempt,  
                    discount = @discount, 
                    shipping = @shipping, 
                    trantypeid= @transtype,
                    enableBulkDiscount = @enableBulkDiscount
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
            cmd.Parameters.Add(new MySqlParameter("enableBulkDiscount", transaction.EnableBulkDiscount));

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
                    WHERE receiptid = @receiptid
                    AND   inventoryid =  @inventoryid
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
                       refunded_qty = GREATEST(@refunded_qty, 0)
                WHERE  receiptid = @receiptid
                AND    inventoryid = @inventoryid
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
                ( receiptID,  inventoryID,  sold_price, discount_price,  supplier_price,  sold_qty, Refunded_Qty)
                VALUES
                (@receiptID, @inventoryID, @sold_price, @discount_price, @supplier_price, @sold_qty, @Refunded_Qty)
            ");
            cmd.Parameters.Add(new MySqlParameter("receiptID", receiptId));
            cmd.Parameters.Add(new MySqlParameter("inventoryID", item.Id));
            cmd.Parameters.Add(new MySqlParameter("sold_price", item.Price));
            cmd.Parameters.Add(new MySqlParameter("discount_price", item.DiscountPrice));
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
                    UPDATE inventory_price
                    SET inventory_qty = GREATEST(inventory_qty - @qty, 0 ) 
                    WHERE inventoryid = @inventoryid 
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
                UPDATE inventory_price 
                SET inventory_qty = inventory_qty + @qty 
                WHERE inventoryid = @inventoryid 
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
                INSERT INTO payments
                ( receiptid,  method,  number,  amount, paymentmethodid)
                VALUES
                (@receiptid, @method, @number, @amount, (SELECT paymentmethodid FROM paymentmethod WHERE paymentmethod = @method ))
            ";

            string update = @"
                UPDATE payments
                SET  receiptid = @receiptid,
                     method = @method,
                     number = @number,
                     amount = @amount,
                     paymentmethodid = (SELECT paymentmethodid FROM paymentmethod WHERE paymentmethod = @method ) 
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
                    DELETE FROM transaction_items 
                    WHERE receiptid = @receiptid;

                    DELETE FROM transaction 
                    WHERE receiptid = @receiptid;
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
                    DELETE FROM payments
                    WHERE payid = @payid
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

            if (payments > 0)
            {
                if (transaction.PayMethod != "CREDIT")
                    return Math.Round(transaction.Total
                                    * (double)(1 - (GetPaymentMethods().FirstOrDefault(x => x.PayMethod == "CASH").PercentOffset / 100)),
                                      2,
                                      MidpointRounding.AwayFromZero) <= payments;
                else
                    return transaction.Total <= payments;
            }

            return false;
        }
        public List<PaymentMethod> GetPaymentMethods()
        {
            string itemSQLStatement = @"
                SELECT paymentmethodid, paymentmethod, percentoffset, allowchange
                FROM paymentmethod
            ";
            
            MySqlCommand cmd = db.CreateCommand(itemSQLStatement);

            return FetchPaymentMethod(cmd);
        }
        public PaymentMethod GetPaymentMethod(uint id)
        {
            using MySqlCommand cmd = db.CreateCommand(@"
                SELECT paymentmethodid, paymentmethod, percentoffset, allowchange
                FROM paymentmethod
                WHERE paymentmethodid = @id
            ");
            cmd.Parameters.Add(new MySqlParameter("id", id));

            List<PaymentMethod> result = FetchPaymentMethod(cmd);

            return result.Count > 0 ? result[0] : null;
        }

        private List<PaymentMethod> FetchPaymentMethod(MySqlCommand cmd)
        {
            List<PaymentMethod> result = new();
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add(new PaymentMethod
                    {
                        PaymentMethodId = reader.IsDBNull("paymentmethodid") ? 0 : reader.GetUInt32("paymentmethodid"),
                        PayMethod = reader.IsDBNull("paymentmethod") ? "" : reader.GetString("paymentmethod"),
                        PercentOffset = reader.IsDBNull("percentoffset") ? 0 : reader.GetDecimal("percentoffset"),
                        AllowChange = !reader.IsDBNull("allowchange") && reader.GetBoolean("allowchange")
                    });
            }
            finally { db.CloseCommand(cmd); }

            return result;
        }


        public PaymentMethod PutPaymentMethod(PaymentMethod paymentMethod)
        {
            if (null == paymentMethod || null == GetPaymentMethod(paymentMethod.PaymentMethodId))
                return null;

            string itemSQLStatement = @"
                UPDATE paymentmethod
                SET    paymentmethod = @method, 
                       percentoffset = @offset, 
                       allowchange   = @allowchange
                WHERE  paymentmethodid = @id
            ";

            using MySqlCommand cmd = db.CreateCommand(itemSQLStatement);
            cmd.Parameters.AddWithValue("method", paymentMethod.PayMethod);
            cmd.Parameters.AddWithValue("offset", paymentMethod.PercentOffset);
            cmd.Parameters.AddWithValue("allowchange", paymentMethod.AllowChange);
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

