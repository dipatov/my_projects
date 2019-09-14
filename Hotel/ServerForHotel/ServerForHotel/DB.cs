using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ServerForHotel
{
	public static class DB
	{
		static public SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Hotel;Integrated Security=True");
		public static void Open()
		{
			try
			{
				connection.Open();
				connection.OpenAsync();
				Console.WriteLine("Подключение к БД Hotel установлено");
			}
			catch(SqlException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		public static void Close()
		{
			try
			{
				connection.Close();
				Console.WriteLine("Подключение с БД разорвано");
			}
			catch (SqlException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
