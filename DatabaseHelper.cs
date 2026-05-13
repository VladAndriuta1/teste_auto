using MySql.Data.MySqlClient;
namespace teste_auto {
    public class DatabaseHelper { 
        private static string connectionString = "Server=localhost;Database=teste_auto;Uid=root;Pwd=1234;"; 
        public static MySqlConnection GetConnection() 
        { 
            return new MySqlConnection(connectionString); 
        } 
    }
}