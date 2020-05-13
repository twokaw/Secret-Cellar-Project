using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using WebApi.Models;
using MySql.Data.MySqlClient;
using System.Data;

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
        /// The function checks the database to validate whether a type already exist given the name of that type.
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>true if the type already exists</returns>
        private bool DoesTypeExist(string typeName)
        {
            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT inventory_type_name FROM inventory_type WHERE inventory_type_name = @name";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("name", typeName));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    return reader.Read();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.CloseConnnection();

            }
        }

        
        /// <summary>
        /// Get call that returns all the item types that are stored in the database.
        /// </summary>
        /// <returns>list of type objects.</returns>
        // GET: api/InventoryType
        [HttpGet]
        public IActionResult Get()
        {
            List<InventoryType> output = new List<InventoryType>();
            InventoryType outputItem;
            db.OpenConnection();
            //change to view that does sum
            string sqlStatement = "SELECT * FROM inventory_type";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {


                while (reader.Read())
                {
                    outputItem = new InventoryType();
                    outputItem.TypeID = reader.IsDBNull("typeID") ? 0 : reader.GetUInt32("typeID");
                    outputItem.TypeName = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name");
                    outputItem.DiscountDown = reader.IsDBNull("6_to_11_case_discount") ? 0.00 : reader.GetDouble("6_to_11_case_discount");
                    outputItem.DiscountUp = reader.IsDBNull("12_or_more_case_discount") ? 0.00 : reader.GetDouble("12_or_more_case_discount");
                    output.Add(outputItem);

                }
            }
            finally
            {
                reader.Close();
            }
            db.CloseConnnection();
            return Ok(output);
        }

        /// <summary>
        /// Get call that returns one item type specified by the type name. 
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns>An object of the requested type.</returns>
        // GET: api/InventoryType/typeName
        [HttpGet("{typeName}", Name = "GetType")]
        public IActionResult Get(String typeName)
        {
            InventoryType outputItem = new InventoryType();

            if (!DoesTypeExist(typeName)) return StatusCode(400, String.Format("There exists no type with the name '{0}'.", typeName));

            db.OpenConnection();
            string sqlStatement = "SELECT * FROM inventory_type WHERE inventory_type_name = @name";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("name", typeName));
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {


                while (reader.Read())
                {
                    outputItem.TypeID = reader.IsDBNull("typeID") ? 0 : reader.GetUInt32("typeID");
                    outputItem.TypeName = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name");
                    outputItem.DiscountDown = reader.IsDBNull("6_to_11_case_discount") ? 0.00 : reader.GetDouble("6_to_11_case_discount");
                    outputItem.DiscountUp = reader.IsDBNull("12_or_more_case_discount") ? 0.00 : reader.GetDouble("12_or_more_case_discount");
                }
            }
            finally
            {
                reader.Close();
            }
            db.CloseConnnection();
            return Ok(outputItem);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tester"></param>
        /// <returns></returns>
        // POST: api/InventoryType
        [HttpPost]
        public IActionResult Post([FromBody] InventoryType tester)
        {
            if (DoesTypeExist(tester.TypeName)) return StatusCode(400, "Type already exist.");

            try
            {
                db.OpenConnection();

                //Inserting into inventory_type
                string sqlStatementType = "SET SQL_MODE = '';INSERT INTO inventory_type VALUES (@typeID, @inventoryType, @discountDown, @discountUp)";
                MySqlCommand cmdType = new MySqlCommand(sqlStatementType, db.Connection());

                cmdType.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmdType.Parameters.Add(new MySqlParameter("inventoryType", tester.TypeName));
                cmdType.Parameters.Add(new MySqlParameter("discountDown", tester.DiscountDown));
                cmdType.Parameters.Add(new MySqlParameter("discountUp", tester.DiscountUp));
                MySqlDataReader reader2 = cmdType.ExecuteReader();
                reader2.Read();
                reader2.Close();

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");

            return StatusCode(201, "Type succesfully created.");
        }

        // PUT: api/InventoryType/typeName
        [HttpPut("{typeName}", Name = "PutType")]
        public IActionResult Put(String typeName, [FromBody] InventoryType tester)
        {
            try
            {
                db.OpenConnection();

                //Inserting into inventory_type
                string sqlStatementType = "UPDATE inventory_type SET typeID = @typeID, inventory_type_name = @inventoryType, 6_to_11_case_discount = @discountDown, 12_or_more_case_discount = @discountUp WHERE inventory_type_name = @name";
                MySqlCommand cmdType = new MySqlCommand(sqlStatementType, db.Connection());

                cmdType.Parameters.Add(new MySqlParameter("name", typeName));
                cmdType.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmdType.Parameters.Add(new MySqlParameter("inventoryType", tester.TypeName));
                cmdType.Parameters.Add(new MySqlParameter("discountDown", tester.DiscountDown));
                cmdType.Parameters.Add(new MySqlParameter("discountUp", tester.DiscountUp));
                MySqlDataReader reader2 = cmdType.ExecuteReader();
                reader2.Read();
                reader2.Close();

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            db.CloseConnnection();
            Console.WriteLine("\nConnection closed.");

            return Ok("Type succesfully updated.");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
