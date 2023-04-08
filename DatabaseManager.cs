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
            {
                connection.Open();

                string sql = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public bool UserExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";        
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                int count = (int)(long)command.ExecuteScalar();
                connection.Close();
                return count > 0;
                
            }

        }
          public bool VerifyPassword(string username, string password)
        {
            string query = "SELECT Password FROM Users WHERE Username = @Username";        
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                string hashedPassword = (string)command.ExecuteScalar();
                connection.Close();
                return string.Equals(password, hashedPassword);
            }

        }
    }
}
