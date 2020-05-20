using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Helpers;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using Shared;
using System.CodeDom;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        DbConn db = new DbConn();

        // Gets list of all transactions within date period. Format: YYYY-MM-DD HH:MM:SS
        // GET: api/Transaction/
        [HttpGet]
        public List<Transaction> Get(DateTime date1, DateTime date2)
        {

            List<Transaction> output = new List<Transaction>();
            Transaction outputItem;
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM transaction WHERE sold_datetime BETWEEN @date1 AND @date2";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("date1", date1));
            cmd.Parameters.Add(new MySqlParameter("date2", date2));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    DateTime aDate = new DateTime();
                    // output item will be a list of all transactions containing a list of all items associated w/ each transaction
                    outputItem = new Transaction();
                    // outputItems are retrieved from transaction table
                    outputItem.InvoiceID = reader.IsDBNull("receiptID") ? 0 : reader.GetUInt32("receiptID");
                    outputItem.RegisterID = reader.IsDBNull("register") ? 0 : reader.GetUInt32("register");
                    outputItem.TransactionDateTime = reader.IsDBNull("sold_datetime") ? aDate : reader.GetDateTime("sold_datetime");
                    outputItem.Location = reader.IsDBNull("location") ? "" : reader.GetString("location");
                    outputItem.Subtotal = reader.IsDBNull("subtotal") ? 0 : reader.GetDouble("subtotal");
                    outputItem.Tax = reader.IsDBNull("tax") ? 0 : reader.GetDouble("tax");
                    outputItem.Total = reader.IsDBNull("total") ? 0 : reader.GetDouble("total");
                    outputItem.TaxExempt = reader.IsDBNull("tax_exempt") ? false : reader.GetBoolean("tax_exempt");
                    outputItem.PayMethod = reader.IsDBNull("payment_methods") ? "" : reader.GetString("payment_methods");
                    outputItem.PayNum = reader.IsDBNull("paymentID") ? "" : reader.GetString("paymentID");
                    outputItem.Discount = reader.IsDBNull("discount") ? 0.0 : reader.GetDouble("discount");

                    output.Add(outputItem);

                }
            }
            finally
            {
                reader.Close();
            }

            foreach (Transaction transaction in output)
            {
                // Grabbing list of all items, to fill sublist of transaction
                List<Item> itemOutput = new List<Item>();
                Item itemOut;
                string itemSQLStatement =
                    "SELECT id.Id, id.name, id.barcode, id.nontaxable, id.bottle_deposit_qty, id.typeID, " +
                           "ti.receiptID, ti.sold_qty, ti.sold_price, ti.discount, ti.coupon, inventory_type_name, " +
                           "inventory_qty " +
                    "FROM transaction_items ti " +
                    "JOIN inventory_description id ON ti.Id = id.Id " +
                    "JOIN inventory_price ip ON id.Id = ip.Id " +
                    "JOIN inventory_type it ON it.typeID = id.typeID " +
                    "WHERE receiptID = 1";

                MySqlCommand itemCmd = new MySqlCommand(itemSQLStatement, db.Connection());
                itemCmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));
                MySqlDataReader itemReader = itemCmd.ExecuteReader();
                try
                {
                    while (itemReader.Read())
                    {
                        itemOut = new Item(
                            // from inventory_description
                            itemReader.IsDBNull("name") ? "" : itemReader.GetString("name"),
                            // from inventory_description
                            itemReader.IsDBNull("Id") ? 0 : itemReader.GetUInt32("Id"),
                            // from inventory_description
                            itemReader.IsDBNull("barcode") ? "" : itemReader.GetString("barcode"),
                            // from inventory_price
                            itemReader.IsDBNull("inventory_qty") ? 0 : itemReader.GetUInt32("inventory_qty"),
                            // from transaction_items
                            itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty"),
                            // from transaction_items
                            itemReader.IsDBNull("sold_price") ? 0.0 : itemReader.GetDouble("sold_price"),
                            // from inventory_description 
                            itemReader.IsDBNull("nontaxable") ? false : itemReader.GetBoolean("nontaxable"),
                            // from inventory_type
                            itemReader.IsDBNull("inventory_type_name") ? "" : itemReader.GetString("inventory_type_name"),
                            // from inventory_descripion
                            itemReader.IsDBNull("bottle_deposit_qty") ? 0 : itemReader.GetUInt32("bottle_deposit_qty"),
                            // from transaction_items
                            itemReader.IsDBNull("discount") ? 0.0 : itemReader.GetDouble("discount"),
                            // from transaction_items
                            itemReader.IsDBNull("coupon") ? 0.0 : itemReader.GetDouble("coupon")
                            );
                        itemOutput.Add(itemOut);
                    }
                }
                finally
                {
                    itemReader.Close();

                }
                db.CloseConnnection();

                transaction.Items = itemOutput;

            }
            return output;
        }

        // Get call to be used when barcode on receipt is scanned
        //Get: api/Transaction/receiptID
        [HttpGet("{receiptID}")]
        public List<Transaction> Get(uint receiptID)
        {

            List<Transaction> output = new List<Transaction>();
            Transaction outputItem;
            db.OpenConnection();

            string sqlStatement = "SELECT * FROM transaction WHERE receiptID = @receiptID";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            cmd.Parameters.Add(new MySqlParameter("receiptID", receiptID));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    DateTime aDate = new DateTime();
                    // output item will be a list of all tranactions containing a list of all items associated w/ each transaction
                    outputItem = new Transaction();
                    // outputItems are retrieved from transaction table
                    outputItem.InvoiceID = reader.IsDBNull("receiptID") ? 0 : reader.GetUInt32("receiptID");
                    outputItem.RegisterID = reader.IsDBNull("register") ? 0 : reader.GetUInt32("register");
                    outputItem.TransactionDateTime = reader.IsDBNull("sold_datetime") ? aDate : reader.GetDateTime("sold_datetime");
                    outputItem.Location = reader.IsDBNull("location") ? "" : reader.GetString("location");
                    outputItem.Subtotal = reader.IsDBNull("subtotal") ? 0 : reader.GetDouble("subtotal");
                    outputItem.Tax = reader.IsDBNull("tax") ? 0 : reader.GetDouble("tax");
                    outputItem.Total = reader.IsDBNull("total") ? 0 : reader.GetDouble("total");
                    outputItem.TaxExempt = reader.IsDBNull("tax_exempt") ? false : reader.GetBoolean("tax_exempt");
                    outputItem.PayMethod = reader.IsDBNull("payment_methods") ? "" : reader.GetString("payment_methods");
                    outputItem.PayNum = reader.IsDBNull("paymentID") ? "" : reader.GetString("paymentID");
                    outputItem.Discount = reader.IsDBNull("discount") ? 0.0 : reader.GetDouble("discount");

                    output.Add(outputItem);

                }
            }
            finally
            {
                reader.Close();
            }

            foreach (Transaction transaction in output)
            {
                // Grabbing list of all items, to fill sublist of transaction
                List<Item> itemOutput = new List<Item>();
                Item itemOut;
                string itemSQLStatement =
                    "SELECT id.Id, id.name, id.barcode, id.nontaxable, id.bottle_deposit_qty, id.typeID, " +
                           "ti.receiptID, ti.sold_qty, ti.sold_price, ti.discount, ti.coupon, inventory_type_name, " +
                           "inventory_qty " +
                    "FROM transaction_items ti " +
                    "JOIN inventory_description id ON ti.Id = id.Id " +
                    "JOIN inventory_price ip ON id.Id = ip.Id " +
                    "JOIN inventory_type it ON it.typeID = id.typeID " +
                    "WHERE receiptID = 1";

                MySqlCommand itemCmd = new MySqlCommand(itemSQLStatement, db.Connection());
                itemCmd.Parameters.Add(new MySqlParameter("receiptID", transaction.InvoiceID));
                MySqlDataReader itemReader = itemCmd.ExecuteReader();
                try
                {
                    while (itemReader.Read())
                    {
                        itemOut = new Item(
                            // from inventory_description
                            itemReader.IsDBNull("name") ? "" : itemReader.GetString("name"),
                            // from inventory_description
                            itemReader.IsDBNull("Id") ? 0 : itemReader.GetUInt32("Id"),
                            // from inventory_description
                            itemReader.IsDBNull("barcode") ? "" : itemReader.GetString("barcode"),
                            // from inventory_price
                            itemReader.IsDBNull("inventory_qty") ? 0 : itemReader.GetUInt32("inventory_qty"),
                            // from transaction_items
                            itemReader.IsDBNull("sold_qty") ? 0 : itemReader.GetUInt32("sold_qty"),
                            // from transaction_items
                            itemReader.IsDBNull("sold_price") ? 0.0 : itemReader.GetDouble("sold_price"),
                            // from inventory_description 
                            itemReader.IsDBNull("nontaxable") ? false : itemReader.GetBoolean("nontaxable"),
                            // from inventory_type
                            itemReader.IsDBNull("inventory_type_name") ? "" : itemReader.GetString("inventory_type_name"),
                            // from inventory_descripion
                            itemReader.IsDBNull("bottle_deposit_qty") ? 0 : itemReader.GetUInt32("bottle_deposit_qty"),
                            // from transaction_items
                            itemReader.IsDBNull("discount") ? 0.0 : itemReader.GetDouble("discount"),
                            // from transaction_items
                            itemReader.IsDBNull("coupon") ? 0.0 : itemReader.GetDouble("coupon")
                            );
                        itemOutput.Add(itemOut);
                    }
                }
                finally
                {
                    itemReader.Close();

                }
                db.CloseConnnection();

                transaction.Items = itemOutput;

            }
            return output;
        }
    
    }
}
