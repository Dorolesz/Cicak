using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cicak
{
	internal class Cica
	{
		private int id;
		private string nev;
		private string fajta;
		private double suly;
		private int rendetlensegi_szint;

		public Cica(int id, string nev, string fajta, double suly, int rendetlensegi_szint)
		{
			this.Id = id;
			this.Nev = nev;
			this.Fajta = fajta;
			this.Suly = suly;
			this.Rendetlensegi_szint = rendetlensegi_szint;
		}

		public int Id { get => id; set => id = value; }
		public string Nev { get => nev; set => nev = value; }
		public string Fajta { get => fajta; set => fajta = value; }
		public double Suly { get => suly; set => suly = value; }
		public int Rendetlensegi_szint { get => rendetlensegi_szint; set => rendetlensegi_szint = value; }
	}
}
