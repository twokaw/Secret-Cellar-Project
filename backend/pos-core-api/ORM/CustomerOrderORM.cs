using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;
using System.Linq;

namespace pos_core_api.ORM
{
    public class CustomerOrderORM
    {
        private readonly DbConn db = new();
        private readonly TransactionORM transactionORM;
        private const string CUSTOMERORDERSQL = @"
        SELECT *
        FROM  v_CustomerOrder
        ";

        private const string OUTSTANDINGCUSTOMERORDERSQL = @"
        SELECT *
        FROM  v_CustomerOrder
        WHERE IFNULL(DeliverQty, 0) < RequestQty
        ";

        public CustomerOrderORM(TransactionORM transactionORM)
        {
            this.transactionORM = transactionORM;
        }

        public List<CustomerOrder> Get(bool includehistory)
        {


            MySqlCommand cmd = db.CreateCommand(@$"{(includehistory ? $"{CUSTOMERORDERSQL} " : $"{OUTSTANDINGCUSTOMERORDERSQL}")}
              ORDER BY customerID
            ");

            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                return FetchOrderCustomers(reader);
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public CustomerOrder Get(uint customerID, bool includehistory)
        {
            MySqlCommand cmd = db.CreateCommand(@$"{(includehistory ? $"{CUSTOMERORDERSQL} WHERE " : $"{OUTSTANDINGCUSTOMERORDERSQL} AND ")}
              customerID = @custID
            ");
            cmd.Parameters.Add(new MySqlParameter("custID", customerID));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                List<CustomerOrder> output = FetchOrderCustomers(reader);

                if (output.Count > 0)
                    return output[0];
                else
                    return CreateOrder(customerID);
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }
        public CustomerOrder CreateOrder(uint customerID)
        {


            MySqlCommand cmd = db.CreateCommand(@"
              INSERT INTO customerorder
              (CustomerID, RequestDate)
              VALUES
              (@custid, SYSDATE())
            ");
            cmd.Parameters.Add(new MySqlParameter("custID", customerID));

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                    return new CustomerOrder()
                    {
                        CustomerID = customerID 
                    };
                else throw new Exception("Failed to create orderid");
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public CustomerOrderItem GetCustomerItem(uint customerOrderItemID)
        {


            string sqlStatement = $"{CUSTOMERORDERSQL} WHERE CustomerOrderItemID = @customerOrderItemID";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
            cmd.Parameters.Add(new MySqlParameter("customerOrderItemID", customerOrderItemID));
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {

                List<CustomerOrder> output = FetchOrderCustomers(reader);

                if (output.Count > 0 && output[0].Items.Count > 0)
                    return output[0].Items[0];
                else
                    return null;
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public CustomerOrder GetOrder(uint orderId, bool includehistory)
        {
            string sqlStatement = @$"{(includehistory ? $"{CUSTOMERORDERSQL} WHERE " : $"{OUTSTANDINGCUSTOMERORDERSQL} AND ")}
              CustomerOrderid = @orderId
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
            cmd.Parameters.Add(new MySqlParameter("orderId", orderId));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                List<CustomerOrder> output = FetchOrderCustomers(reader);

                if (output.Count > 0)
                    return output[0];
                else
                    return new CustomerOrder();
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public long Insert(uint customerId, CustomerOrderItem cust)
        {
            CustomerOrder co = Get(customerId, false);

            if (co?.Items.FirstOrDefault(x => x.CustomerOrderItemID == cust.CustomerOrderItemID) != null)
                return Update(cust);
            else
            {
                CustomerOrderItem coi = co?.Items.FirstOrDefault(x => x.Id == cust.Id && x.Price == cust.Price);
                if (coi != null)
                {
                    coi.RequestQty += cust.RequestQty;
                    coi.DeliverQty += cust.DeliverQty;
                    return Update(coi);
                }
            }

            if (cust.Price <= 0)
            {
                Inventory inv = DataAccess.Instance.Inventory.GetInv(cust.Id);
                cust.Price = inv.Price;
            }

            DeliverQty(customerId, cust, null);

           MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO customerorderItem
                (CustomerID, InventoryID, Paid, Price, PaidDate, DeliverDate, DeliverQty, RequestQty)
                VALUES
                (@CustomerID, @InventoryID, @Paid, @Price, @PaidDate, @DeliverDate, @DeliverQty, @RequestQty)
            ");
            cmd.Parameters.Add(new MySqlParameter("CustomerID", customerId));
            cmd.Parameters.Add(new MySqlParameter("InventoryID", cust.Id));
            cmd.Parameters.Add(new MySqlParameter("Paid", cust.Paid));
            cmd.Parameters.Add(new MySqlParameter("Price", cust.Price));
            cmd.Parameters.Add(new MySqlParameter("PaidDate", cust.PaidDate));
            cmd.Parameters.Add(new MySqlParameter("DeliverDate", cust.DeliverDate));
            cmd.Parameters.Add(new MySqlParameter("DeliverQty", cust.DeliverQty));
            cmd.Parameters.Add(new MySqlParameter("RequestQty", cust.RequestQty));

            try
            {
                cmd.ExecuteNonQuery();

                return cmd.LastInsertedId;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        private void DeliverQty(uint customerId, CustomerOrderItem cust, Transaction transaction = null)
        {
            if (cust.DeliverQty > 0)
            {
                if(transaction == null)
                    transaction = transactionORM.GetSuspendedTransactions(customerId).FirstOrDefault(x => x.TranType == Transaction.TranactionType.Invoice);

                if (transaction == null)
                {
                    transaction = new Transaction()
                    {
                        CustomerID = customerId,
                        TranType = Transaction.TranactionType.Invoice 
                    };

                    transaction.Items.Add(new Item(cust) { QtySold = cust.DeliverQty });
                    transactionORM.InsertTransaction(transaction);
                }
                else
                {
                    Item i = transaction.Items.FirstOrDefault(x => x.Id == cust.Id) ?? new Item(cust) { QtySold = 0 };
                    i.QtySold += cust.DeliverQty;
                    transactionORM.UpdateItemQty(transaction.InvoiceID, i, true);
                }

                cust.RequestQty -= cust.DeliverQty;
            }
        }

        public long Update(CustomerOrderItem cust, uint customerid = 0, Transaction transaction = null)
        {
            if (cust.CustomerOrderItemID == 0)
                throw new Exception("Missing CustomerOrder Id");

            CustomerOrderItem temp = GetCustomerItem(cust.CustomerOrderItemID);

            if (temp == null)
                throw new Exception("CustomerOrderItem is missing");
              
            if(cust.Price <= 0)
            {
                Inventory inv = DataAccess.Instance.Inventory.GetInv(cust.Id);
                if (inv.Price > 0)
                    cust.Price = inv.Price;
            }

            if(cust.DeliverQty > 0)
            {
                if (customerid == 0)
                    customerid = GetCustomerID(cust.CustomerOrderItemID);

                DeliverQty(customerid, cust);
            }

            if (temp.Id != cust.Id
             || temp.RequestQty != cust.RequestQty
             || temp.DeliverQty != cust.DeliverQty
             || temp.Price != cust.Price
             || temp.Paid != cust.Paid)
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    UPDATE customerorderitem
                    SET InventoryID     = @InventoryID, 
                        RequestQTY      = @RequestQTY, 
                        DeliverQTY      = @DeliverQTY, 
                        Deliverdate     = @Deliverdate, 
                        Price           = @Price,
                        Paid            = @paid
                    WHERE CustomerOrderItemID = @OrderItemID
                ");

                cmd.Parameters.Add(new MySqlParameter("InventoryID", cust.Id));
                cmd.Parameters.Add(new MySqlParameter("RequestQTY", cust.RequestQty));
                cmd.Parameters.Add(new MySqlParameter("DeliverQTY", 0)); // Set deliver options to 0
                cmd.Parameters.Add(new MySqlParameter("Deliverdate", cust.DeliverDate));
                cmd.Parameters.Add(new MySqlParameter("OrderItemID", cust.CustomerOrderItemID));
                cmd.Parameters.Add(new MySqlParameter("Price", cust.Price));
                cmd.Parameters.Add(new MySqlParameter("paid", cust.Paid));

                try
                {
                    cmd.ExecuteNonQuery();

                    if (cust.DeliverQty != temp.DeliverQty)
                    {
                        Item item = new() { Id = cust.Id, QtySold = cust.DeliverQty - temp.DeliverQty };
                        if (transaction == null)
                        {
                            transaction = new Transaction()
                            {
                                TranType = Transaction.TranactionType.Invoice,
                                CustomerID = cust.Id
                            };
                            transaction.Items.Add(item);
                            DataAccess.Instance.Transaction.InsertTransaction(transaction, false);
                        }
                        else
                        {
                            Item existingItem = transaction.Items.FirstOrDefault(x => x.Id == item.Id);
                            if (existingItem != null)
                                existingItem.QtySold += cust.DeliverQty - temp.DeliverQty;
                            else
                                transaction.Items.Add(item);
                            DataAccess.Instance.Transaction.UpdateTransaction(transaction);
                        }
                        transactionORM.DecrementInventoryQty(item);
                    }
                       
                }
                finally
                {
                    db.CloseCommand(cmd);
                }

                if (cust.RequestQty <= cust.DeliverQty)
                {

                    cmd = db.CreateCommand(@$"
                        DELETE FROM customerorderitem
                        WHERE CustomerOrderItemID = @OrderItemID
                        AND RequestQty <= 0
                        AND Paid = Price * DeliverQty
                    ");
                    cmd.Parameters.Add(new MySqlParameter("OrderItemID", cust.CustomerOrderItemID));
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
            return cust.CustomerOrderItemID;
        }

        public void Delete(uint custOrdItemID)
        {

            if (custOrdItemID == 0)
                throw new Exception("Missing CustomerOrderItem Id");

            CustomerOrderItem temp = GetCustomerItem(custOrdItemID);

            if (temp == null)
                throw new Exception("CustomerOrderItem is missing");

            if (temp.Price * temp.DeliverQty > temp.Paid)
                throw new Exception("Items not delivered");

            if (temp.Price * temp.DeliverQty < temp.Paid)
                throw new Exception("Items not paid for");

            MySqlCommand cmd = db.CreateCommand(@"
                DELETE FROM customerOrderItem
                WHERE CustomerOrderItemID = @CustID
            ");

            cmd.Parameters.Add(new MySqlParameter("custID", custOrdItemID));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        private uint GetCustomerID(uint CustomerOrderItemId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
              SELECT customerID 
              FROM CustomerOrderItem
              WHERE CustomerOrderItemID = @custItemID;
            ");
            cmd.Parameters.AddWithValue("custItemID", CustomerOrderItemId);

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID");
                else
                    return 0;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }


        private static List<CustomerOrder> FetchOrderCustomers(MySqlDataReader reader)
        {
            List<CustomerOrder> output = new();
            CustomerOrder temp = null;
            while (reader.Read())
            {
                if (temp == null || temp.CustomerID != reader.GetUInt32("CustomerID"))
                {
                    temp = new CustomerOrder
                    {
                        CustomerID = reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID"),
                        CustomerDiscount = reader.IsDBNull("customer_discount") ? 0.0 : reader.GetDouble("customer_discount"),
                        FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name"),
                        LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name"),
                        BusinessName = reader.IsDBNull("business_name") ? "" : reader.GetString("business_name"),
                        IsWholesale = !reader.IsDBNull("isWholesale") && reader.GetBoolean("isWholesale")
                    };

                    output.Add(temp);
                }

                uint id = reader.IsDBNull("InventoryID") ? 0 : reader.GetUInt32("InventoryID");
                CustomerOrderItem coi = temp.Items.FirstOrDefault(x => x.Id == id);
                if (coi == null)
                    temp.Items.Add(new CustomerOrderItem
                    {
                        CustomerOrderItemID = reader.IsDBNull("CustomerOrderItemID") ? 0 : reader.GetUInt32("CustomerOrderItemID"),
                        DeliverDate = reader.IsDBNull("itemDeliverDate") ? DateTime.MinValue : reader.GetDateTime("itemDeliverDate"),
                        DeliverQty = reader.IsDBNull("DeliverQty") ? 0 : reader.GetUInt32("DeliverQty"),
                        BottleDeposit = reader.IsDBNull("Bottle_Deposit") ? 0 : reader.GetUInt32("Bottle_Deposit"),
                        Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                        OrderQty = reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty"),
                        RequestDate = reader.IsDBNull("RequestDate") ? DateTime.MinValue : reader.GetDateTime("Requestdate"),
                        RequestQty = reader.IsDBNull("RequestQty") ? 0 : reader.GetUInt32("RequestQty"),
                        Id = reader.IsDBNull("InventoryID") ? 0 : reader.GetUInt32("InventoryID"),
                        Price = reader.IsDBNull("price") ? 0 : reader.GetDouble("price"),
                        ItemType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name"),
                        AllQty = new List<InventoryQty>
                          { new InventoryQty
                            {
                              Qty = reader.IsDBNull("Inventory_qty") ? 0 : reader.GetUInt32("Inventory_qty")
                          } }
                    });
                else
                {
                    coi.RequestQty += reader.IsDBNull("RequestQty") ? 0 : reader.GetUInt32("RequestQty");
                    coi.OrderQty += reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty");
                    coi.DeliverQty += reader.IsDBNull("DeliverQty") ? 0 : reader.GetUInt32("DeliverQty");
                }
            }
            return output;
        }
    }
}
