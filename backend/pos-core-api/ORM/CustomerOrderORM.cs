﻿using MySql.Data.MySqlClient;
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
        ORDER BY customerID, CustomerOrderID
        ";
        const string OUTSTANDINGCUSTOMERORDERSQL = @"
        SELECT *
        FROM  v_CustomerOrder
        WHERE IFNULL(DeliverQty, 0) < OrderQty
        ORDER BY customerID, CustomerOrderID
        ";

        public List<CustomerOrder> Get(bool includehistory)
        {
            db.OpenConnection();

            MySqlCommand cmd ;
            
            if (includehistory)
                cmd = new MySqlCommand( CUSTOMERORDERSQL, db.Connection());
            else
                cmd = new MySqlCommand(OUTSTANDINGCUSTOMERORDERSQL, db.Connection()); 

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

        public CustomerOrder Get(uint customerID, bool includehistory)
        {
            db.OpenConnection();

            string sqlStatement = @$"{(includehistory ? $"{CUSTOMERORDERSQL} WHERE " : $"{OUTSTANDINGCUSTOMERORDERSQL} AND ")}
              customerID = @custID
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
                    return null;
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
        }

        public CustomerOrder GetOrder(uint orderId, bool includehistory)
        {
            db.OpenConnection();

            string sqlStatement = @$"{(includehistory ? $"{CUSTOMERORDERSQL} WHERE " : $"{OUTSTANDINGCUSTOMERORDERSQL} AND ")}
              CustomerOrderid = @orderId
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
                    cmd.Parameters.Add(new MySqlParameter("OrderQTY", i.RequestQty));
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
            CustomerOrder co = GetOrder(cust.CustomerOrderID, true);

            if (co is null || co.CustomerOrderID == 0)
                return Insert(cust);

            db.OpenConnection();
            try
            {
                string sqlStatementDesc = @"
                  UPDATE customerorder
                  SET CustomerID    = @CustomerID, 
                      InvoiceAmount = @InvoiceAmount, 
                      PaidAmount    = @PaidAmount, 
                      RequestDate   = @RequestDate, 
                      DeliverDate   = @DeliverDate, 
                      OrderNote     = @OrderNote
                  WHERE CustomerOrderID = @CustomerOrderID
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
                      (CustomerOrderItemID, CustomerOrderID, InventoryID, OrderQTY)
                     VALUES
                      (@OrderItemID, @CustomerOrderID, @InventoryID, @OrderQTY)
                     ON DUPLICATE KEY UPDATE
                         InventoryID     = @InventoryID, 
                         OrderQTY        = @OrderQTY, 
                         DeliverQTY      = @DeliverQTY, 
                         Deliverdate     = @Deliverdate
                    ", db.Connection());

                    cmd.Parameters.Add(new MySqlParameter("CustomerOrderID", cust.CustomerOrderID));
                    cmd.Parameters.Add(new MySqlParameter("InventoryID", i.Id));
                    cmd.Parameters.Add(new MySqlParameter("OrderQTY", i.RequestQty));
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
                if(temp == null || temp.CustomerID != reader.GetUInt32("CustomerID"))
                {
                    temp = new CustomerOrder
                    {
                        CustomerID = reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID"),
                        CustomerDiscount = reader.IsDBNull("customer_discount") ? 0.0 : reader.GetDouble("customer_discount"),
                        FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name"),
                        LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name"),
                        BusinessName = reader.IsDBNull("business_name") ? "" : reader.GetString("business_name"),
                        IsWholesale = !reader.IsDBNull("isWholesale") && reader.GetBoolean("isWholesale"), 
                    };
// OrderNote = reader.IsDBNull("OrderNote") ? "" : reader.GetString("OrderNote"),
                    output.Add(temp);
                }

                uint id = reader.IsDBNull("InventoryID") ? 0 : reader.GetUInt32("InventoryID");
                CustomerOrderItem coi = temp.Items.FirstOrDefault(x => x.Id == id);
                if (coi == null)
                    temp.Items.Add(new CustomerOrderItem
                    {
                        CustomerOrderItemID = reader.IsDBNull("CustomerOrderItemID") ? 0 : reader.GetUInt32("CustomerOrderItemID"),
                        RequestDate = reader.IsDBNull("requestDate") ? DateTime.MinValue : reader.GetDateTime("RequestDate"),
                        DeliverDate = reader.IsDBNull("DeliverDate") ? DateTime.MinValue : reader.GetDateTime("DeliverDate"),
                        PaidDate = reader.IsDBNull("PaidDate") ? DateTime.MinValue : reader.GetDateTime("PaidDate"),
                        DeliverQty = reader.IsDBNull("DeliverQty") ? 0 : reader.GetUInt32("DeliverQty"),
                        BottleDeposit = reader.IsDBNull("Bottle_Deposit") ? 0 : reader.GetUInt32("Bottle_Deposit"),
                        Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                        Barcode = reader.IsDBNull("Barcode") ? "" : reader.GetString("Barcode"),
                        RequestQty = reader.IsDBNull("RequestQty") ? 0 : reader.GetUInt32("RequestQty"),
                        OrderQty = reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty"),
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
                    coi.RequestQty += reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty");
                    coi.DeliverQty += reader.IsDBNull("DeliverQty") ? 0 : reader.GetUInt32("DeliverQty");
                }
            }
            return output;
        }
    }
}
