using MySql.Data.MySqlClient;
using Shared;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class PrinterORM
    {
        private readonly DbConn db = new DbConn();

        public List<Printer> Get()
        {
            List<Printer> output = new List<Printer>();
            Printer outputItem = null;
            MySqlDataReader reader = null;
            try
            {
                db.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(@"
                 SELECT *
                 FROM v_printer
                ", db.Connection());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if(outputItem == null || outputItem.ModelId != reader.GetUInt32("Modelid"))
                    {
                        outputItem = new Printer
                        {
                            MakeId = reader.IsDBNull("MakeID") ? 0 : reader.GetUInt32("MakeID"),
                            ModelId = reader.IsDBNull("Modelid") ? 0 : reader.GetUInt32("Modelid"),
                            Make = reader.IsDBNull("MakeName") ? "" : reader.GetString("MakeName"),
                            Model = reader.IsDBNull("ModelName") ? "" : reader.GetString("ModelName")
                        };
                        output.Add(outputItem);  
                    }

                    outputItem.Codes.Add(new PrinterCode
                    {
                        CodeId = reader.IsDBNull("Codeid") ? 0 : reader.GetUInt32("codeid"),
                        Drawer = reader.IsDBNull("Drawer") ? "" : reader.GetString("Drawer"),
                        Cutter = reader.IsDBNull("Cutter") ? "" : reader.GetString("Cutter"),
                        PartialCutter = reader.IsDBNull("PartialCutter") ? "" : reader.GetString("PartialCutter")
                    });
                }  
            }
            finally
            {
                reader?.Close();
                db.CloseConnnection();
            }
            return output;
        }

        private uint Get(string make, string model)
        {
            uint result = 0;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT modelId 
              FROM v_printer 
              WHERE UPPER(makeName) = UPPER(@make)
              AND  UPPER(modelName) = UPPER(@Model)
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("make", make));
            cmd.Parameters.Add(new MySqlParameter("Model", model));

            using (MySqlDataReader reader = cmd.ExecuteReader())
                if (reader.Read())
                    result = uint.Parse(reader["ModelID"].ToString());

            return result;
        }

            public Printer Get(uint PrinterId)
        {
            Printer outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT * 
              FROM v_printer 
              WHERE Modelid = @Id
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("Id", PrinterId));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while(reader.Read())
                {
                    if(outputItem == null)
                        outputItem = new Printer
                        {
                            MakeId = reader.IsDBNull("MakeID") ? 0 : reader.GetUInt32("MakeID"),
                            ModelId = reader.IsDBNull("Modelid") ? 0 : reader.GetUInt32("Modelid"),
                            Make = reader.IsDBNull("MakeName") ? "" : reader.GetString("MakeName"),
                            Model = reader.IsDBNull("ModelName") ? "" : reader.GetString("ModelName")
                        };

                    outputItem.Codes.Add(new PrinterCode
                    {
                        CodeId = reader.IsDBNull("Codeid") ? 0 : reader.GetUInt32("codeid"),
                        Drawer = reader.IsDBNull("Drawer") ? "" : reader.GetString("Drawer"),
                        Cutter = reader.IsDBNull("Cutter") ? "" : reader.GetString("Cutter"),
                        PartialCutter = reader.IsDBNull("PartialCutter") ? "" : reader.GetString("PartialCutter")
                    });
                }
            }
            finally
            {
                reader.Close();
                db.CloseConnnection();
            }
            return outputItem;
        }

        public uint Insert (Printer printer)
        {
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(@"
                    -- Add the printer Make, if it doesn't exist
                    INSERT IGNORE INTO printerMake
                    (printerMakeName) 
                    VALUES
                    (@Make);                

                    -- Add the printer Model, if it doesn't exist
                    INSERT IGNORE INTO printerModel
                    (printerModelName, printerMakeID ) 
                    SELECT @Model, printerMakeID 
                    FROM   printerMake 
                    WHERE  printerMakeName = @Make;
                ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("Make", printer.Make));
                cmd.Parameters.Add(new MySqlParameter("Model", printer.Model));
                cmd.ExecuteNonQuery();

                printer.ModelId = (uint)cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }
            UpdateCodes(printer);

            return printer.ModelId;
        }

        public string GetMake(uint makeId)
        {
            MySqlDataReader reader = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(@"
                    SELECT  PrinterMakeName
                    FROM PrinterMake
                    WHERE printermakeid = @makeid
                ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("makeid", makeId));
                reader = cmd.ExecuteReader();

                if (reader.Read())
                    return reader.IsDBNull("PrinterMakeName") ? "" : reader.GetString("PrinterMakeName");
            }
            finally
            {
                reader?.Close();
                db.CloseConnnection();
            }
            return "";
        }

        public List<string> GetMake()
        {
            List<string> result = new List<string>();
            MySqlDataReader reader = null;
            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(@"
                 SELECT  PrinterMakeName
                 FROM PrinterMake
                ", db.Connection());

                reader = cmd.ExecuteReader();

                while (reader.Read())
                    if(!reader.IsDBNull("PrinterMakeName") && !string.IsNullOrWhiteSpace(reader.GetString("PrinterMakeName")))
                        result.Add( reader.GetString("PrinterMakeName"));
            }
            finally
            {
                reader?.Close();
                db.CloseConnnection();
            }
            return result;
        }

        public void UpdateCodes(Printer printer)
        {
            try
            {
                db.OpenConnection();
                MySqlCommand cmd;
                string CodeIds = "";

                string sqlStatement = @"
                    -- Add the printer Model, if it doesn't exist
                    INSERT IGNORE INTO Printercode
                    (Drawer, Cutter, PartialCutter) 
                    VALUES
                    (@Drawer, @Cutter, @PartialCutter);

                    INSERT IGNORE INTO printerModelCode
                    (printerModelID, printercodeid)

                    SELECT @ModelID,  Printercodeid
                    FROM Printercode
                    WHERE Drawer = @Drawer
                    AND   Cutter = @Cutter
                    AND   PartialCutter = @PartialCutter;

                    SELECT  Printercodeid
                    FROM Printercode
                    WHERE Drawer = @Drawer
                    AND   Cutter = @Cutter
                    AND   PartialCutter = @PartialCutter;
                ";

                foreach (PrinterCode pc in printer.Codes)
                {
                    cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                    cmd.Parameters.Add(new MySqlParameter("Drawer", $"{pc.Drawer}"));
                    cmd.Parameters.Add(new MySqlParameter("Cutter", $"{pc.Cutter}"));
                    cmd.Parameters.Add(new MySqlParameter("PartialCutter", $"{pc.PartialCutter}"));
                   
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                        CodeIds += $"{(reader.IsDBNull("printercodeid") ? 0 : reader.GetUInt32("printercodeid"))},";

                    reader.Close();
                }
                CodeIds = CodeIds.Trim(',');

                cmd = new MySqlCommand(@$"
                        DELETE FROM printerModelcode
                        WHERE printerModelID = @ModelID
                        {(string.IsNullOrWhiteSpace(CodeIds) ? "" : $"AND NOT printerCodeid IN ({CodeIds})")};
                    ", db.Connection());

                cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public uint Update( Printer printer)
        {
            // return 0 if the printer is null
            if (printer != null)
                return 0;

            // if the printer model id is missing try to find it
            if (printer.ModelId == 0)
                printer.ModelId = Get(printer.Make, printer.Model);

            if (printer.ModelId == 0 || Get(printer.ModelId) == null)
                Insert(printer);
            else
            {
                try
                {
                    db.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand(@"
                    -- Add the printer Make, if it doesn't exist
                    INSERT IGNORE INTO printerMake
                    (printerMakeName) 
                    VALUES
                    (@Make);                

                    -- Add the printer Model, if it doesn't exist
                    UPDATE printerModel
                    SET  printerModelName = @Model,
                            printerMakeID  = ( 
                            SELECT printerMakeID 
                            FROM   printerMake 
                            WHERE  printerMakeName = @Make
                            )
                    WHERE printerModelID = @ModelId;
                    ", db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("Make", printer.Make));
                    cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                    cmd.Parameters.Add(new MySqlParameter("Model", printer.Model));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }

                UpdateCodes(printer);
            }
            return printer.ModelId;
        }

        public bool Delete(uint ModelId)
        {
            if (Get(ModelId) == null)
                return false;
            else
            {
                string sqlStatement = @"

                    DELETE FROM printerModelCode
                    WHERE printerModelID = @idPrinter;

                    DELETE FROM printerModel
                    WHERE printerModelID = @idPrinter;
                ";

                try
                {
                    db.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idPrinter", ModelId));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return true;
        }
    }
}
