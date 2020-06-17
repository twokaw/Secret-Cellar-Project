using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Linq.Expressions;
using Shared;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly DbConn db = new DbConn();

        // Get: api/Tax
        [HttpGet]
        public IActionResult GetTax()
        {
          List<Tax> output = new List<Tax>();
            Tax outputItem;
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM config";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    outputItem = new Tax();
                    outputItem.IdTax = reader.IsDBNull("idTAX") ? 0 : reader.GetUInt32("idTAX");
                    outputItem.BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0.0 : reader.GetDouble("bottle_deposit");
                    outputItem.SalesTax = reader.IsDBNull("sales_tax") ? 0.0 : reader.GetDouble("sales_tax");
                    outputItem.LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0.0 : reader.GetDouble("local_sales_tax");
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

        // Get: api/Tax
        [HttpGet("{taxId}")]
        public IActionResult GetTaxby(uint taxId)
        {
            Tax outputItem = GetTax(taxId);
            if (outputItem == null)
                return StatusCode(500, "TaxId is not in database");
            else
                return Ok(outputItem);
        }
        
        //Post: api/Tax
        [HttpPost()]
        public IActionResult Post([FromBody] Tax tax)
        {
            db.OpenConnection();
            long newId = -1;
            string sqlStatement = @"
                INSERT INTO config
                (bottle_deposit, sales_tax, local_sales_tax)
                VALUES
                (@bottle_deposit, @sales_tax, @local_sales_tax)
            ";
            
            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("idTAX", tax.IdTax));
                cmd.Parameters.Add(new MySqlParameter("bottle_deposit", tax.BottleDeposit));
                cmd.Parameters.Add(new MySqlParameter("sales_tax", tax.SalesTax));
                cmd.Parameters.Add(new MySqlParameter("local_sales_tax", tax.LocalSalesTax));
                cmd.ExecuteNonQuery();
                newId = cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }

            return Ok(newId);
        }

        //Put: api/Tax
        [HttpPut()]
        public IActionResult Put([FromBody] Tax tax)
        {
            db.OpenConnection();
            if (GetTax(tax.IdTax) == null)
                return Post(tax);
            else
            {
                long newId = -1;
                string sqlStatement = @"
                    UPDATE config
                        bottle_deposit = @bottle_deposit, 
                        sales_tax = @sales_tax, 
                        local_sales_tax = @local_sales_tax
                    WHERE idTAX = @idTAX
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idTAX", tax.IdTax));
                    cmd.Parameters.Add(new MySqlParameter("bottle_deposit", tax.BottleDeposit));
                    cmd.Parameters.Add(new MySqlParameter("sales_tax", tax.SalesTax));
                    cmd.Parameters.Add(new MySqlParameter("local_sales_tax", tax.LocalSalesTax));
                    cmd.ExecuteNonQuery();
                    newId = cmd.LastInsertedId;
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return Ok(tax.IdTax);
        }

        //Put: api/Tax
        [HttpDelete("{taxId}")]
        public IActionResult Delete(uint taxId)
        {
            db.OpenConnection();
            if (GetTax(taxId) == null)
                return Ok("Tax info does not exist in database");
            else
            {
                string sqlStatement = @"
                    DELETE FROM config
                    WHERE idTAX = @idTAX
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idTAX", taxId));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return Ok("Tax Id deleted");
        }

        // Get: api/Tax
        private Tax GetTax(uint taxId)
        {
            Tax outputItem = null;
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM config WHERE idTax = @ID";


            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("ID", taxId));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    outputItem = new Tax
                    {
                        IdTax = reader.IsDBNull("idTAX") ? 0 : reader.GetUInt32("idTAX"),
                        BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0.0 : reader.GetDouble("bottle_deposit"),
                        SalesTax = reader.IsDBNull("sales_tax") ? 0.0 : reader.GetDouble("sales_tax"),
                        LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0.0 : reader.GetDouble("local_sales_tax")
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