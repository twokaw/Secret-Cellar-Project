using MySql.Data.MySqlClient;
using Shared;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class TaxORM
    {
        private readonly DbConn db = new DbConn();

        public List<Tax> Get()
        {
            List<Tax> output = new List<Tax>();
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM v_tax";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                    output.Add(FetchTax(reader));
            }
            finally
            {
                reader.Close();
            }

            db.CloseConnnection();
            return output;
        }

        public uint Insert (Tax tax)
        {
            db.OpenConnection();
            uint newId = 0;
            string sqlStatement = @"
                INSERT INTO v_tax
                (bottle_deposit, sales_tax, local_sales_tax, Tax_name
                VALUES
                (@bottle_deposit, @sales_tax, @local_sales_tax, @Tax_name)
            ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("idTAX", tax.IdTax));
                cmd.Parameters.Add(new MySqlParameter("bottle_deposit", tax.BottleDeposit));
                cmd.Parameters.Add(new MySqlParameter("Tax_name", tax.TaxName));
                cmd.Parameters.Add(new MySqlParameter("sales_tax", tax.SalesTax));
                cmd.Parameters.Add(new MySqlParameter("local_sales_tax", tax.LocalSalesTax));
                cmd.ExecuteNonQuery();
                newId = (uint)cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }

            return newId;
        }

        public uint Update( Tax tax)
        {
            db.OpenConnection();
            if (Get(tax.IdTax) == null)
                return Insert(tax);
            else
            {
                string sqlStatement = @"
                    UPDATE v_tax
                    SET bottle_deposit = @bottle_deposit, 
                        sales_tax = @sales_tax, 
                        local_sales_tax = @local_sales_tax, 
                        tax_name = @Tax_name
                    WHERE idTAX = @idTAX
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idTAX", tax.IdTax));
                    cmd.Parameters.Add(new MySqlParameter("bottle_deposit", tax.BottleDeposit));
                    cmd.Parameters.Add(new MySqlParameter("Tax_name", tax.TaxName));
                    cmd.Parameters.Add(new MySqlParameter("sales_tax", tax.SalesTax));
                    cmd.Parameters.Add(new MySqlParameter("local_sales_tax", tax.LocalSalesTax));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return tax.IdTax;
        }

        public bool Delete(uint taxId)
        {
            db.OpenConnection();
            if (Get(taxId) == null)
                return false;
            else
            {
                string sqlStatement = @"
                    DELETE FROM v_tax
                    WHERE idTAX = @idTAX
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idTAX", taxId));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return true;
        }

        // Get: api/Tax
        public Tax Get(string name)
        {
            Tax outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT * 
              FROM v_tax 
              WHERE UPPER(Tax_name) = @name
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("name", name.ToUpper()));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read())
                    outputItem = FetchTax(reader); 
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
            return outputItem;
        }

        // Get: api/Tax
        public Tax Get(uint taxId)
        {
            Tax outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT * 
              FROM v_tax 
              WHERE idTax = @ID
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("ID", taxId));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read())
                    outputItem = FetchTax(reader);
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
            return outputItem;
        }

        private Tax FetchTax(MySqlDataReader reader)
        {
            return new Tax
            {
                IdTax = reader.IsDBNull("idTAX") ? 0 : reader.GetUInt32("idTAX"),
                BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0.0 : reader.GetDouble("bottle_deposit"),
                TaxName = reader.IsDBNull("Tax_name") ? "" : reader.GetString("tax_name"),
                SalesTax = reader.IsDBNull("sales_tax") ? 0.0 : reader.GetDouble("sales_tax"),
                LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0.0 : reader.GetDouble("local_sales_tax")
            };
        }
    }
}
