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
	/// Interaction logic for AddAreaPage.xaml
	/// </summary>
	public partial class AddAreaPage : Page
	{
		public AddAreaPage()
		{
			InitializeComponent();
		}

		private void btn_AddArea_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}
	}
}
