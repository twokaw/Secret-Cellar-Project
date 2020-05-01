using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Models;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        DbConn db = new DbConn();

        [HttpGet]
        public List<EmployeeModel> Get()
        {

            List<EmployeeModel> output = new List<EmployeeModel>();
            EmployeeModel outputItem = new EmployeeModel();
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM employee";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while(reader.Read())
                {
                    outputItem.EmpID = reader.IsDBNull("emp_id") ? 0 : reader.GetUInt32("emp_id");
                    outputItem.PinNumber = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number");
                    outputItem.IsAdmin = reader.IsDBNull("admin") ? false : (0 != reader.GetInt16("admin"));
                    outputItem.FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name");
                    outputItem.LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name");
                    outputItem.Email = reader.IsDBNull("email") ? "" : reader.GetString("email");
                    outputItem.Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1");
                    outputItem.Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2");
                    outputItem.City = reader.IsDBNull("city") ? "" : reader.GetString("city");
                    outputItem.State = reader.IsDBNull("state") ? "" : reader.GetString("state");
                    outputItem.ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip");
                    outputItem.PhoneNumber = reader.IsDBNull("phone") ? 0 : reader.GetUInt32("phone");
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

        // GET: api/Employee/ID
        [HttpGet("{employeeID}")]
        public IActionResult Get(String employeeID)
        {
            EmployeeModel outputItem = new EmployeeModel();
            try
            {
                db.OpenConnection();

                string sqlStatement = "SELECT * FROM employee WHERE emp_id = @empID";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("empID", employeeID));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    while (reader.Read())
                    {
                        outputItem.EmpID = reader.IsDBNull("emp_id") ? 0 : reader.GetUInt32("emp_id");
                        outputItem.PinNumber = reader.IsDBNull("pin_number") ? 0 : reader.GetUInt32("pin_number");
                        outputItem.IsAdmin = reader.IsDBNull("admin") ? false : (0 != reader.GetInt16("admin"));
                        outputItem.FirstName = reader.IsDBNull("first_name") ? "" : reader.GetString("first_name");
                        outputItem.LastName = reader.IsDBNull("last_name") ? "" : reader.GetString("last_name");
                        outputItem.Email = reader.IsDBNull("email") ? "" : reader.GetString("email");
                        outputItem.Address1 = reader.IsDBNull("addr1") ? "" : reader.GetString("addr1");
                        outputItem.Address2 = reader.IsDBNull("addr2") ? "" : reader.GetString("addr2");
                        outputItem.City = reader.IsDBNull("city") ? "" : reader.GetString("city");
                        outputItem.State = reader.IsDBNull("state") ? "" : reader.GetString("state");
                        outputItem.ZipCode = reader.IsDBNull("zip") ? "" : reader.GetString("zip");
                        outputItem.PhoneNumber = reader.IsDBNull("phone") ? 0 : reader.GetUInt32("phone");
                    }

                }
                finally
                {
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

            db.CloseConnnection();
            Console.WriteLine("\nConnection Closed.");
            return Ok(outputItem);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] Inventory tester)
        { 
        
            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sqlStatementDesc = "SET SQL_MODE = '';INSERT INTO inventory_description (name, supplierID, barcode, retail_price, description, typeID, bottle_deposit_qty, nontaxable, nontaxable_local) VALUES (@name, @supplierID, @barcode, @retailPrice, @description, @typeID, @bottleDepositQty, @nonTaxable, @nonTaxableLocal)";
                MySqlCommand cmd = new MySqlCommand(sqlStatementDesc, db.Connection());
                //cmd.Parameters.Add(new MySqlParameter("id", tester.InventoryID));
                cmd.Parameters.Add(new MySqlParameter("name", tester.Name));
                cmd.Parameters.Add(new MySqlParameter("supplierID", tester.SupplierID));
                cmd.Parameters.Add(new MySqlParameter("barcode", tester.Barcode));
                cmd.Parameters.Add(new MySqlParameter("retailPrice", tester.RetailPrice));
                cmd.Parameters.Add(new MySqlParameter("description", tester.Description));
                cmd.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmd.Parameters.Add(new MySqlParameter("bottleDepositQty", tester.BottleDepositQty));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", tester.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", tester.NonTaxableLocal));
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();

                string sqlInventoryID = "SET SQL_MODE = '';SELECT * FROM inventory_description WHERE barcode = @bar";
                MySqlCommand cmdID = new MySqlCommand(sqlInventoryID, db.Connection());
                cmdID.Parameters.Add(new MySqlParameter("bar", tester.Barcode));
                MySqlDataReader read = cmdID.ExecuteReader();
                read.Read();
                uint grabbedID = read.GetUInt32("inventoryID");
                Console.WriteLine(grabbedID);
                read.Close();

                //Inserting into inventory_price
                string sqlStatementPrice = "SET SQL_MODE = '';INSERT INTO inventory_price VALUES (@id, @inventoryQty, @supplierPrice, @purchasedDate)";
                MySqlCommand cmdPrice = new MySqlCommand(sqlStatementPrice, db.Connection());
                cmdPrice.Parameters.Add(new MySqlParameter("id", grabbedID));
                cmdPrice.Parameters.Add(new MySqlParameter("inventoryQty", tester.InventoryQty));
                cmdPrice.Parameters.Add(new MySqlParameter("supplierPrice", tester.SupplierPrice));
                cmdPrice.Parameters.Add(new MySqlParameter("purchasedDate", DateTime.Now));
                MySqlDataReader reader1 = cmdPrice.ExecuteReader();
                reader1.Read();
                reader1.Close();


                //Not needed to be created with item when a new item is added. the types will be managed on their own. The type will get selected
                //as a drop down...... so not necessary for us to manage*.. 
                //Inserting into inventory_type
                string sqlStatementType = "SET SQL_MODE = '';INSERT INTO inventory_type VALUES (@typeID, @inventoryType, @discountDown, @discountUp)";
                MySqlCommand cmdType = new MySqlCommand(sqlStatementType, db.Connection());

                cmdType.Parameters.Add(new MySqlParameter("typeID", tester.TypeID));
                cmdType.Parameters.Add(new MySqlParameter("inventoryType", tester.InventoryType));
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

            return Ok();
        }

    }
}