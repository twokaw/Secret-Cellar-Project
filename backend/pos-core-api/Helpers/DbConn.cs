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
        private String connString;

        public DbConn()
        {
            connString = "Server=localhost;Port=3306;Database=mydb;Uid=invuser;Pwd=testinv!;";

            conn = new MySqlConnection(connString);
        }

        public void OpenConnection()
        {
            try
            {
                conn.Open(); //open the connection.

                Console.WriteLine("Connection status: " + conn.Ping()); //if true then connected. 
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnnection()
        {
            if(conn.Ping() == true)
            {
                Console.WriteLine("Closing connection...");
                conn.Close();
            }
            else
            {
                Console.WriteLine("Connection is closed.");
            }
        }

        public MySqlConnection Connection()
        {
            return this.conn;
        }
    }
}
