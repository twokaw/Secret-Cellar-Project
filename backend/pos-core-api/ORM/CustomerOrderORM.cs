using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class CustomerOrderORM
    {
        readonly DbConn db = new DbConn();

        const string CUSTOMERORDERSQL = @"
        SELECT CustomerOrderItemID, 
           CustomerOrderID,   
	       Customer_Discount,
           InventoryID, 
	       name, 
           OrderQTY, 
           PaidAmount,  
           Inventory_qty,
           DeliverQTY,  
           CustomerID,
           RequestDate, 
           DeliverDate, 
           itemDeliverDate, 
           First_name, 
	       inventory_type_name,
	       Last_name, 
	       Business_name,
	       isWholesale, 
           OrderNote,
           Bottle_Deposit
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
            try
            {
                db.OpenConnection();

                string sqlStatementDesc = @"
                  INSERT INTO customer 
                  (customer_discount, first_name, last_name, business_name, email, isWholesale, addr1, addr2, city, state, zip, phone, credit)
                  VALUES 
                  (@customerDiscount, @firstName, @lastName, @businessName, @email, @isWholesale, @addr1, @addr2, @city, @state, @zip, @phone, @credit)
                ";
                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("customerDiscount", cust.CustomerDiscount));
                cmd.Parameters.Add(new MySqlParameter("firstName", cust.FirstName));
                cmd.Parameters.Add(new MySqlParameter("lastName", cust.LastName));
                cmd.Parameters.Add(new MySqlParameter("businessName", cust.BusinessName));
                cmd.Parameters.Add(new MySqlParameter("email", cust.Email));
                cmd.Parameters.Add(new MySqlParameter("isWholesale", cust.IsWholesale));
                cmd.Parameters.Add(new MySqlParameter("addr1", cust.Address1));
                cmd.Parameters.Add(new MySqlParameter("addr2", cust.Address2));
                cmd.Parameters.Add(new MySqlParameter("city", cust.City));
                cmd.Parameters.Add(new MySqlParameter("state", cust.State));
                cmd.Parameters.Add(new MySqlParameter("zip", cust.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("phone", cust.PhoneNumber));
                cmd.Parameters.Add(new MySqlParameter("credit", cust.Credit));

                cmd.ExecuteNonQuery();

                return cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }
        }
        public long Update(Customer cust)
        {
            db.OpenConnection();

            try
            {
                string sqlStatementDesc = @"
                 UPDATE customer 
                 SET customer_discount = @customerDiscount, first_name = @firstName,
                     last_name = @lastName, business_name = @businessName,
                     email = @email, isWholesale = @isWholesale,
                     addr1 = @addr1, addr2 = @addr2, 
                     city = @city, state = @state, 
                     zip = @zip, phone = @phone,
                     credit = @credit
                 WHERE customerID = @custID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("customerDiscount", cust.CustomerDiscount));
                cmd.Parameters.Add(new MySqlParameter("firstName", cust.FirstName));
                cmd.Parameters.Add(new MySqlParameter("lastName", cust.LastName));
                cmd.Parameters.Add(new MySqlParameter("businessName", cust.BusinessName));
                cmd.Parameters.Add(new MySqlParameter("email", cust.Email));
                cmd.Parameters.Add(new MySqlParameter("isWholesale", cust.IsWholesale));
                cmd.Parameters.Add(new MySqlParameter("addr1", cust.Address1));
                cmd.Parameters.Add(new MySqlParameter("addr2", cust.Address2));
                cmd.Parameters.Add(new MySqlParameter("city", cust.City));
                cmd.Parameters.Add(new MySqlParameter("state", cust.State));
                cmd.Parameters.Add(new MySqlParameter("zip", cust.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("phone", cust.PhoneNumber));
                cmd.Parameters.Add(new MySqlParameter("credit", cust.Credit));
                cmd.Parameters.Add(new MySqlParameter("custID", cust.CustomerID));

                return cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public void Delete(uint custID)
        {
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = @"
                  DELETE FROM customer 
                  WHERE customerID = @CustID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("custID", custID));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }
        public void AddCredit(uint custID, double amount)
        {
            db.OpenConnection();
            try
            {
                string sqlStatementDesc = @"
                  UPDATE customer 
                  SET Credit = IFNULL(Credit, 0) - @amount
                  WHERE customerID = @CustID
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("custID", custID));
                cmd.Parameters.Add(new MySqlParameter("amount", amount));
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

                temp.Items.Add(new CustomerOrderItems
                {
                    DeliverDate = reader.IsDBNull("itemDeliverDate") ? DateTime.MinValue : reader.GetDateTime("itemDeliverDate"),
                    DeliverQty = reader.IsDBNull("DeliverQty") ? 0 : reader.GetUInt32("DeliverQty"),
                    BottleDeposit = reader.IsDBNull("Bottle_Deposit") ? 0 : reader.GetUInt32("Bottle_Deposit"),
                    Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                    OrderQty = reader.IsDBNull("OrderQty") ? 0 : reader.GetUInt32("OrderQty"),
                    Price = reader.IsDBNull("price") ? 0 : reader.GetDouble("price"),
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
