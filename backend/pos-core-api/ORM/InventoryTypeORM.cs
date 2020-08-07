using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;
using Shared;

namespace pos_core_api.ORM
{
    public class InventoryTypeORM
    {
        /// <summary>
        /// Initializes a new database connection to be used in this controller.
        /// </summary>
        readonly DbConn db = new DbConn();

        /// <summary>
        /// Get call that returns all the item types that are stored in the database.
        /// </summary>
        /// <returns>list of type objects.</returns>
        public List<InventoryType> Get()
        {
            List<InventoryType> types = new List<InventoryType>();

            string sqlStatement = "SELECT * FROM V_type";

            try
            {
                db.OpenConnection();
                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                using MySqlDataReader reader = cmd.ExecuteReader();
                types = FetchType(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return types;
        }

        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        public InventoryType GetID(int typeId)
        {
            List<InventoryType> types = null;

            string sqlStatement = @"
                SELECT * 
                FROM v_type 
                WHERE typeid = @id
            ";

            try
            {
                db.OpenConnection();

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("id", typeId));

                using MySqlDataReader reader = cmd.ExecuteReader();
                types = FetchType(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            if (types != null && types.Count > 0)
                return types[0];
            else
                return null;
        }

        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        public InventoryType GetName(string typeName)
        {
            List<InventoryType> types = null;

            string sqlStatement = @"
                SELECT * 
                FROM v_type 
                WHERE inventory_type_name = @name
            ";

            try
            {
                db.OpenConnection();

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("name", typeName));

                using MySqlDataReader reader = cmd.ExecuteReader();
                types = FetchType(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            if (types != null && types.Count > 0)
                return types[0];
            else
                return null;
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                db.OpenConnection();

                //Inserting into inventory_type
                string sqlStatementType = @"
                    DELETE FROM  inventory_type 
                    WHERE typeID = @typeID";

                using MySqlCommand cmdType = new MySqlCommand(sqlStatementType, db.Connection());

                cmdType.Parameters.Add(new MySqlParameter("typeID", id));

                cmdType.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        private List<InventoryType> FetchType(MySqlDataReader reader)
        {
            List<InventoryType> output = new List<InventoryType>();

            InventoryType outputItem = null;

            while (reader.Read())
            {
                outputItem = output.FirstOrDefault(x => x.TypeId == reader.GetUInt32("TypeId"));

                if (outputItem == null)
                {
                    outputItem = new InventoryType
                    {
                        TypeId = reader.GetUInt32("TypeId"),
                        TypeName = reader.GetString("inventory_type_name"),

                        IdTax = reader.IsDBNull("IdTax") ? 0 : reader.GetUInt32("idTAX"),
                        BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0.00 : reader.GetDouble("bottle_deposit"),
                        SalesTax = reader.IsDBNull("sales_tax") ? 0.00 : reader.GetDouble("sales_tax"),
                        LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0.00 : reader.GetDouble("local_sales_tax"),
                    };
                    output.Add(outputItem);
                }

                if (!reader.IsDBNull("discountID"))
                    outputItem.Discount.Add(new Discount()
                    {
                        DiscountID = reader.GetUInt32("discountID"),
                        DiscountName = reader.GetString("discountName"),
                        Min = reader.IsDBNull("minqty") ? 0 : reader.GetUInt32("minqty"),
                        Max = reader.IsDBNull("maxqty") ? 99999999 : reader.GetUInt32("maxqty"),
                        Amount = reader.GetDouble("Discount"),
                        Enabled = reader.IsDBNull("minqty") && reader.IsDBNull("maxqty")
                    });
            }
            return output;
        }

        /// The function checks the database to validate whether a type already exist given the name of that type.
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>true if the type already exists</returns>
        public int GetTypeQty(int id, string name)
        {
            try
            {
                db.OpenConnection();

                string sql = @"
                    SELECT COUNT(inventoryID) inv
                    FROM inventory_type
                    LEFT JOIN inventory_description
                    USING(typeID)
                    WHERE 1 <> 1
                    -- name -- OR   inventory_type_name = @name
                    -- typeid -- OR   typeid = @typeId
                    GROUP BY typeID
                ";

                using MySqlCommand cmd = new MySqlCommand
                {
                    Connection = db.Connection()
                };

                if (!string.IsNullOrEmpty(name))
                {
                    cmd.Parameters.Add(new MySqlParameter("name", name));
                    sql = sql.Replace("-- name --", "");
                }

                if (id > 0)
                {
                    cmd.Parameters.Add(new MySqlParameter("typeId", id));
                    sql = sql.Replace("-- typeid --", "");
                }

                cmd.CommandText = sql;

                using MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    return reader.GetInt32("inv");
                else
                    return -1;

            }
            finally { db.CloseConnnection(); }
        }
        /// <summary>
        /// Update the type's discount
        /// </summary>
        /// <param name="inv"></param>
        private void UpdateDiscount(InventoryType inv)
        {
            //Inserting into inventory_description
            string sql = @"                   
                DELETE FROM Discount_Type WHERE TypeID = @TypeID;
            ";

            MySqlCommand cmd = new MySqlCommand(sql, db.Connection());

            inv.Discount.ForEach(x => sql += @$"                   
                    INSERT INTO Discount_Type
                    (discountID, InventoryID) 
                    VALUES 
                    ({x.DiscountID}, @TypeID);
                ");

            cmd = new MySqlCommand(sql, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("TypeID", inv.TypeId));
            cmd.ExecuteNonQuery();
        }

        public uint Insert(InventoryType invType)
        {
            try
            {
                db.OpenConnection();

                //Inserting into inventory_type
                string sqlStatementType = @"
                    SET SQL_MODE = '';

                    INSERT INTO inventory_type
                    (typeID, Inventory_Type_name, idTax)
                    VALUES 
                    (@typeID, @inventoryType, @idTax)";

                using MySqlCommand cmd = new MySqlCommand(sqlStatementType, db.Connection());

                cmd.Parameters.Add(new MySqlParameter("typeID", invType.TypeId));
                cmd.Parameters.Add(new MySqlParameter("inventoryType", invType.TypeName));
                cmd.Parameters.Add(new MySqlParameter("idTax", invType.IdTax));

                cmd.ExecuteNonQuery();

                invType.TypeId = Convert.ToUInt32(cmd.LastInsertedId);
                UpdateDiscount(invType);
            }
            finally
            {
                db.CloseConnnection();
            }

            return invType.TypeId;
        }

        public void Update(InventoryType invType)
        {
            try
            {
                db.OpenConnection();

                //Inserting into inventory_type
                string sqlStatementType = @"
                    UPDATE inventory_type 
                    SET inventory_type_name = @inventoryType, 
                        idTax = @idTax
                    WHERE typeID = @typeID";

                using MySqlCommand cmdType = new MySqlCommand(sqlStatementType, db.Connection());

                cmdType.Parameters.Add(new MySqlParameter("typeID", invType.TypeId));
                cmdType.Parameters.Add(new MySqlParameter("inventoryType", invType.TypeName));
                cmdType.Parameters.Add(new MySqlParameter("idTax", invType.IdTax));

                cmdType.ExecuteNonQuery();
                UpdateDiscount(invType);
            }
            finally
            {
                db.CloseConnnection();
            }
        }
    }
}
