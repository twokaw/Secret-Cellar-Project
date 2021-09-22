using MySql.Data.MySqlClient;
using Shared;
using System;
using System.Collections;
using System.Resources;

namespace WebApi.Helpers
{
    public class DbConn
    {
        private readonly MySqlConnection conn;
        private static readonly string defaultConnectionString = "Server=localhost;Port=3306;Database=inventory;Uid=invuser;Pwd=testinv!;";
        private static string connString = null;

        public DbConn()
        {
            conn = new MySqlConnection(GetConnectionString());
        }

        public void SetConnectionString(string conString)
        {
            try
            {
                using IResourceWriter writer = new ResourceWriter("myResources.resources");

                // TODO: Encrypt connection string
                // Adds resources to the resource writer.
                writer.AddResource("ConnectionString", conString);

                // Writes the resources to the file or stream, and closes it.
                writer.Close();
                connString = conString;
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); }
        }

        public string GetConnectionString()
        {
            if(connString == null)
            {
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
            }

            return connString;
        }

        public void OpenConnection()
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

        public void CloseConnnection()
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

        public MySqlConnection Connection()
        {
            return this.conn;
        }
    }
}
