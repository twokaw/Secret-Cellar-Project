using MySql.Data.MySqlClient;
using pos_core_api.Helpers;
using Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;

namespace WebApi.Helpers
{
    public class DbConn
    {

        private List<MySqlCommand> Cmds = new List<MySqlCommand>();
        private readonly MySqlConnection conn;
        private static readonly string defaultConnectionString = "Server=localhost;Port=3306;Database=inventory;Uid=invuser;Pwd=testinv!;";
        private static string connString = null;

        public DbConn()
        {
            conn = new MySqlConnection(GetConnectionString());
        }

        public void SetConnectionString(string conString)
        {/*
            try
            {
                using IResourceWriter writer = new ResourceWriter("myResources.resources");

                // TODO: Encrypt connection string
                // Adds resources to the resource writer.
                writer.AddResource("ConnectionString", conString);
                */
            Resources.SetValue("ConnectionString", conString);
            connString = conString;
            /*
            // Writes the resources to the file or stream, and closes it.
            writer.Close();
            connString = conString;
        }
        catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); }
            */
        }

        public string GetConnectionString()
        {

            if(connString == null)
            {
                /*
                try
                {
                    // try to read the resource file
                    ResourceReader rw = new ResourceReader("myResources.resources");

                    IDictionaryEnumerator dict = rw.GetEnumerator();

                    while(dict.MoveNext())
                        if(dict.Key.ToString() == "ConnectionString")
                        {
                            connString = dict.Value.ToString();
                            break;
                        }
                }
                catch (Exception ex)
                {
                    ErrorLogging.WriteToErrorLog(ex);

                    // if reading the file fails, then create a new file
                    SetConnectionString(defaultConnectionString);
                }

                // if that fails then use the default connection string
                if (connString == null) 
                    connString = defaultConnectionString;
                */
                connString = Resources.GetValue("ConnectionString", defaultConnectionString);
            }

            return connString;
        }

        public void OpenConnection(MySqlConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
            }
        }

        public void CloseConnnection(MySqlConnection conn)
        {
            try
            {
                if (conn.Ping() == true)
                    conn.Close();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
            }
        }

        public MySqlCommand CreateCommand(string sql = "")
        {
            MySqlConnection db = new MySqlConnection(GetConnectionString());

            OpenConnection(db);
            MySqlCommand cmd = db.CreateCommand();
            cmd.CommandText = sql;

            return cmd;
        }

        public void CloseCommand(MySqlCommand cmd)
        {
            CloseConnnection(cmd.Connection);
            cmd.Dispose();
        }
        public MySqlConnection Connection()
        {
            return this.conn;
        }
    }
}
