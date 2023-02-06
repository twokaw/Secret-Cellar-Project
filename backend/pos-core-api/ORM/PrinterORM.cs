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
              WHERE UPPER(makename) = @make
              AND  UPPER(modelname) = @Model
            ");
            cmd.Parameters.Add(new MySqlParameter("make", make.ToUpper() ));
            cmd.Parameters.Add(new MySqlParameter("Model", model.ToUpper()));

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
              WHERE modelid = @idd
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
                INSERT IGNORE INTO printermake
                (printermakename) 
                VALUES
                (@make);                

                -- Add the printer Model, if it doesn't exist
                INSERT IGNORE INTO printermodel
                (printermodelname, printermakeid ) 
                SELECT @model, printermakeid 
                FROM   printermake 
                WHERE  printermakename = @make;
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
                SELECT  printermakename
                FROM printermake
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
                SELECT printermakename
                FROM printermake
            ");

            try
            {
                using MySqlDataReader reader = cmd.ExecuteReader();

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
                INSERT IGNORE INTO printercode
                (drawer, cutter, partialcutter) 
                VALUES
                (@drawer, @cutter, @partialcutter);

                INSERT IGNORE INTO printermodelcode
                (printermodelid, printercodeid)

                SELECT @modelid,  printercodeid
                FROM printercode
                WHERE drawer = @drawer
                AND   cutter = @cutter
                AND   partialcutter = @partialcutter;

                SELECT  printercodeid
                FROM printercode
                WHERE drawer = @drawer
                AND   cutter = @cutter
                AND   partialcutter = @partialcutter;
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
                    DELETE FROM printermodelcode
                    WHERE printermodelid = @modelid
                    {(string.IsNullOrWhiteSpace(CodeIds) ? "" : $"AND NOT printercodeid IN ({CodeIds})")};
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
                    INSERT IGNORE INTO printermake
                    (printermakename) 
                    VALUES
                    (@make);                

                    -- Add the printer Model, if it doesn't exist
                    UPDATE printermodel
                    SET  printermodelname = @model,
                            printermakeid  = ( 
                            SELECT printermakeid 
                            FROM   printermake 
                            WHERE  printermakename = @make
                            )
                    WHERE printermodelid = @modelid;
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

                    DELETE FROM printermodelcode
                    WHERE printermodelid = @idprinter;

                    DELETE FROM printermodel
                    WHERE printermodelid = @idprinter;
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
