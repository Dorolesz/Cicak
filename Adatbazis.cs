using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cicak
{
	internal class Adatbazis
	{
		private List<Cica> lista;
		private string connectionString = "server=localhost;database=cicadb;user=root;password='';";

		public Adatbazis()
		{
			lista = new List<Cica>();
		}

		public List<Cica> Kapcsolat()
		{
			try
			{
				using (MySqlConnection connection = new MySqlConnection(connectionString))
				{
					connection.Open();

					string query = "SELECT * FROM cicak;";
					using (MySqlCommand cmd = new MySqlCommand(query, connection))
					using (MySqlDataReader reader = cmd.ExecuteReader())
					{

					}
				}
			}
		}
	}
}
