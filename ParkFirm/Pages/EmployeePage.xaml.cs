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
using System.Collections.ObjectModel;
using ParkFirm.Data;

namespace ParkFirm.Pages
{
	/// <summary>
	/// Interaction logic for EmployeePage.xaml
	/// </summary>
	public partial class EmployeePage : Page
	{
		public static ObservableCollection<Wardenn> wardens { get; set; }
		public static ObservableCollection<Data.Decorator> decs { get; set; }
		public EmployeePage()
		{
			InitializeComponent();
			wardens = new ObservableCollection<Wardenn>(BD_connection.connection.Wardenn.ToList());
			decs = new ObservableCollection<Data.Decorator>(BD_connection.connection.Decorator.ToList());

			var w = new Wardenn();
			var d = new Data.Decorator();
			this.DataContext = this;
		}

		private void btn_AddWarden_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AddWardenPage());
		}

		private void btn_AddDeck_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AddDecorPage());
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void war_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var n = (sender as ListView).SelectedItem as Wardenn;
			NavigationService.Navigate(new WardenInfoPage(n));
		}

		private void dec_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var n = (sender as ListView).SelectedItem as Data.Decorator;
			NavigationService.Navigate(new DecInfoPage(n));
		}

		private void btn_Time_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new TimeTablePage());
		}
	}
}
