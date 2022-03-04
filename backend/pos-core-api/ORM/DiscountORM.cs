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
            

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount
              FROM V_Discount
            ");

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

            db.CloseCommand(cmd);
            return output;
        }

        public Discount Get(uint discountId)
        {
            Discount outputItem = null;
            

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount 
              FROM v_Discount 
              WHERE DiscountID = @ID
            ");
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
                db.CloseCommand(cmd);
            }
            return outputItem;
        }

        public Discount Get(string discountName)
        {
            Discount outputItem = null;
            

            MySqlCommand cmd = db.CreateCommand(@"
              SELECT DiscountID, DiscountName, minQty, maxQty, Discount 
              FROM v_Discount 
              WHERE DiscountName = @Name
            ");
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
                db.CloseCommand(cmd);
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
            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE v_Discount
                SET DiscountName = @DiscountName, 
                    minQty = @minQty, 
                    maxQty = @maxQty, 
                    Discount = @Discount
                WHERE Discountid = @idDiscount
            ");
            cmd.Parameters.Add(new MySqlParameter("idDiscount", discount.DiscountID));
            cmd.Parameters.Add(new MySqlParameter("DiscountName", discount.DiscountName));
            cmd.Parameters.Add(new MySqlParameter("minQty", discount.Min));
            cmd.Parameters.Add(new MySqlParameter("maxQty", discount.Max));
            cmd.Parameters.Add(new MySqlParameter("Discount", discount.Amount));            

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
            
            return discount.DiscountID;
        }

        private uint DoInsert(Discount discount)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                INSERT INTO v_Discount
                (DiscountName, minQty, maxQty, Discount)
                VALUES
                (@DiscountName, @minQty, @maxQty, @Discount)
            ");
            cmd.Parameters.Add(new MySqlParameter("DiscountName", discount.DiscountName));
            cmd.Parameters.Add(new MySqlParameter("minQty", discount.Min));
            cmd.Parameters.Add(new MySqlParameter("maxQty", discount.Max));
            cmd.Parameters.Add(new MySqlParameter("Discount", discount.Amount));    

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

        public bool Update(uint discountId, uint typeId)
        {
            if (Get(discountId) == null || DataAccess.Instance.InventoryType.Get(typeId) == null)
                return false;
            else
            {
                MySqlCommand cmd = db.CreateCommand(@"
                    REPLACE INTO discount_type
                    (discountId, typeId) 
                    VALUES
                    (@discountId, @typeId)
                ");
                cmd.Parameters.Add(new MySqlParameter("discountId", discountId));
                cmd.Parameters.Add(new MySqlParameter("typeId", typeId));

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
        public void Delete(uint discountId, uint typeId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                DELETE FROM discount_type
                WHERE discountId = @discountId
                AND   typeId = @typeId
            ");
            cmd.Parameters.Add(new MySqlParameter("discountId", discountId));
            cmd.Parameters.Add(new MySqlParameter("typeId", typeId));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public bool Delete(uint DiscountId)
        {
            if (Get(DiscountId) == null)
                return false;
            else
            {
   
                MySqlCommand cmd = db.CreateCommand(@"
                    DELETE FROM v_Discount
                    WHERE DiscountID = @idDiscount
                ");
                cmd.Parameters.Add(new MySqlParameter("idDiscount", DiscountId));
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

    }
}
