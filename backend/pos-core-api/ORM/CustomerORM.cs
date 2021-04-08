using MySql.Data.MySqlClient;
using Shared;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class CustomerORM
    {
        readonly DbConn db = new DbConn();

        const string CUSTOMERSQL = @"
              SELECT customerID, customer_discount, first_name, last_name,
                     business_name, email, isWholesale, 
                     addr1, addr2, city, state, zip, phone, credit, balancedue, suspendedtransactions       
              FROM v_customerwithbalance
            ";

        public List<Customer> Get()
        {
            db.OpenConnection();


            MySqlCommand cmd = new MySqlCommand(CUSTOMERSQL, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                return FetchCustomers(reader);
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
        }

        public Customer Get(uint customerID)
        {
            db.OpenConnection();

            string sqlStatement = @$"{CUSTOMERSQL}
              WHERE customerID = @custID
            ";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
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
                db.CloseConnnection();
            }
        }

        public Customer Get(string phone)
        {
            db.OpenConnection();

            string sqlStatement = @$"{CUSTOMERSQL}
              WHERE phone = @phone
            ";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
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
                db.CloseConnnection();
            }
        }

        public long Insert(Customer cust)
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

        private List<Customer> FetchCustomers(MySqlDataReader reader)
        {
            List<Customer> output = new List<Customer>();

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
    }
}
