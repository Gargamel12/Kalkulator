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

namespace WpfApp2
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
        private void cal_Click(object sender, RoutedEventArgs e)
        {
            double imp1 = double.Parse(Karel.Text);
            double imp = double.Parse(Blob.Text);
            if (u.Text == "+")
            { Cvecek.Text = (imp1 + imp).ToString(); }
            if (u.Text == "-")
            { Cvecek.Text = (imp1 - imp).ToString(); }
            if (u.Text == "/")

                if (imp1 != 0! & imp != 0)
                {
                    Cvecek.Text = (imp1 / imp).ToString();
                }
                else
                { Cvecek.Text = "Error 404"; }
        }
            if (u.Text == "*") 
           { Cvecek.Text = (imp1 * imp).ToString(); }
        }
    }
}
