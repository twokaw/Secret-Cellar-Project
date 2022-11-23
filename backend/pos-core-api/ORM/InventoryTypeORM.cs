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
        readonly DbConn db = new();


        /// <summary>
        /// Get call that returns all the item types that are stored in the database.
        /// </summary>
        /// <returns>list of type objects.</returns>
        public List<InventoryType> Get()
        {
            List<InventoryType> types = new();
            MySqlCommand cmd = db.CreateCommand("SELECT * FROM V_type");

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                types = FetchType(reader);
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            return types;
        }


        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        public InventoryType Get(uint typeId)
        {
            List<InventoryType> types = null;

            using MySqlCommand cmd = db.CreateCommand(@"
                SELECT * 
                FROM v_type 
                WHERE typeid = @id
            ");
            cmd.Parameters.Add(new MySqlParameter("id", typeId));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                types = FetchType(reader);
            }
            finally
            {
                db.CloseCommand(cmd);
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
        public InventoryType Get(string typeName)
        {
            List<InventoryType> types = null;

            MySqlCommand cmd = db.CreateCommand(@"
                SELECT * 
                FROM v_type 
                WHERE inventory_type_name = @name
            ");
            cmd.Parameters.Add(new MySqlParameter("name", typeName));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                types = FetchType(reader);
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            if (types != null && types.Count > 0)
                return types[0];
            else
                return null;
        }


        /// <summary>
        /// Deletes the inventory type with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE: api/InventoryType/Delete/5
        public bool Delete(uint id)
        {
            if (Get(id) == null) { return false; }

            MySqlCommand cmd = db.CreateCommand(@"
                DELETE FROM inventory_type 
                WHERE typeID = @typeID
            ");

            cmd.Parameters.Add(new MySqlParameter("typeID", id));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            return true;
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
                        TaxName = reader.IsDBNull("Tax_name") ? "" : reader.GetString("tax_name"),
                        IdTax = reader.IsDBNull("IdTax") ? 0 : reader.GetUInt32("idTAX"),
                        Bottles = reader.IsDBNull("bottles") ? 0 : reader.GetUInt32("bottles"),
                        Min_qty = reader.IsDBNull("min_qty") ? 0 : reader.GetUInt32("min_qty"),
                        Max_qty = reader.IsDBNull("max_qty") ? 0 : reader.GetUInt32("max_qty"),
                        OrderIncrement = reader.IsDBNull("Increment_qty") ? 0 : reader.GetUInt32("Increment_qty"),
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

        /// <summary>
        /// The function checks the database to validate whether a type already exist given the name of that type.
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>-1 if there is no type found otherwise returns the quantity of the inventory type</returns>
        public int GetTypeQty(bool shouldUseId, uint id, string name)
        {
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

            MySqlCommand cmd = db.CreateCommand();

            if (!string.IsNullOrEmpty(name))
            {
                cmd.Parameters.Add(new MySqlParameter("name", name));
                sql = sql.Replace("-- name --", "");
            }

            if (shouldUseId)
            {
                cmd.Parameters.Add(new MySqlParameter("typeId", id));
                sql = sql.Replace("-- typeid --", "");
            }

            cmd.CommandText = sql;
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                    return reader.GetInt32("inv");
                else
                    return -1;
            }
            finally { db.CloseCommand(cmd); }
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

            inv.Discount.ForEach(x => sql += @$"                   
                    INSERT INTO Discount_Type
                    (discountID, typeID) 
                    VALUES 
                    ({x.DiscountID}, @TypeID);
                ");

            MySqlCommand cmd = db.CreateCommand(sql);
            cmd.Parameters.Add(new MySqlParameter("TypeID", inv.TypeId));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }


        public uint Insert(InventoryType invType)
        {
            using MySqlCommand cmd = db.CreateCommand(@"
                SET SQL_MODE = '';

                INSERT INTO inventory_type
                ( typeID, Inventory_Type_name, idTax, min_qty, max_qty, Increment_Qty)
                VALUES 
                (@typeID,@Inventory_Type_name,@idTax,@min_qty,@max_qty,@Increment_Qty)
            ");

            cmd.Parameters.Add(new MySqlParameter("typeID", invType.TypeId));
            cmd.Parameters.Add(new MySqlParameter("Inventory_Type_name", invType.TypeName));
            cmd.Parameters.Add(new MySqlParameter("Bottles", invType.Bottles));
            cmd.Parameters.Add(new MySqlParameter("Min_qty", invType.Min_qty));
            cmd.Parameters.Add(new MySqlParameter("Max_Qty", invType.Max_qty));
            cmd.Parameters.Add(new MySqlParameter("Increment_Qty", invType.OrderIncrement));
            cmd.Parameters.Add(new MySqlParameter("idTax", invType.IdTax));

            try
            {
                cmd.ExecuteNonQuery();

                invType.TypeId = Convert.ToUInt32(cmd.LastInsertedId);
                UpdateDiscount(invType);
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            return invType.TypeId;
        }


        public void Update(InventoryType invType)
        { 
            //Inserting into inventory_type

            MySqlCommand cmd = db.CreateCommand(@"
                UPDATE inventory_type 
                SET inventory_type_name = @inventoryType, 
                    idTax = @idTax, 
                    bottles = @Bottles,
                    min_qty = @min_qty,
                    max_qty = @max_qty,
                    Increment_Qty = @Increment_Qty
                WHERE typeID = @typeID");

            cmd.Parameters.Add(new MySqlParameter("typeID", invType.TypeId));
            cmd.Parameters.Add(new MySqlParameter("inventoryType", invType.TypeName));
            cmd.Parameters.Add(new MySqlParameter("Bottles", invType.Bottles));
            cmd.Parameters.Add(new MySqlParameter("Min_qty", invType.Min_qty));
            cmd.Parameters.Add(new MySqlParameter("Max_Qty", invType.Max_qty));
            cmd.Parameters.Add(new MySqlParameter("Increment_Qty", invType.OrderIncrement));
            cmd.Parameters.Add(new MySqlParameter("idTax", invType.IdTax));

            try
            {
                cmd.ExecuteNonQuery();
                UpdateDiscount(invType);
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }
    }
}
