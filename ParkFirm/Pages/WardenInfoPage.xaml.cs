﻿using System;
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
	/// Interaction logic for WardenInfoPage.xaml
	/// </summary>
	public partial class WardenInfoPage : Page
	{
		public WardenInfoPage()
		{
			InitializeComponent();
		}

		private void btn_DelWarden_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_Back_Click(object sender, RoutedEventArgs e)
		{
			NavigationService.GoBack();
		}
	}
}
