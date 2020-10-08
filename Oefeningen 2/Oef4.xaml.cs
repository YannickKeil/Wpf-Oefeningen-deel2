using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Oef4.xaml
    /// </summary>
    public partial class Oef4 : Window
    {
        public Oef4()
        {
            InitializeComponent();
        }
        private static readonly Regex _regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(String)))
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                if (!IsTextAllowed(text))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
        private void btnNumUp_Click(object sender, RoutedEventArgs e)
        {
                decimal getal = Convert.ToDecimal(nudLeeftijd.Text);
                getal++;
                nudLeeftijd.Text = getal.ToString();     
           
        }



        private void btnNumDown_Click(object sender, RoutedEventArgs e)
        {
            nudLeeftijd.Text = $"{Convert.ToDecimal(nudLeeftijd.Text) - 1}";
        }
        public bool lmbNudUpPressed = false;

    }
}
