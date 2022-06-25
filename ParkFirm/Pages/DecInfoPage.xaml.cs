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
	/// Interaction logic for DecInfoPage.xaml
	/// </summary>
	public partial class DecInfoPage : Page
	{
		public static ObservableCollection<Data.Decorator> decs { get; set; }
		public DecInfoPage(Data.Decorator n)
		{
			InitializeComponent();
			decs = new ObservableCollection<Data.Decorator>(BD_connection.connection.Decorator.ToList());
			tb_name.Text = n.Name;
			tb_surname.Text = n.Surname;
			tb_lastname.Text = n.Lastname;
			tb_phone.Text = n.Phone;
			tb_adress.Text = n.Adress;
			tb_name_edu.Text = n.Name_Edu_Institution;
			tb_category.Text = n.Category;
			var d = new Data.Decorator();
			this.DataContext = this;
		}

		private void btn_DelDeck_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}
	}
}
