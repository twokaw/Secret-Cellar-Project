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
            Printer outputItem;
            db.OpenConnection();

            string sqlStatement = "SELECT PrinterModelid, printerMakeID, printerMakeName, PrinterModelname, Drawer, Cutter, PartialCutter FROM v_printer";

            MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    outputItem = new Printer
                    {
                        MakeId = reader.IsDBNull("printerMakeID") ? 0 : reader.GetUInt32("printerMakeID"),
                        ModelId = reader.IsDBNull("PrinterModelid") ? 0 : reader.GetUInt32("PrinterModelid"),
                        Make = reader.IsDBNull("Make") ? "" : reader.GetString("Make"),
                        Model = reader.IsDBNull("Model") ? "" : reader.GetString("Model"),
                        Cutter = reader.IsDBNull("Cutter ") ? "" : reader.GetString("Cutter "),
                        PartialCutter = reader.IsDBNull("PartialCutter") ? "" : reader.GetString("PartialCutter")
                    };
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

        public uint Insert (Printer Printer)
        {
            db.OpenConnection();
            uint newId = 0;
            string sqlStatement = @"
                INSERT INTO v_printer
                (PrinterModelid, printerMakeID, printerMakeName, PrinterModelname, Drawer, Cutter, PartialCutter
                VALUES
                (@bottle_deposit, @sales_Printer, @local_sales_Printer, @Printer_name)
            ";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                cmd.Parameters.Add(new MySqlParameter("idPrinter", Printer.IdPrinter));
                cmd.Parameters.Add(new MySqlParameter("bottle_deposit", Printer.BottleDeposit));
                cmd.Parameters.Add(new MySqlParameter("Printer_name", Printer.PrinterName));
                cmd.Parameters.Add(new MySqlParameter("sales_Printer", Printer.SalesPrinter));
                cmd.Parameters.Add(new MySqlParameter("local_sales_Printer", Printer.LocalSalesPrinter));
                cmd.ExecuteNonQuery();
                newId = (uint)cmd.LastInsertedId;
            }
            finally
            {
                db.CloseConnnection();
            }

            return newId;
        }

        public uint Update( Printer Printer)
        {
            db.OpenConnection();
            if (Get(Printer.IdPrinter) == null)
                return Insert(Printer);
            else
            {
                string sqlStatement = @"
                    UPDATE v_printer
                        bottle_deposit = @bottle_deposit, 
                        sales_Printer = @sales_Printer, 
                        local_sales_Printer = @local_sales_Printer, 
                        Printer_name = @Printer_name
                    WHERE idPrinter = @idPrinter
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idPrinter", Printer.IdPrinter));
                    cmd.Parameters.Add(new MySqlParameter("bottle_deposit", Printer.BottleDeposit));
                    cmd.Parameters.Add(new MySqlParameter("Printer_name", Printer.PrinterName));
                    cmd.Parameters.Add(new MySqlParameter("sales_Printer", Printer.SalesPrinter));
                    cmd.Parameters.Add(new MySqlParameter("local_sales_Printer", Printer.LocalSalesPrinter));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return Printer.IdPrinter;
        }

        public bool Delete(uint PrinterId)
        {
            db.OpenConnection();
            if (Get(PrinterId) == null)
                return false;
            else
            {
                string sqlStatement = @"
                    DELETE FROM v_printer
                    WHERE idPrinter = @idPrinter
                ";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStatement, db.Connection());
                    cmd.Parameters.Add(new MySqlParameter("idPrinter", PrinterId));
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    db.CloseConnnection();
                }
            }

            return true;
        }

        // Get: api/Printer
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
                if (reader.Read())
                {
                    outputItem = new Printer
                    {
                        IdPrinter = reader.IsDBNull("idPrinter") ? 0 : reader.GetUInt32("idPrinter"),
                        BottleDeposit = reader.IsDBNull("bottle_deposit") ? 0.0 : reader.GetDouble("bottle_deposit"),
                        PrinterName = reader.IsDBNull("Printer_name") ? "" : reader.GetString("Printer_name"),
                        SalesPrinter = reader.IsDBNull("sales_Printer") ? 0.0 : reader.GetDouble("sales_Printer"),
                        LocalSalesPrinter = reader.IsDBNull("local_sales_Printer") ? 0.0 : reader.GetDouble("local_sales_Printer")
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
