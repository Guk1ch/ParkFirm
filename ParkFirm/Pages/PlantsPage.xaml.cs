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
	/// Interaction logic for PlantsPage.xaml
	/// </summary>
	public partial class PlantsPage : Page
	{
		public static ObservableCollection<Plant> plants { get; set; }
		public static ObservableCollection<Type_Plant> type_s { get; set; }
		public static ObservableCollection<Watering_Mode> watering_s  { get; set; }
		public static ObservableCollection<Plant_Area> plant_Areas { get; set; }

		public PlantsPage()
		{
			InitializeComponent();
			plants = new ObservableCollection<Plant>(BD_connection.connection.Plant.ToList());
			plant_Areas = new ObservableCollection<Plant_Area>(BD_connection.connection.Plant_Area.ToList());
			type_s = new ObservableCollection<Type_Plant>(BD_connection.connection.Type_Plant.ToList());
			watering_s = new ObservableCollection<Watering_Mode>(BD_connection.connection.Watering_Mode.ToList());

			this.DataContext = this;
		}

		private void btn_AddPlant_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new AddPlantPage());
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void Plants_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}
	}
}
