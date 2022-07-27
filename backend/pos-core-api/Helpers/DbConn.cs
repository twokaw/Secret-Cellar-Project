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

      //  private List<MySqlCommand> Cmds = new();
        private readonly MySqlConnection conn;
        private static readonly string  DefaultConnection = EncryptionClass.EncryptString("Server=localhost;Port=3306;Database=inventory;Uid=invuser;Pwd=testinv!;");
        private static string connString = null;

        public static string ConnectionString
        {
            get
            {
                if(connString == null )
                {
                    connString = Resources.GetValue("ConnectionString", "-1");
                    if (connString == "-1")
                    {
                        connString = DefaultConnection;
                        SaveConnectionString();
                    }
                }
                return EncryptionClass.DecryptString(connString);
            }
            set
            {
                connString = value;
                SaveConnectionString();
            }
        }

        public static void SetConnectionString(string unencryptedConnectionString)
        {
            connString = EncryptionClass.EncryptString(unencryptedConnectionString);
        }

        public DbConn()
        {
            conn = new MySqlConnection(ConnectionString);
        }

        public static void SaveConnectionString()
        {
            Resources.SetValue("ConnectionString", connString);
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
            MySqlConnection db = new(ConnectionString);

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
