using MySql.Data.MySqlClient;
using Shared;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using WebApi.Helpers;
using System;

namespace pos_core_api.ORM
{
    public class EventORM
    {
        private readonly InventoryORM Inv;
        private readonly TaxORM Tax;
        private readonly InventoryTypeORM InvType;
        public EventORM(InventoryORM invORM, TaxORM taxORM, InventoryTypeORM invTypeORM)
        {
            Inv = invORM;
            Tax = taxORM;
            InvType = invTypeORM ;
        }

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

        public List<Event> Get()
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
                output = FetchEvent(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output;
        }

        public Event Get(uint id)
        {
            List<Event> output = null;

            try
            {
                db.OpenConnection();

                string sqlStatement = @"
                    SELECT *
                    FROM v_event 
                    WHERE Inventoryid = @id
                ";

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("id", id));
                using MySqlDataReader reader = cmd.ExecuteReader();
                output = FetchEvent(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output[0];
        }

        public Event Get(string barcode)
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

                output = FetchEvent(reader);
            }
            finally
            {
                db.CloseConnnection();
            }

            return output[0];
        }

        public long Insert(Event evnt)
        {
            if (DoesBarcodeExist(evnt.Barcode))
                throw new Exception("Barcode already exist.");

            if (evnt.TypeID == 0)
            {
                InventoryType it = InvType.Get("EVENT");
                evnt.TypeID = it.TypeId;

                if (evnt.IdTax == 0)
                    evnt.IdTax = it.IdTax;
            }

            if (evnt.IdTax == 0)
                evnt.IdTax = Tax.Get("Event")?.IdTax ?? 1;

            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                 string sql = @"
                    INSERT INTO inventory_description 
                    (name, barcode, retail_price, typeID, nontaxable, nontaxable_local) 
                    VALUES 
                    (@name, @barcode, @Price, @typeID, @nonTaxable, @nonTaxableLocal);
                ";

                if (string.IsNullOrWhiteSpace(evnt.Barcode))
                    evnt.Barcode = evnt.Name.Replace(" ", "").ToUpper();
                else
                    evnt.Barcode = evnt.Barcode.Replace(" ", "").ToUpper();

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());

                //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("name", evnt.Name.Trim()));
                cmd.Parameters.Add(new MySqlParameter("barcode", evnt.Barcode.Trim().ToUpper()));
                cmd.Parameters.Add(new MySqlParameter("Price", evnt.Price));
                cmd.Parameters.Add(new MySqlParameter("typeID", evnt.TypeID));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", evnt.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", evnt.NonTaxableLocal));
                cmd.ExecuteNonQuery();

                evnt.Id = Convert.ToUInt32(cmd.LastInsertedId);
                cmd.Dispose();

                //Inserting into inventory_description
                sql = @"
                    INSERT INTO inventory_price 
                    (InventoryID, Inventory_Qty, Supplier_price) 
                    VALUES 
                    (@id, @qty, @supplier_price);

                    INSERT INTO events 
                    ( inventoryID,  eventDate,  Duration,  preorder,  atDoor) 
                    VALUES 
                    (@inventoryID, @eventDate, @Duration, @preorder, @atDoor);
                ";

                cmd = new MySqlCommand(sql, db.Connection());
                //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("id", evnt.Id));
                cmd.Parameters.Add(new MySqlParameter("Qty", evnt.Qty));
                cmd.Parameters.Add(new MySqlParameter("Supplier_price", evnt.SupplierPrice));
                cmd.Parameters.Add(new MySqlParameter("inventoryID", evnt.Id));
                cmd.Parameters.Add(new MySqlParameter("eventDate", evnt.EventDate));
                cmd.Parameters.Add(new MySqlParameter("Duration", evnt.Duration));
                cmd.Parameters.Add(new MySqlParameter("preorder", evnt.PreOrder));
                cmd.Parameters.Add(new MySqlParameter("atDoor", evnt.AtDoor));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            finally
            {
                db.CloseConnnection();
            }

            return evnt.Id;
        }


        public long Update(Event evnt)
        {
            if (evnt.TypeID == 0)
            {
                InventoryType it = InvType.Get("EVENT");
                evnt.TypeID = it.TypeId;

                if (evnt.IdTax == 0)
                    evnt.IdTax = it.IdTax;
            }

            if (evnt.IdTax == 0)
                evnt.IdTax = Tax.Get("Event")?.IdTax ?? 1;

            try
            {
                db.OpenConnection();

                //Inserting into inventory_description
                string sql = @"
                   UPDATE inventory_description 
                   SET    name    = @name, 
                          barcode = @barcode, 
                          retail_price = @Price, 
                          typeID = @typeID, 
                          nontaxable = @nonTaxable, 
                          nontaxable_local = @nonTaxableLocal
                    WHERE inventoryid = @id;
                ";

                if (string.IsNullOrWhiteSpace(evnt.Barcode))
                    evnt.Barcode = evnt.Name.Replace(" ", "").ToUpper();
                else
                    evnt.Barcode = evnt.Barcode.Replace(" ", "").ToUpper();

                MySqlCommand cmd = new MySqlCommand(sql, db.Connection());

                //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("id", evnt.Id));
                cmd.Parameters.Add(new MySqlParameter("name", evnt.Name.Trim()));
                cmd.Parameters.Add(new MySqlParameter("barcode", evnt.Barcode.Trim().ToUpper()));
                cmd.Parameters.Add(new MySqlParameter("Price", evnt.Price));
                cmd.Parameters.Add(new MySqlParameter("typeID", evnt.TypeID));
                cmd.Parameters.Add(new MySqlParameter("nonTaxable", evnt.NonTaxable));
                cmd.Parameters.Add(new MySqlParameter("nonTaxableLocal", evnt.NonTaxableLocal));
                cmd.ExecuteNonQuery();

                cmd.Dispose();

                //Inserting into inventory_description Changed to insert or update
                sql = @"
                    UPDATE inventory_price 
                    SET Inventory_Qty = @qty, 
                        Supplier_price = @supplier_price
                    WHERE inventoryID = @id;
                ";
                /*
                foreach (var i in evnt.AllQty)
                {
                    cmd = new MySqlCommand(sql, db.Connection());
                    //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                    cmd.Parameters.Add(new MySqlParameter("id", evnt.Id));
                    cmd.Parameters.Add(new MySqlParameter("Qty", i.Qty));
                    cmd.Parameters.Add(new MySqlParameter("Supplier_price", evnt.SupplierPrice));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                */
                    cmd = new MySqlCommand(sql, db.Connection());
                    //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                    cmd.Parameters.Add(new MySqlParameter("id", evnt.Id));
                    cmd.Parameters.Add(new MySqlParameter("Qty", evnt.AllQty.Sum(x=>x.Qty)));
                    cmd.Parameters.Add(new MySqlParameter("Supplier_price", evnt.AllQty.Max(x => x.SupplierPrice)));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                

                //Inserting into events
                cmd = new MySqlCommand(@"
                    UPDATE events 
                    SET eventDate = @eventDate,  
                        Duration = @Duration,  
                        preorder = @preorder,  
                        atDoor = @atDoor
                    WHERE inventoryID = @id;
                ", db.Connection());

                //cmd.Parameters.Add(new MySqlParameter("id", inv.Id));
                cmd.Parameters.Add(new MySqlParameter("ID", evnt.Id));
                cmd.Parameters.Add(new MySqlParameter("eventDate", evnt.EventDate));
                cmd.Parameters.Add(new MySqlParameter("Duration", evnt.Duration));
                cmd.Parameters.Add(new MySqlParameter("preorder", evnt.PreOrder));
                cmd.Parameters.Add(new MySqlParameter("atDoor", evnt.AtDoor));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }

            return evnt.Id;
        }

        public Inventory EventToInv(Event evnt)
        {
            if (evnt.TypeID == 0)
            { 
                InventoryType it = InvType.Get("EVENT");
                evnt.TypeID = it.TypeId;

                if (evnt.IdTax == 0)
                    evnt.IdTax = it.IdTax;
            }

            if (evnt.IdTax == 0)
                evnt.IdTax = Tax.Get("Event")?.IdTax ?? 1;

            return new Inventory
            {
                Barcode = evnt.Barcode,
                Name = evnt.Name,
                Id = evnt.Id,
                IdTax = evnt.IdTax,
                NonTaxable = evnt.NonTaxable,
                NonTaxableLocal = evnt.NonTaxableLocal,
                SalesTax = evnt.SalesTax,
                Price = evnt.Price,
                TypeID = evnt.TypeID,
                LocalSalesTax = evnt.LocalSalesTax
            };
        }


        private List<Event> FetchEvent(MySqlDataReader reader)
        {
            List<Event> output = new List<Event>();

            Event outputItem = null;
            while (reader.Read())
            {
                uint id = reader.GetUInt32("InventoryId");
                outputItem = output.FirstOrDefault(x => x.Id == id);

                if (outputItem == null)
                {
                    outputItem = new Event
                    {
                        Id = id,
                        Name = reader.IsDBNull("name") ? "" : reader.GetString("name"),
                        Barcode = reader.IsDBNull("barcode") ? "" : reader.GetString("barcode"),
                        Price = reader.IsDBNull("retail_price") ? 0.00 : reader.GetDouble("retail_price"),
                        NonTaxable = !reader.IsDBNull("nontaxable") && (0 != reader.GetInt16("nontaxable")),
                        NonTaxableLocal = !reader.IsDBNull("nontaxable_local") && (0 != reader.GetInt16("nontaxable_local")),
                        ItemType = reader.IsDBNull("inventory_type_name") ? "" : reader.GetString("inventory_type_name"),
                        IdTax = reader.IsDBNull("idTax") ? 0 : reader.GetUInt32("idTax"),
                        TaxName  = reader.IsDBNull("Tax_Name") ? "" : reader.GetString("Tax_Name"),
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
                    Qty = reader.IsDBNull("Inventory_Qty") ? 0 : reader.GetUInt32("Inventory_Qty")
                });
            }
            return output;
        }

        public void Delete(uint invId)
        {
            Inv.Delete(invId);
        }

        public List<EventWaitlistItem> GetEventsWaitlists() {
            List<EventWaitlistItem> output = new List<EventWaitlistItem>();

            try {
                db.OpenConnection();

                string sqlStatement = @"
                    SELECT *
                    FROM event_waitlist
                ";

                using MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                using MySqlDataReader reader = cmd.ExecuteReader();
                EventWaitlistItem outputItem = null;
                
                while (reader.Read()) {
                    int id = reader.GetInt32("eventId");

                    outputItem = new EventWaitlistItem {
                        EventId = id,
                        CustomerId = reader.IsDBNull("customerId") ? -1 : reader.GetInt32("customerId"),
                        CustomerName = reader.IsDBNull("customerName") ? "" : reader.GetString("customerName"),
                        DateAdded = reader.IsDBNull("dateAdded") ? DateTime.MinValue : reader.GetDateTime("dateAdded")
                    };

                    output.Add(outputItem);

                }
            } finally {
                db.CloseConnnection();
            }

            return output;
        }
    }
}
