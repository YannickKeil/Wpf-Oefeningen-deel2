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

namespace Oefeningen_2
{
    /// <summary>
    /// Interaction logic for Oef1.xaml
    /// </summary>
    public partial class Oef1 : Window
    {
        public List<Persoon> MijnPersonen = new List<Persoon>();
        public Oef1()
        {
            InitializeComponent();
            cbPersonen.ItemsSource = MijnPersonen;
            MijnPersonen.Add(new Persoon("Naruto", "Uzumaki", @"D:\user\keily\Pictures\Nieuwe map\Uzumaki_Naruto.JPG"));
            MijnPersonen.Add(new Persoon("Moka", "akashia", @"D:\user\keily\Pictures\moka-akashia-inner-and-outer-rosario-to-vampire-uhd-4k-wallpaper.jpg"));
            MijnPersonen.Add(new Persoon("Yoruichi", "Shihōin", @"D:\user\keily\Pictures\profole original.jpg"));
            cbPersonen.SelectedIndex = 0;
        }

        private void cbPersonen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {       
            
            Persoon selected = (Persoon)cbPersonen.SelectedItem;
            imgCombobox.DataContext = selected;
            
        }
    }
}
