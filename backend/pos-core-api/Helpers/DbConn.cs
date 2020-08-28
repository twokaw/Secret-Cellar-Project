using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WebApi.Helpers
{
    public class DbConn
    {
        private MySqlConnection conn;
        private string connString;

        public DbConn()
        {
            connString = "Server=localhost;Port=3306;Database=inventory;Uid=invuser;Pwd=testinv!;";

            conn = new MySqlConnection(connString);
        }

        public void OpenConnection()
        {
            conn.Open();
        }

        public void CloseConnnection()
        {
            if(conn.Ping() == true)
                conn.Close();
        }

        public MySqlConnection Connection()
        {
            return this.conn;
        }
    }
}
