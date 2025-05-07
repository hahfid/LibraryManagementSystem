using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public class DBConnection
    {
        private MySqlConnection connection;

        public DBConnection()
        {
            string connectionString = "server=localhost;user id=root;password=;database=libraryapps;SslMode=none";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
