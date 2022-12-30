using MySql.Data.MySqlClient;
using Shared;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class TaxORM
    {
        private readonly DbConn db = new();

        public List<Tax> Get()
        {
            List<Tax> output = new();
            

            string sqlStatement = "SELECT * FROM v_tax";

            MySqlCommand cmd = db.CreateCommand(sqlStatement);
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

            db.CloseCommand(cmd);
            return output;
        }

        public uint Insert (Tax tax)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO tax
                (bottle_deposit, sales_tax, local_sales_tax, tax_name)
                VALUES
                (@bottle_deposit, @sales_tax, @local_sales_tax, @tax_name)
            ");
            cmd.Parameters.Add(new MySqlParameter("bottle_deposit", tax.BottleDeposit));
            cmd.Parameters.Add(new MySqlParameter("Tax_name", tax.TaxName));
            cmd.Parameters.Add(new MySqlParameter("sales_tax", tax.SalesTax));
            cmd.Parameters.Add(new MySqlParameter("local_sales_tax", tax.LocalSalesTax));

            try
            {
                cmd.ExecuteNonQuery();
                return (uint)cmd.LastInsertedId;
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public uint Update( Tax tax)
        {
            if (Get(tax.IdTax) == null)
                return Insert(tax);
            else
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    UPDATE v_tax
                    SET bottle_deposit = @bottle_deposit, 
                        sales_tax = @sales_tax, 
                        local_sales_tax = @local_sales_tax, 
                        tax_name = @tax_name
                    WHERE idtax = @idtax
                ");
                cmd.Parameters.Add(new MySqlParameter("idTAX", tax.IdTax));
                cmd.Parameters.Add(new MySqlParameter("bottle_deposit", tax.BottleDeposit));
                cmd.Parameters.Add(new MySqlParameter("Tax_name", tax.TaxName));
                cmd.Parameters.Add(new MySqlParameter("sales_tax", tax.SalesTax));
                cmd.Parameters.Add(new MySqlParameter("local_sales_tax", tax.LocalSalesTax));
                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseCommand(cmd);
                }
            }

            return tax.IdTax;
        }

        public bool Delete(uint taxId)
        {
            
            if (Get(taxId) == null)
                return false;
            else
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    DELETE FROM v_tax
                    WHERE idtax = @idtax
                ");
                cmd.Parameters.Add(new MySqlParameter("idTAX", taxId));

                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseCommand(cmd);
                }
            }

            return true;
        }

        // Get: api/Tax
        public Tax Get(string name)
        {
            Tax outputItem = null;
            

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT * 
              FROM v_tax 
              WHERE UPPER(tax_name) = @name
            ");
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
                db.CloseCommand(cmd);
            }
            return outputItem;
        }

        // Get: api/Tax
        public Tax Get(uint taxId)
        {
            Tax outputItem = null;
            

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT * 
              FROM v_tax 
              WHERE idtax = @id
            ");
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
                db.CloseCommand(cmd);
            }
            return outputItem;
        }

        private static Tax FetchTax(MySqlDataReader reader)
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
