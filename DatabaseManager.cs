using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace Sharp_Primer
{
    public class DatabaseManager
    {
        private const string connectionString = "Data Source=UserCredentials.db;Version=3;";
        private SQLiteConnection connection = new SQLiteConnection(connectionString);

        public DatabaseManager()
        {
            if (!System.IO.File.Exists("UserCredentials.db"))
            {
                SQLiteConnection.CreateFile("UserCredentials.db");

                // Create the "Users" table
                string sql = "CREATE TABLE Users (Username VARCHAR(50) NOT NULL, Password VARCHAR(50) NOT NULL, PRIMARY KEY (Username))";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public void InsertUser(string username, string password)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
