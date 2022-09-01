using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class CustomerORM
    {
        readonly DbConn db = new ();

        const string CUSTOMERSQL = @"
              SELECT customerID, customer_discount, first_name, last_name,
                     business_name, email, isWholesale, 
                     addr1, addr2, city, state, zip, phone, credit, balancedue, suspendedtransactions       
              FROM v_customerwithbalance
            ";

        public List<Customer> Get()
        {
            


            MySqlCommand cmd = db.CreateCommand(CUSTOMERSQL);
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                return FetchCustomers(reader);
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public Customer Get(uint customerID)
        {
            

            string sqlStatement = @$"{CUSTOMERSQL}
              WHERE customerID = @custID
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
            cmd.Parameters.Add(new MySqlParameter("custID", customerID));
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {

                List<Customer> output = FetchCustomers(reader);

                if (output.Count > 0)
                    return output[0];
                else
                    return new Customer();
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public Customer Get(string phone)
        {
            

            string sqlStatement = @$"{CUSTOMERSQL}
              WHERE phone = @phone
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
            cmd.Parameters.Add(new MySqlParameter("phone", phone));
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {

                List<Customer> output = FetchCustomers(reader);

                if (output.Count > 0)
                    return output[0];
                else
                    return new Customer();
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }
        public List<CustomerFavorites> GetCustomerFavorites()
        {
            

            string sqlStatement = @"
              SELECT InventoryID,
                     CustomerID,
                     LastRequestDate
              FROM v_customerfavorite
            ";

            MySqlCommand cmd = new(sqlStatement);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                return FetchCustomersFavorite(reader);
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public CustomerFavorites GetCustomerFavorites(uint customerID)
        {
            string sqlStatement = @"
              SELECT InventoryID,
                     CustomerID,
                     LastRequestDate
              FROM v_customerfavorite
              WHERE CustomerID = @custId
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
            cmd.Parameters.Add(new MySqlParameter("custID", customerID));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                List<CustomerFavorites> cf = FetchCustomersFavorite(reader);
                if (cf.Count > 0)
                    return cf[0];
                else
                    return new CustomerFavorites();
            }
            finally
            {
                reader.Close();
                db.CloseCommand(cmd);
            }
        }

        public string GetCustHash()
        {
            using MySqlCommand cmd = db.CreateCommand(@"
                SELECT HashValue
                FROM v_customer_hash
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

        public void AddCustomerFavorite(uint CustomerID, uint InventoryID)
        {

            string sqlStatement = @"
              INSERT INTO customerfavorite
              ( InventoryID, CustomerID)
              VALUES
              (@InventoryID, @customerID)
              ON DUPLICATE KEY UPDATE customerID = @customerID
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
            cmd.Parameters.Add(new MySqlParameter("customerID", CustomerID));
            cmd.Parameters.Add(new MySqlParameter("InventoryID", InventoryID));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void RemoveCustomerFavorite(uint CustomerID, uint InventoryID)
        {
            

            string sqlStatement = @"
              DELETE FROM customerfavorite
              WHERE InventoryID = @InventoryID
              AND   CustomerID  = @customerID
            ";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
            cmd.Parameters.Add(new MySqlParameter("customerID", CustomerID));
            cmd.Parameters.Add(new MySqlParameter("InventoryID", InventoryID));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
        public long Insert(Customer cust)
        {
            string sqlStatementDesc = @"
                INSERT INTO customer 
                (customer_discount, first_name, last_name, business_name, email, isWholesale, addr1, addr2, city, state, zip, phone, credit)
                VALUES 
                (@customerDiscount, @firstName, @lastName, @businessName, @email, @isWholesale, @addr1, @addr2, @city, @state, @zip, @phone, @credit)
            ";
            MySqlCommand cmd = db.CreateCommand(sqlStatementDesc);
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

        public long Update(Customer cust)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE customer 
                SET customer_discount = @customerDiscount, first_name = @firstName,
                    last_name = @lastName, business_name = @businessName,
                    email = @email, isWholesale = @isWholesale,
                    addr1 = @addr1, addr2 = @addr2, 
                    city = @city, state = @state, 
                    zip = @zip, phone = @phone,
                    credit = @credit
                WHERE customerID = @custID
            ");

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

            try
            {
                return cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void Delete(uint custID)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                DELETE FROM customer 
                WHERE customerID = @CustID
            ");
            cmd.Parameters.Add(new MySqlParameter("custID", custID));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public void AddCredit(uint custID, double amount)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE customer 
                SET Credit = IFNULL(Credit, 0) + @amount
                WHERE customerID = @CustID
            ");
            cmd.Parameters.Add(new MySqlParameter("custID", custID));
            cmd.Parameters.Add(new MySqlParameter("amount", amount));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
        private static List<Customer> FetchCustomers(MySqlDataReader reader)
        {
            List<Customer> output = new();

            while (reader.Read())
            {
                output.Add(new Customer
                {
                    CustomerID = reader.IsDBNull("customerID") ? 0 : reader.GetUInt32("customerID"),
                    CustomerDiscount = reader.IsDBNull("customer_discount") ? 0.0 : reader.GetDouble("customer_discount"),
                    FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name"),
                    LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name"),
                    BusinessName = reader.IsDBNull("business_name") ? "" : reader.GetString("business_name"),
                    Email = reader.IsDBNull("email") ? "" : reader.GetString("email"),
                    IsWholesale = !reader.IsDBNull("isWholesale") && reader.GetBoolean("isWholesale"),
                    Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1"),
                    Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2"),
                    City = reader.IsDBNull("city") ? "" : reader.GetString("city"),
                    State = reader.IsDBNull("state") ? "" : reader.GetString("state"),
                    ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip"),
                    PhoneNumber = reader.IsDBNull("phone") ? "" : reader.GetString("phone"),
                    Credit = reader.IsDBNull("credit") ? 0.0 : reader.GetDouble("credit"),
                    BalanceDue = reader.IsDBNull("balancedue") ? 0.0 : reader.GetDouble("balancedue"),
                    SuspendedTransactions = reader.IsDBNull("suspendedtransactions") ? 0 : reader.GetUInt32("suspendedtransactions")
                });
            }
            return output;
        }

        private static List<CustomerFavorites> FetchCustomersFavorite(MySqlDataReader reader)
        {
            List<CustomerFavorites> output = new();
            CustomerFavorites lastcustomer = null;
            uint tempLastid;
            while (reader.Read())
            {
                tempLastid = reader.GetUInt32("customerID");

                if (lastcustomer?.CustomerID != tempLastid)
                {     
                    lastcustomer = new CustomerFavorites
                    {
                        CustomerID = tempLastid
                    };
                    output.Add(lastcustomer);
                }

                if(!reader.IsDBNull("InventoryID"))
                    lastcustomer.Favorites.Add( new CustomerFavorite
                    {
                        InventoryID = reader.GetUInt32("InventoryID"),
                        Lastused = reader.IsDBNull("LastRequestDate") ? DateTime.MinValue : reader.GetDateTime("LastRequestDate")
                    });
            }
            return output;
        }
    }
}
