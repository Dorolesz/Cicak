using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
						while (reader.Read())
						{
							Cica c = new Cica
							(
							reader.GetInt32("id"),
							reader.GetString("nev"),
							reader.GetString("fajta"),
							reader.GetInt32("suly"),
							reader.GetInt32("rendetlensegi_szint")
							);
						lista.Add(c);
						}
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Adatbazis hiba történt: " + ex.Message);
				Environment.Exit(1); //Program leállítása
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hiba történt: " + ex.Message);
				Environment.Exit(1);
			}
			return lista;
		}
	}
}
