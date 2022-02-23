using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void PrintSymbole(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (!(calcule.Text.EndsWith("+") || calcule.Text.EndsWith("-") || calcule.Text.EndsWith("*") || calcule.Text.EndsWith("/") || calcule.Text == ""))
            {
                calcule.Text += btn.Content.ToString();
            }
            else
            {
                string newCalcule = calcule.Text.Remove(calcule.Text.Length-1);
                calcule.Text = newCalcule;
                calcule.Text += btn.Content.ToString();
            }
        }

        void PrintNumber(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            calcule.Text += btn.Content.ToString();
        }

        void Reset(object sender, RoutedEventArgs e)
        {
            calcule.Text = "";
            resultat.Text = "0";
        }

        void GetResult(object sender, RoutedEventArgs e)
        {
            if(!(calcule.Text.EndsWith("+") || calcule.Text.EndsWith("-") || calcule.Text.EndsWith("*") || calcule.Text.EndsWith("/") || calcule.Text == ""))
            {
                string math = calcule.Text;
                string result = new DataTable().Compute(math, null).ToString();
                resultat.Text = result;
            }
        }
    }
}
