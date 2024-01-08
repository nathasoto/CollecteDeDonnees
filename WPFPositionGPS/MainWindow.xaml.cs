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
using WPFPositionGPS.ViewModels;

namespace WPFPositionGPS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ViewModelPositionGPS _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ViewModelPositionGPS();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            TextInformation.Visibility = Visibility.Visible;



        }
    }
}
