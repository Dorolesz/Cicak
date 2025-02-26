using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cicak
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Adatbazis a;
		List<Cica> lista;
		public MainWindow()
		{
			InitializeComponent();
			a = new Adatbazis();
			lista = a.Kapcsolat();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			grid.ItemsSource = lista;
		}

		private void btn_f2_Click(object sender, RoutedEventArgs e)
		{
			string keresettCica = adatbevitel.Text?.ToLower() ?? "";
			var talalat = lista.Where(c => c.Nev.Contains(keresettCica)).ToList();
			grid.ItemsSource = talalat;
			tblock.Text = $"Cica keresése név alapján: {talalat}";
		}

		private void btn_3_Click(object sender, RoutedEventArgs e)
		{
			var legnehezebbCica = lista.OrderByDescending();
			tblock.Text = $"A legnehezebb cica keresése";
		}

		private void btn_4_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_5_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_6_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
