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
                        Max = reader.IsDBNull("maxQty") ? 0 : reader.GetUInt32("maxQty")
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

            string sqlStatement = @"
                DELETE FROM discount_type
                WHERE discountId = @discountId
                AND   typeId = @typeId
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
                        Max = reader.IsDBNull("maxQty") ? 0 : reader.GetUInt32("maxQty")
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
