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

        public static string ConnectionString { get; set; }

        public DbConn()
        {
            conn = new MySqlConnection(ConnectionString);
        }

        public static void SaveConnectionString()
        {
            Resources.SetValue("ConnectionString", ConnectionString);
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
