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
    }}
