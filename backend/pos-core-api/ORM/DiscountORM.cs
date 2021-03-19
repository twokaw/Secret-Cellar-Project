using MySql.Data.MySqlClient;
using Shared;
using System.Data;
using System.Collections.Generic;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class DiscountORM
    {
        private readonly DbConn db = new DbConn();

        public List<Discount> Get()
        {
            List<Discount> output = new List<Discount>();
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount
              FROM V_Discount
            ", db.Connection());

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                        output.Add(FetchDiscount(reader));
                }
                finally
                {
                    reader.Close();
                }
            }

            db.CloseConnnection();
            return output;
        }

        public Discount Get(uint DiscountId)
        {
            Discount outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount 
              FROM v_Discount 
              WHERE DiscountID = @ID
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("ID", DiscountId));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read())
                    outputItem = FetchDiscount(reader);
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
            return outputItem;
        }
        private Discount FetchDiscount(MySqlDataReader reader)
        {
           return new Discount
            {
                DiscountID = reader.IsDBNull("DiscountID") ? 0 : reader.GetUInt32("DiscountID"),
                DiscountName = reader.IsDBNull("DiscountName") ? "" : reader.GetString("DiscountName"),
                Min = reader.IsDBNull("minQty") ? 0 : reader.GetUInt32("minQty"),
                Max = reader.IsDBNull("maxQty") ? 0 : reader.GetUInt32("maxQty"),
                Amount = reader.IsDBNull("Discount") ? 0 : reader.GetDouble("Discount")
            };
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
            
            if (Get(Discount.DiscountID) == null)
                return Insert(Discount);
            else
            {
                string sqlStatement = @"
                    UPDATE v_Discount
                    set DiscountName = @DiscountName, 
                        minQty = @minQty, 
                        maxQty = @maxQty, 
                        Discount = @Discount
                    WHERE DiscountID = @idDiscount
                ";
                db.OpenConnection();
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
        public bool Update(uint discountId, int typeId)
        {
            db.OpenConnection();
            if (Get(discountId) == null || DataAccess.Instance.InventoryType.Get(typeId) == null)
                return false;
            else
            {
                string sqlStatement = @"
                    REPLACE INTO discount_type
                    (discountId, typeId) 
                    VALUES
                    (@discountId, @typeId)
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("discountId", discountId));
                    cmd.Parameters.Add(new MySqlParameter("typeId", typeId));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return true;
        }
        public void Delete(uint discountId, int typeId)
        {
            db.OpenConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand(@"
                    DELETE FROM discount_type
                    WHERE discountId = @discountId
                    AND   typeId = @typeId
                ", db.Connection());
                cmd.Parameters.Add(new MySqlParameter("discountId", discountId));
                cmd.Parameters.Add(new MySqlParameter("typeId", typeId));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public bool Delete(uint DiscountId)
        {
            db.OpenConnection();
            if (Get(DiscountId) == null)
                return false;
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(@"
                        DELETE FROM v_Discount
                        WHERE DiscountID = @idDiscount
                    ", db.Connection());
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

    }
}
