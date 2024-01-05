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
using System.Windows.Shapes;
using WPFTransportLines.ViewModels;

namespace WPFTransportLines
{
    /// <summary>
    /// Interaction logic for LinesViews.xaml
    /// </summary>
    public partial class LinesViews : Window
    {
        private readonly MyViewModel _viewModel;
        public LinesViews()
        {
            InitializeComponent();
            _viewModel = new MyViewModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _viewModel;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
