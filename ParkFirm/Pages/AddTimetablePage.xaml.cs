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
	/// Interaction logic for AddTimetablePage.xaml
	/// </summary>
	public partial class AddTimetablePage : Page
	{
		public AddTimetablePage()
		{
			InitializeComponent();
		}

		private void btn_AddTime_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}
	}
}
