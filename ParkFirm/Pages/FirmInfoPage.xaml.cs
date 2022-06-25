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
	/// Interaction logic for FirmInfoPage.xaml
	/// </summary>
	public partial class FirmInfoPage : Page
	{
		public static Firm n { get; set; }
		public FirmInfoPage()
		{
			InitializeComponent();
			var n = BD_connection.connection.Firm.FirstOrDefault();
			tb_Name.Text = n.Title;
			tb_Adress.Text = n.Adress;
			this.DataContext = this;
			
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}
	}
}
