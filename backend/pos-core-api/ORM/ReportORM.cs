using MySql.Data.MySqlClient;
using Shared;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class ReportORM
    {
        readonly DbConn db = new DbConn();

        public List<Customer> Get()
        {
            db.OpenConnection();

            string sqlStatement = @"
              SELECT customerID, customer_discount, first_name, last_name,
                     business_name, email, isWholesale, 
                     addr1, addr2, city, state, zip, phone
              FROM v_customer
            ";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
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

        public long Insert(Customer cust)
        {
            try
            {
                db.OpenConnection();

                string sqlStatementDesc = @"
                  INSERT INTO customer 
                  (customer_discount, first_name, last_name, business_name, email, isWholesale, addr1, addr2, city, state, zip, phone)
                  VALUES 
                  (@customerDiscount, @firstName, @lastName, @businessName, @email, @isWholesale, @addr1, @addr2, @city, @state, @zip, @phone)
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
                     zip = @zip, phone = @phone 
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
                cmd.Parameters.Add(new MySqlParameter("custID", cust.CustomerID));

                return cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }


    }
}
