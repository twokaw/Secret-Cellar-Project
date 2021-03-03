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
            db.OpenConnection();

            string sqlStatement = @"
             SELECT PrinterModelid, printerMakeID, printerMakeName, PrinterModelname, Drawer, Cutter, PartialCutter 
             FROM v_printer
            ";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if(outputItem == null || outputItem.ModelId != reader.GetUInt32("PrinterModelid"))
                    {
                        outputItem = new Printer
                        {
                            MakeId = reader.IsDBNull("printerMakeID") ? 0 : reader.GetUInt32("printerMakeID"),
                            ModelId = reader.IsDBNull("PrinterModelid") ? 0 : reader.GetUInt32("PrinterModelid"),
                            Make = reader.IsDBNull("Make") ? "" : reader.GetString("Make"),
                            Model = reader.IsDBNull("Model") ? "" : reader.GetString("Model")
                        };
                        output.Add(outputItem);  
                    }

                    outputItem.Codes.Add(new PrinterCode
                    {
                        Drawer = reader.IsDBNull("Drawer") ? "" : reader.GetString("Drawer"),
                        Cutter = reader.IsDBNull("Cutter") ? "" : reader.GetString("Cutter"),
                        PartialCutter = reader.IsDBNull("PartialCutter") ? "" : reader.GetString("PartialCutter")
                    });
                }  
            }
            finally
            {
                reader.Close();
            }

            db.CloseConnnection();
            return output;
        }

        public Printer Get(uint PrinterId)
        {
            Printer outputItem = null;
            db.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(@"
              SELECT * 
              FROM v_printer 
              WHERE idPrinter = @ID
            ", db.Connection());
            cmd.Parameters.Add(new MySqlParameter("ID", PrinterId));
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while(reader.Read())
                {
                    if(outputItem == null)
                        outputItem = new Printer
                        {
                            MakeId = reader.IsDBNull("printerMakeID") ? 0 : reader.GetUInt32("printerMakeID"),
                            ModelId = reader.IsDBNull("PrinterModelid") ? 0 : reader.GetUInt32("PrinterModelid"),
                            Make = reader.IsDBNull("Make") ? "" : reader.GetString("Make"),
                            Model = reader.IsDBNull("Model") ? "" : reader.GetString("Model")
                        };

                    outputItem.Codes.Add(new PrinterCode
                    {
                        Drawer  = reader.IsDBNull("Drawer") ? "" : reader.GetString("Drawer"),
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
            db.OpenConnection();

            uint newId = 0;
            string sqlStatement = @"
                -- Add the printer Make, if it doesn't exist
                INSERT IGNORE INTO printermake
                (PrinterMakeName) 
                VALUES
                (@Make);                

                -- Add the printer Model, if it doesn't exist
                INSERT IGNORE INTO printermodel
                (PrinterModelName, PrintermakeID ) 
                SELECT @Model, PrintermakeID 
                FROM   printermake 
                WHERE  printermakeName = @Make;
            ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("Make", printer.Make));
                cmd.Parameters.Add(new MySqlParameter("Model", printer.Model));
                cmd.ExecuteNonQuery();
                printer.ModelId = (uint)cmd.LastInsertedId;
                UpdateCodes(printer);
            }
            finally
            {
                db.CloseConnnection();
            }
            return newId;
                
        }

        public void UpdateCodes(Printer printer)
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

                INSERT IGNORE INTO PrinterModelCode
                (printerModelID, printercodeid)
                SELECT @ModelID, Printercodeid
                FROM Printercode
                WHERE Drawer = @Drawer
                AND   Cutter = @Cutter
                AND   PartialCutter = @PartialCutter;
            ";

            try
            {
                foreach (PrinterCode pc in printer.Codes)
                {
                    cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                    cmd.Parameters.Add(new MySqlParameter("Drawer", pc.Drawer));
                    cmd.Parameters.Add(new MySqlParameter("Cutter", pc.Cutter));
                    cmd.Parameters.Add(new MySqlParameter("PartialCutter", pc.PartialCutter));
                    cmd.Parameters.Add(new MySqlParameter("codeID", MySqlDbType.Int32) { Direction = ParameterDirection.Output });
                    cmd.ExecuteNonQuery();
                    CodeIds += $"{cmd.Parameters["codeID"].Value},";

                    CodeIds = CodeIds.Trim(',');

                    cmd = new MySqlCommand(@$"
                      DELETE FROM printermodelcode
                      WHERE PrinterModelID = @ModelID
                      {(string.IsNullOrWhiteSpace(CodeIds) ? "" : $"AND NOT PrinterModelId IN ({CodeIds})")};
                    ", db.Connection());

                    cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                db.CloseConnnection();
            }
        }

        public uint Update( Printer printer)
        {
            db.OpenConnection();

            uint newId = 0;
            string sqlStatement = @"
            -- Add the printer Make, if it doesn't exist
            INSERT IGNORE INTO printermake
            (PrinterMakeName) 
            VALUES
            (@Make);                

            -- Add the printer Model, if it doesn't exist
            UPDATE printermodel
            SET  PrinterModelName = @Model,
                    PrintermakeID  = ( 
                    SELECT  PrintermakeID 
                    FROM   printermake 
                    WHERE  printermakeName = @Make
                    )
            WHERE PrinterModelID = @ModelId;
            ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("Make", printer.Make));
                cmd.Parameters.Add(new MySqlParameter("ModelID", printer.ModelId));
                cmd.Parameters.Add(new MySqlParameter("Model", printer.Model));
                cmd.ExecuteNonQuery();
                printer.ModelId = (uint)cmd.LastInsertedId;

                UpdateCodes(printer);
            }
            finally
            {
                db.CloseConnnection();
            }
            return newId;
        }

        public bool Delete(uint printerModelId)
        {
            db.OpenConnection();

            if (Get(printerModelId) == null)
                return false;
            else
            {
                string sqlStatement = @"

                    DELETE FROM PrinterModelCode
                    WHERE PrinterModelID = @idPrinter;

                    DELETE FROM printermodel
                    WHERE PrinterModelID = @idPrinter;
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idPrinter", printerModelId));
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
