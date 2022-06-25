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
	/// Interaction logic for TimeTablePage.xaml
	/// </summary>
	public partial class TimeTablePage : Page
	{
		public static ObservableCollection<Timetable> times { get; set; }
		public TimeTablePage()
		{
			InitializeComponent();
			times = new ObservableCollection<Timetable>(BD_connection.connection.Timetable.ToList());
			this.DataContext = this;
		}

		private void btn_Add_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}
	}
}
