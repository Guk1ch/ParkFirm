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
	/// Interaction logic for WateringPage.xaml
	/// </summary>
	public partial class WateringPage : Page
	{
		public static ObservableCollection<Watering> waterings { get; set; }
		public WateringPage()
		{
			InitializeComponent();
			waterings = new ObservableCollection<Watering>(BD_connection.connection.Watering.ToList());
			var w = new Watering();
			this.DataContext = this;
		}

		private void Watering_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void btn_AddWatering_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AddWateringPage());
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}
	}
}
