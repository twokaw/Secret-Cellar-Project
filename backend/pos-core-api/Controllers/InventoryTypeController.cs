using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;
using Shared;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryTypeController : ControllerBase
    {
        /// <summary>
        /// Initializes a new database connection to be used in this controller.
        /// </summary>
        DbConn db = new DbConn();
        
        /// <summary>
        /// Get call that returns all the item types that are stored in the database.
        /// </summary>
        /// <returns>list of type objects.</returns>
        // GET: api/InventoryType
        [HttpGet]
        public IActionResult Get()
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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }

            return Ok(types);
        }

        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        // GET: api/InventoryType/typeName
        [HttpGet("{typeId}", Name = "GetTypeById")]
        public IActionResult GetID(int typeId)
        {
            List<InventoryType> types = null;

            if (GetTypeQty(typeId, "") == -1)
                return StatusCode(400, $"There exists no type with the Id '{typeId}'.");

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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }

            if (types != null && types.Count > 0)
                return Ok(types[0]);
            else
                return NotFound($"{typeId} not found");
        }

        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        // GET: api/InventoryType/typeName
        [HttpGet("Name/{typeName}", Name = "GetTypeByName")]
        public IActionResult GetName(string typeName)
        {
            List<InventoryType> types = null;

            if (GetTypeQty(-1, typeName) == -1)
                return StatusCode(400, $"There exists no type with the name '{typeName}'.");

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
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                db.CloseConnnection();
            }

            if (types != null && types.Count > 0)
                return Ok(types[0]);
            else
                return NotFound($"{typeName} not found");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="invType"></param>
        /// <returns></returns>
        // POST: api/InventoryType
        [HttpPost]
        public IActionResult Post([FromBody] InventoryType invType)
        {
            if (GetTypeQty(-1, invType.TypeName) > -1) 
                return StatusCode(400, "Type already exist.");

            uint newId = 0;
            try
            {
                newId = Insert(invType);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message); 
            }

            return StatusCode(201, newId);
        }

        // PUT: api/InventoryType
        [HttpPut()]
        public IActionResult Put([FromBody] InventoryType invType)
        {
            uint newId = 0;

            // if id and name doesn't exist then call the post
            if (GetTypeQty(Convert.ToInt32(invType.TypeId), invType.TypeName) == -1)
                newId = Insert(invType);
            else
            {
                Update(invType);
                newId = invType.TypeId;
            }

            return Ok($"{newId}");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int qty = GetTypeQty(id, "");

            if(qty == -1)
                return StatusCode(400, $"No type with the id '{id}'.");
            else if (qty > 0)
                return StatusCode(400, $"Can't delete Type id '{id}'.  It has {qty} inventory items assigned to it");

            try
            {
                db.OpenConnection();

                //Inserting into inventory_type
                string sqlStatementType = @"
                    DELETE FROM  inventory_type 
                    WHERE typeID = @typeID";

                using MySqlCommand cmdType = new MySqlCommand(sqlStatementType, db.Connection());

                cmdType.Parameters.Add(new MySqlParameter("typeID",id));

                cmdType.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            db.CloseConnnection();

            return Ok("Type succesfully Deleted");
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
        private int GetTypeQty(int id, string name)
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

        private uint Insert(InventoryType invType)
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


        private void Update(InventoryType invType)
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
