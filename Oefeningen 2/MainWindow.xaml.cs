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

namespace Oefeningen_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOef1_Click(object sender, RoutedEventArgs e)
        {
            Oef1 oef1 = new Oef1();
            oef1.Show();
        }

        private void btnOef2_Click(object sender, RoutedEventArgs e)
        {
            Oef2 oef2 = new Oef2();
            oef2.Show();
        }

        private void btnOef3_Click(object sender, RoutedEventArgs e)
        {
            Oef3 oef3 = new Oef3();
            oef3.Show();
        }

        private void btnOef4_Click(object sender, RoutedEventArgs e)
        {
            Oef4 oef4 = new Oef4();
            oef4.Show();
        }
    }
}
