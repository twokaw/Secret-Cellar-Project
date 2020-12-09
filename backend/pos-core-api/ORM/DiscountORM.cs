using MySql.Data.MySqlClient;
using Shared;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class DiscountORM
    {
        private readonly DbConn db = new DbConn();

        public List<Discount> Get()
        {
            List<Discount> output = new List<Discount>();
            Discount outputItem;
            db.OpenConnection();

            string sqlStatement = @"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount
              FROM V_Discount
            ";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    outputItem = new Discount
                    {
                        DiscountID = reader.IsDBNull("DiscountID") ? 0 : reader.GetUInt32("DiscountID"),
                        DiscountName = reader.IsDBNull("DiscountName") ? "" : reader.GetString("DiscountName"),
                        Min = reader.IsDBNull("minQty") ? 0 : reader.GetUInt32("minQty"),
                        Max = reader.IsDBNull("minQty") ? 0 : reader.GetUInt32("minQty"),
                        Amount = reader.IsDBNull("local_sales_Discount") ? 0.0 : reader.GetDouble("local_sales_Discount")
                    };
                    output.Add(outputItem);
                }
            }
            finally
            {
                reader.Close();
            }

            db.CloseConnnection();
            return output;
        }

        public uint Insert(Discount Discount)
        {
            db.OpenConnection();
            uint newId = 0;
            string sqlStatement = @"
                INSERT INTO v_Discount
                (DiscountName, minQty, maxQty, Discount)
                VALUES
                (@DiscountName, @minQty, @maxQty, @Discount)
            ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("DiscountName", Discount.DiscountName));
                cmd.Parameters.Add(new MySqlParameter("minQty", Discount.Min));
                cmd.Parameters.Add(new MySqlParameter("maxQty", Discount.Max));
                cmd.Parameters.Add(new MySqlParameter("Discount", Discount.Amount));
                cmd.ExecuteNonQuery();
                newId = (uint)cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }

            return newId;
        }

        public uint Update(Discount Discount)
        {
            db.OpenConnection();
            if (Get(Discount.DiscountID) == null)
                return Insert(Discount);
            else
            {
                string sqlStatement = @"
                    UPDATE v_Discount
                        DiscountName = @DiscountName, 
                        minQty = @minQty, 
                        maxQty = @maxQty, 
                        Discount = @Discount
                    WHERE idDiscount = @idDiscount
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idDiscount", Discount.DiscountID));
                    cmd.Parameters.Add(new MySqlParameter("DiscountName", Discount.DiscountName));
                    cmd.Parameters.Add(new MySqlParameter("minQty", Discount.Min));
                    cmd.Parameters.Add(new MySqlParameter("maxQty", Discount.Max));
                    cmd.Parameters.Add(new MySqlParameter("Discount", Discount.Amount));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return Discount.DiscountID;
        }

        public bool Delete(uint DiscountId)
        {
            db.OpenConnection();
            if (Get(DiscountId) == null)
                return false;
            else
            {
                string sqlStatement = @"
                    DELETE FROM v_Discount
                    WHERE DiscountID = @idDiscount
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idDiscount", DiscountId));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return true;
        }

        // Get: api/Discount
        public Discount Get(uint DiscountId)
        {
            Discount outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT DiscountName, minQty, maxQty, Discount 
              FROM v_Discount 
              WHERE DiscountID = @ID
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("ID", DiscountId));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    outputItem = new Discount
                    {
                        DiscountID = DiscountId,
                        DiscountName = reader.IsDBNull("DiscountName") ? "" : reader.GetString("DiscountName"),
                        Min = reader.IsDBNull("minQty") ? 0 : reader.GetUInt32("minQty"),
                        Max = reader.IsDBNull("minQty") ? 0 : reader.GetUInt32("minQty"),
                        Amount = reader.IsDBNull("local_sales_Discount") ? 0.0 : reader.GetDouble("local_sales_Discount")
                    };
                }
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
            return outputItem;
        }
    }
}
