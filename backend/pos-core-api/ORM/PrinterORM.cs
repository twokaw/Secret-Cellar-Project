using MySql.Data.MySqlClient;
using Shared;
using System.Collections.Generic;
using System.Data;
using WebApi.Helpers;

namespace pos_core_api.ORM
{
    public class PrinterORM
    {
        private readonly DbConn db = new();

        public List<Printer> Get()
        {
            List<Printer> output = new();
            Printer outputItem = null;
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT *
                FROM v_printer
            ");
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (outputItem == null || outputItem.ModelId != reader.GetUInt32("Modelid"))
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
                db.CloseCommand(cmd);
            }
            return output;
        }

        private uint Get(string make, string model)
        {            
            MySqlCommand cmd = db.CreateCommand(@"
              SELECT modelId 
              FROM v_printer 
              WHERE UPPER(makeName) = UPPER(@make)
              AND  UPPER(modelName) = UPPER(@Model)
            ");
            cmd.Parameters.Add(new MySqlParameter("make", make));
            cmd.Parameters.Add(new MySqlParameter("Model", model));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return uint.Parse(reader["ModelID"].ToString());
            }
            finally
            {
                db.CloseCommand(cmd);
            }
            return 0;
        }

        public Printer Get(uint PrinterId)
        {
            Printer outputItem = null;
            
            MySqlCommand cmd = db.CreateCommand(@"
              SELECT * 
              FROM v_printer 
              WHERE Modelid = @Id
            ");
            cmd.Parameters.Add(new MySqlParameter("Id", PrinterId));
            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (outputItem == null)
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
                db.CloseCommand(cmd);
            }
            return outputItem;
        }

        public uint Insert (Printer printer)
        {
            MySqlCommand cmd = db.CreateCommand(@"
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
            ");

            cmd.Parameters.Add(new MySqlParameter("Make", printer.Make));
            cmd.Parameters.Add(new MySqlParameter("Model", printer.Model));

            try
            {
                cmd.ExecuteNonQuery();

                printer.ModelId = (uint)cmd.LastInsertedId;
            }
            finally
            {
                db.CloseCommand(cmd);
            }

            UpdateCodes(printer);

            return printer.ModelId;
        }

        public string GetMake(uint makeId)
        {
            MySqlCommand cmd = db.CreateCommand(@"
                SELECT  PrinterMakeName
                FROM PrinterMake
                WHERE printermakeid = @makeid
            ");

            cmd.Parameters.Add(new MySqlParameter("makeid", makeId));

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return reader.IsDBNull("PrinterMakeName") ? "" : reader.GetString("PrinterMakeName");
            }
            finally
            {
                db.CloseCommand(cmd);
            }
            return "";
        }

        public List<string> GetMake()
        {
            List<string> result = new();

            MySqlCommand cmd = db.CreateCommand(@"
                SELECT  PrinterMakeName
                FROM PrinterMake
            ");

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                    if(!reader.IsDBNull("PrinterMakeName") && !string.IsNullOrWhiteSpace(reader.GetString("PrinterMakeName")))
                        result.Add( reader.GetString("PrinterMakeName"));
            }
            finally
            {
                db.CloseCommand(cmd);
            }
            return result;
        }

        public void UpdateCodes(Printer printer)
        {
           string CodeIds = "";

           string sql = @"
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
            MySqlCommand cmd;

            foreach (PrinterCode pc in printer.Codes)
            {
                cmd = db.CreateCommand(sql);
                cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                cmd.Parameters.Add(new MySqlParameter("Drawer", $"{pc.Drawer}"));
                cmd.Parameters.Add(new MySqlParameter("Cutter", $"{pc.Cutter}"));
                cmd.Parameters.Add(new MySqlParameter("PartialCutter", $"{pc.PartialCutter}"));

                try
                {
                    using MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                        CodeIds += $"{(reader.IsDBNull("printercodeid") ? 0 : reader.GetUInt32("printercodeid"))},";
                }
                finally
                {
                    db.CloseCommand(cmd);
                }
            }

            CodeIds = CodeIds.Trim(',');

            cmd = db.CreateCommand(@$"
                    DELETE FROM printerModelcode
                    WHERE printerModelID = @ModelID
                    {(string.IsNullOrWhiteSpace(CodeIds) ? "" : $"AND NOT printerCodeid IN ({CodeIds})")};
                ");

            cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));

            try
            {
                cmd.ExecuteNonQuery();
            }
            finally
            {
                db.CloseCommand(cmd);
            }
        }

        public uint Update( Printer printer)
        {
            // return 0 if the printer is null
            if (printer == null)
                return 0;

            // if the printer model id is missing try to find it
            if (printer.ModelId == 0)
                printer.ModelId = Get(printer.Make, printer.Model);

            if (printer.ModelId == 0 || Get(printer.ModelId) == null)
                Insert(printer);
            else
            {       
                MySqlCommand cmd = db.CreateCommand(@"
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
                ");
                cmd.Parameters.Add(new MySqlParameter("Make", printer.Make));
                cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                cmd.Parameters.Add(new MySqlParameter("Model", printer.Model));   

                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseCommand(cmd);
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
                MySqlCommand cmd = db.CreateCommand(@"

                    DELETE FROM printerModelCode
                    WHERE printerModelID = @idPrinter;

                    DELETE FROM printerModel
                    WHERE printerModelID = @idPrinter;
                ");

                cmd.Parameters.Add(new MySqlParameter("idPrinter", ModelId));

                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseCommand(cmd);
                }
            }

            return true;
        }
    }
}
