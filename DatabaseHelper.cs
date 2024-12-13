using MySql.Data.MySqlClient;

namespace DAL
{
	public static class DatabaseHelper
	{
		private static string connectionString = "Server=localhost;Database=RestoranDB;Uid=root;Pwd=yourpassword;";

		public static MySqlConnection GetConnection()
		{
			return new MySqlConnection(connectionString);
		}
	}
}
