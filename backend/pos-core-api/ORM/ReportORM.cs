using MySql.Data.MySqlClient;
using Shared;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class ReportORM
    {
        readonly DbConn db = new();

      

        public long Insert(Customer cust)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO customer 
                (customer_discount, first_name, last_name, business_name, email, iswholesale, addr1, addr2, city, state, zip, phone)
                VALUES 
                (@customerdiscount, @firstname, @lastname, @businessname, @email, @iswholesale, @addr1, @addr2, @city, @state, @zip, @phone)
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
                SET customer_discount = @customerdiscount, first_name = @firstname,
                    last_name = @lastname, business_name = @businessname,
                    email = @email, iswholesale = @iswholesale,
                    addr1 = @addr1, addr2 = @addr2, 
                    city = @city, state = @state, 
                    zip = @zip, phone = @phone 
                WHERE customerid = @custid
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
    }
}
