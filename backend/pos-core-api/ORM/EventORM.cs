using MySql.Data.MySqlClient;
using Shared;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Helpers;
using System;

namespace pos_core_api.ORM
{
    public class EventORM
    {
        readonly DbConn db = new DbConn();

        /// <summary>
        /// Method that checks if the barcode already exist.
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns>True if the barcode exist.</returns>
        public bool DoesBarcodeExist(string barcode)
        {
            try
            {
                db.OpenConnection();

                string sqlStatement = @"
                  SELECT barcode 
                  FROM v_event
                  WHERE barcode = @barcode
                ";

                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("barcode", barcode));
                MySqlDataReader reader = cmd.ExecuteReader();

                try
                {
                    return reader.Read();
                }
                finally
                {
                    reader.Close();
                }
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public List<Event> GetInv()
        {
            List<Event> output = new List<Event>();
            db.OpenConnection();
            try
            {
                //change to view that does sum
                string sqlStatement = @"
                        SELECT *
                        FROM v_event 
                   ";
                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                using MySqlDataReader reader = cmd.ExecuteReader();
                output = fetchEvent(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output;
        }

        public Event GetInv(uint id)
        {
            List<Event> output = null;

            try
            {
                db.OpenConnection();

                string sqlStatement = @"
                    SELECT *
                    FROM v_event 
                    WHERE Inventorid = @id
                ";

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("id", id));
                using MySqlDataReader reader = cmd.ExecuteReader();
                output = fetchEvent(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output[0];
        }

        public Event GetInv(string barcode)
        {
            List<Event> output = null;

            try
            {
                db.OpenConnection();

                string sqlStatement = @"
                    SELECT *
                    FROM v_event 
                    WHERE barcode = @bar
                ";

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("bar", barcode));
                using MySqlDataReader reader = cmd.ExecuteReader();

                output = fetchEvent(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output[0];
        }

        public List<Event> fetchEvent(MySqlDataReader reader)
        {
            List<Event> output = new List<Event>();

            Event outputItem = null;
            while (reader.Read())
            {
                outputItem = output.FirstOrDefault(x => x.Id == reader.GetUInt32("InvetoryId"));

                if (outputItem == null)
                {
                    outputItem = new Event
                    {
                        Id = reader.IsDBNull("InvetoryId") ? 0 : reader.GetUInt32("InvetoryId"),
                        Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                        Barcode = reader.IsDBNull("barcode") ? "" : reader.GetString("barcode"),
                        Price = reader.IsDBNull("retail_price") ? 0.00 : reader.GetDouble("retail_price"),
                        Bottles = reader.IsDBNull("bottles") ? 0 : reader.GetUInt32("bottles"),
                        NonTaxable = !reader.IsDBNull("nontaxable") && (0 != reader.GetInt16("nontaxable")),
                        NonTaxableLocal = !reader.IsDBNull("nontaxable_local") && (0 != reader.GetInt16("nontaxable_local")),
                        ItemType = reader.IsDBNull("Event_type_name") ? "" : reader.GetString("Event_type_name"),
                        BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0 : reader.GetDouble("bottle_deposit"),
                        IdTax = reader.IsDBNull("idTax") ? 0 : reader.GetUInt32("idTax"),
                        SalesTax = reader.IsDBNull("sales_tax") ? 0 : reader.GetDouble("sales_tax"),
                        LocalSalesTax = reader.IsDBNull("local_sales_tax") ? 0 : reader.GetDouble("local_sales_tax"),
                        AtDoor = reader.IsDBNull("atdoor") ? 0 : reader.GetDouble("atdoor"),
                        PreOrder = reader.IsDBNull("Preorder") ? 0 : reader.GetDouble("preOrder"),
                        EventDate = reader.IsDBNull("eventDate") ? DateTime.MinValue : reader.GetDateTime("eventDate"),
                        Duration = reader.IsDBNull("duration") ? DateTime.MinValue : reader.GetDateTime("duration")

                    };
                    output.Add(outputItem);
                }

                
                outputItem.AllQty.Add(new InventoryQty()
                {
                    PurchasedDate = reader.GetDateTime("purchased_date"),
                    SupplierPrice = reader.GetDouble("Supplier_price"),
                    Qty = reader.IsDBNull("Inventory_Qty") ? 0 : reader.GetUInt32("Event_Qty")
                });
            }
            return output;
        }

    }
}
