using MySql.Data.MySqlClient;
using System.Resources;

namespace WebApi.Helpers
{
    public class DbConn
    {
        private readonly MySqlConnection conn;
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
