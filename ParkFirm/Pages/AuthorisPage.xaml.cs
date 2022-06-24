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
	/// Interaction logic for AuthorisPage.xaml
	/// </summary>
	public partial class AuthorisPage : Page
	{
		public AuthorisPage()
		{
			InitializeComponent();
		}

		private void BTN_Login_Click(object sender, RoutedEventArgs e)
		{

		}

		private void BTN_Reg_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.Navigate(new RegistrationPage());
		}
	}
}
