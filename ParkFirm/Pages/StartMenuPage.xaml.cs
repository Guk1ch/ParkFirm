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

namespace ParkFirm.Pages
{
	/// <summary>
	/// Interaction logic for StartMenuPage.xaml
	/// </summary>
	public partial class StartMenuPage : Page
	{
		public StartMenuPage()
		{
			InitializeComponent();
		}


		private void Empl_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new EmployeePage());
		}

		private void Plant_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new PlantsPage());
		}

		private void Water_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new WateringPage());
		}

		private void Area_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new AreaPage());
		}

		private void Info_MouseDown(object sender, MouseButtonEventArgs e)
		{
			NavigationService.Navigate(new FirmInfoPage());
		}
	}
}
