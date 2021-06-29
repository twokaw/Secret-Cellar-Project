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
        readonly DbConn db = new DbConn();

        const string CUSTOMERORDERSQL = @"
        SELECT *
        FROM  v_CustomerOrder
        ";

        public List<CustomerOrder> Get()
        {
            db.OpenConnection();


            MySqlCommand cmd = new MySqlCommand(CUSTOMERORDERSQL, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                return FetchOrderCustomers(reader);
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
        }

        public CustomerOrder Get(uint customerID)
        {
            db.OpenConnection();

            string sqlStatement = @$"{CUSTOMERORDERSQL}
              WHERE customerID = @custID
            ";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("custID", customerID));
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
                db.CloseConnnection();
            }
        }

        public CustomerOrder GetOrder(uint orderId)
        {
            db.OpenConnection();

            string sqlStatement = @$"{CUSTOMERORDERSQL}
              WHERE CustomerOrderid = @orderId
            ";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
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
                db.CloseConnnection();
            }
        }

        public long Insert(CustomerOrder cust)
        {
            long CustomerOrderID = 0;

            try
            {
                db.OpenConnection();

                 MySqlCommand cmd = new MySqlCommand(@"
                  INSERT INTO customerorder
                  (CustomerID, InvoiceAmount, PaidAmount, RequestDate, DeliverDate, OrderNote)
                  VALUES
                  (@CustomerID, @InvoiceAmount, @PaidAmount, @RequestDate, @DeliverDate, @OrderNote)
                ", db.Connection());
                cmd.Parameters.Add(new MySqlParameter("CustomerID", cust.CustomerID));
                cmd.Parameters.Add(new MySqlParameter("InvoiceAmount", cust.InvoiceAmount));
                cmd.Parameters.Add(new MySqlParameter("PaidAmount", cust.PaidAmount));
                cmd.Parameters.Add(new MySqlParameter("RequestDate", cust.RequestDate));
                cmd.Parameters.Add(new MySqlParameter("DeliverDate", cust.DeliveryDate ));
                cmd.Parameters.Add(new MySqlParameter("OrderNote", cust.OrderNote));

                cmd.ExecuteNonQuery();

                CustomerOrderID = cmd.LastInsertedId;

                foreach(CustomerOrderItem i in cust.Items)
                {
                    cmd = new MySqlCommand(@"
                     INSERT INTO customerorderitem
                      (CustomerOrderID, InventoryID, OrderQTY, DeliverQTY, Deliverdate)
                     VALUES
                      (@CustomerOrderID, @InventoryID, @OrderQTY, @DeliverQTY, @Deliverdate)
                    ", db.Connection());

                    cmd.Parameters.Add(new MySqlParameter("CustomerOrderID", CustomerOrderID));
                    cmd.Parameters.Add(new MySqlParameter("InventoryID", i.Id));
                    cmd.Parameters.Add(new MySqlParameter("OrderQTY", i.OrderQty));
                    cmd.Parameters.Add(new MySqlParameter("DeliverQTY", i.DeliverQty));
                    cmd.Parameters.Add(new MySqlParameter("Deliverdate", i.DeliverDate));

                    cmd.ExecuteNonQuery();
                }
                return CustomerOrderID;
            }
            finally
            {
                db.CloseConnnection();
            }
        }
        public long Update(CustomerOrder cust)
        {
           
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = @"
                  INSERT INTO customerorder
                  (CustomerOrderID, CustomerID, InvoiceAmount, PaidAmount, RequestDate, DeliverDate, OrderNote)
                  VALUES
                  (@CustomerOrderID, @CustomerID, @InvoiceAmount, @PaidAmount, @RequestDate, @DeliverDate, @OrderNote)
                  ON DUPLICATE KEY UPDATE
                      CustomerID    = @CustomerID, 
                      InvoiceAmount = @InvoiceAmount, 
                      PaidAmount    = @PaidAmount, 
                      RequestDate   = @RequestDate, 
                      DeliverDate   = @DeliverDate, 
                      OrderNote     = @OrderNote
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("CustomerID", cust.CustomerID));
                cmd.Parameters.Add(new MySqlParameter("InvoiceAmount", cust.InvoiceAmount));
                cmd.Parameters.Add(new MySqlParameter("PaidAmount", cust.PaidAmount));
                cmd.Parameters.Add(new MySqlParameter("RequestDate", cust.RequestDate));
                cmd.Parameters.Add(new MySqlParameter("DeliverDate", cust.DeliveryDate));
                cmd.Parameters.Add(new MySqlParameter("OrderNote", cust.OrderNote));
                cmd.Parameters.Add(new MySqlParameter("CustomerOrderID", cust.CustomerOrderID));

                cmd.ExecuteNonQuery();

                foreach (CustomerOrderItem i in cust.Items)
                {
                    cmd = new MySqlCommand(@"
                     INSERT INTO customerorderitem
                      (CustomerOrderItemID, CustomerOrderID, InventoryID, OrderQTY, DeliverQTY, Deliverdate)
                     VALUES
                      (@OrderItemID, @CustomerOrderID, @InventoryID, @OrderQTY, @DeliverQTY, @Deliverdate)
                     ON DUPLICATE KEY UPDATE
                         CustomerOrderID = @CustomerOrderID, 
                         InventoryID     = @InventoryID, 
                         OrderQTY        = @OrderQTY, 
                         DeliverQTY      = @DeliverQTY, 
                         Deliverdate     = @Deliverdate
                    ", db.Connection());

                    cmd.Parameters.Add(new MySqlParameter("CustomerOrderID", cust.CustomerOrderID));
                    cmd.Parameters.Add(new MySqlParameter("InventoryID", i.Id));
                    cmd.Parameters.Add(new MySqlParameter("OrderQTY", i.OrderQty));
                    cmd.Parameters.Add(new MySqlParameter("DeliverQTY", i.DeliverQty));
                    cmd.Parameters.Add(new MySqlParameter("Deliverdate", i.DeliverDate));
                    cmd.Parameters.Add(new MySqlParameter("OrderItemID", i.CustomerOrderItemID ));
                    cmd.ExecuteNonQuery();
                }

                cmd = new MySqlCommand(@$"
                     DELETE FROM  customerorderitem
                     WHERE CustomerOrderID = @CustomerOrderID
                     AND NOT InventoryID IN ('{ string.Join("','",cust.Items.Select(x=> x.Id).ToArray())}')
                    ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("CustomerOrderID", cust.CustomerOrderID));
                cmd.ExecuteNonQuery();

                return cust.CustomerOrderID;
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public void Delete(uint custOrdID)
        {
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = @"
                  DELETE FROM customerOrder 
                  WHERE CustomerOrderID = @CustID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("custID", custOrdID));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        private List<CustomerOrder> FetchOrderCustomers(MySqlDataReader reader)
        {
            List<CustomerOrder> output = new List<CustomerOrder>();
            CustomerOrder temp = null;
            while (reader.Read())
            {
                if(temp == null || temp.CustomerOrderID != reader.GetUInt32("CustomerOrderID"))
                {
                    temp = new CustomerOrder
                    {
                        CustomerID = reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID"),
                        CustomerDiscount = reader.IsDBNull("customer_discount") ? 0.0 : reader.GetDouble("customer_discount"),
                        FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name"),
                        LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name"),
                        BusinessName = reader.IsDBNull("business_name") ? "" : reader.GetString("business_name"),
                        IsWholesale = !reader.IsDBNull("isWholesale") && reader.GetBoolean("isWholesale"),
                        CustomerOrderID = reader.IsDBNull("CustomerOrderID") ? 0 : reader.GetUInt32("CustomerOrderID"),
                        DeliveryDate  = reader.IsDBNull("DeliverDate") ? DateTime.MinValue : reader.GetDateTime("DeliverDate"),
                        OrderNote = reader.IsDBNull("OrderNote") ? "" : reader.GetString("OrderNote"),
                        RequestDate = reader.IsDBNull("RequestDate") ? DateTime.MinValue : reader.GetDateTime("RequestDate"), 
                        PaidAmount = reader.IsDBNull("PaidAmount") ? 0 : reader.GetDouble("PaidAmount")
                    };

                    output.Add(temp);
                }

                temp.Items.Add(new CustomerOrderItem
                {
                    DeliverDate = reader.IsDBNull("itemDeliverDate") ? DateTime.MinValue : reader.GetDateTime("itemDeliverDate"),
                    DeliverQty = reader.IsDBNull("DeliverQty") ? 0 : reader.GetUInt32("DeliverQty"),
                    BottleDeposit = reader.IsDBNull("Bottle_Deposit") ? 0 : reader.GetUInt32("Bottle_Deposit"),
                    Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                    OrderQty = reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty"),
                    Id = reader.IsDBNull("InventoryID") ? 0 : reader.GetUInt32("InventoryID"),
                    Price = reader.IsDBNull("retail_price") ? 0 : reader.GetDouble("retail_price"),
                    ItemType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name"),
                    AllQty = new List<InventoryQty>
                      { new InventoryQty 
                        {
                          Qty = reader.IsDBNull("Inventory_qty") ? 0 : reader.GetUInt32("Inventory_qty")
                      } }
                });
            }
            return output;
        }
    }
}
