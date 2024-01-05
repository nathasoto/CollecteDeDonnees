using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFLignesTransport.Models;
using WPFLignesTransport.ViewModels;
using WPFLignesTransport.Views;

namespace WPFLignesTransport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new GetPositionGPSViewModel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            //hide windows
            this.Hide();

            //instanciar la nueva ventana
            LignesTransportViewer windowsListTransport = new LignesTransportViewer();

            //call windows
            windowsListTransport.Show();

        }
    }
}
