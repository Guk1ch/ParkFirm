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
	/// Interaction logic for RegistrationPage.xaml
	/// </summary>
	public partial class RegistrationPage : Page
	{
		public RegistrationPage()
		{
			InitializeComponent();
		}

		private void BTN_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void BTN_Reg_Click(object sender, RoutedEventArgs e)
		{
			var a = new User();
			a.Name = txt_Name.Text;
			a.Surname = txt_Surname.Text;
			a.Lastname = txt_Lastname.Text;
			a.Login = txt_login.Text;
			a.Password = txt_password.Password;
			BD_connection.connection.User.Add(a);
			BD_connection.connection.SaveChanges();
			MessageBox.Show("All OK");
			NavigationService.GoBack();
		}
	}
}
