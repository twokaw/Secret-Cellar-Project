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

        public Discount Get(uint discountId)
        {
            Discount outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount 
              FROM v_Discount 
              WHERE DiscountID = @ID
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("ID", discountId));
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

        public Discount Get(string discountName)
        {
            Discount outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount 
              FROM v_Discount 
              WHERE DiscountName = @Name
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("Name", discountName));
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

        private static Discount FetchDiscount(MySqlDataReader reader)
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

        public uint Insert(Discount discount)
        {
            Discount d = Get(discount.DiscountName);
         
            if (d != null)
            {
                discount.DiscountID = d.DiscountID;
                return DoUpdate(discount);
            }
            else
                return DoInsert(discount);
        }

        public uint Update(Discount discount)
        {
            if (discount.DiscountID == 0 || Get(discount.DiscountID) == null)
                return Insert(discount);
            else
                return DoUpdate(discount);
        }
        private uint DoUpdate(Discount discount)
        {
            db.OpenConnection();
            string sqlStatement = @"
                UPDATE v_Discount
                SET DiscountName = @DiscountName, 
                    minQty = @minQty, 
                    maxQty = @maxQty, 
                    Discount = @Discount
                WHERE Discountid = @idDiscount
            ";

            try
            {
                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("idDiscount", discount.DiscountID));
                cmd.Parameters.Add(new MySqlParameter("DiscountName", discount.DiscountName));
                cmd.Parameters.Add(new MySqlParameter("minQty", discount.Min));
                cmd.Parameters.Add(new MySqlParameter("maxQty", discount.Max));
                cmd.Parameters.Add(new MySqlParameter("Discount", discount.Amount));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
            
            return discount.DiscountID;
        }

        private uint DoInsert(Discount discount)
        {
            db.OpenConnection();
            string sqlStatement = @"
                INSERT INTO v_Discount
                (DiscountName, minQty, maxQty, Discount)
                VALUES
                (@DiscountName, @minQty, @maxQty, @Discount)
            ";

            try
            {
                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("DiscountName", discount.DiscountName));
                cmd.Parameters.Add(new MySqlParameter("minQty", discount.Min));
                cmd.Parameters.Add(new MySqlParameter("maxQty", discount.Max));
                cmd.Parameters.Add(new MySqlParameter("Discount", discount.Amount));
                cmd.ExecuteNonQuery();
                return (uint)cmd.LastInsertedId;

            }
            finally
            {
                db.CloseConnnection();
            }         
        }

        public bool Update(uint discountId, int typeId)
        {
            if (Get(discountId) == null || DataAccess.Instance.InventoryType.Get(typeId) == null)
                return false;
            else
            {
                db.OpenConnection();

                try
                {
                    MySqlCommand cmd = new MySqlCommand(@"
                        REPLACE INTO discount_type
                        (discountId, typeId) 
                        VALUES
                        (@discountId, @typeId)
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
            if (Get(DiscountId) == null)
                return false;
            else
            {
                db.OpenConnection();
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
