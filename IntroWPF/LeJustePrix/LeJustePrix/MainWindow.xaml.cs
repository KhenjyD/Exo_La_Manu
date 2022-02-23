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

namespace LeJustePrix
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int randomPrice;
        private int tentative;
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            randomPrice = rnd.Next(1, 51);
            tentative = 0;
        }

        void JustPrice(object sender, RoutedEventArgs e)
        {
            if (int.Parse(Find.Text) < randomPrice)
            {
                Indice.Text = "C'est plus !";
                tentative++;
            }
            else if (int.Parse(Find.Text) > randomPrice)
            {
                Indice.Text = "C'est moins !";
                tentative++;
            }
            else
            {
                Indice.Text = "Bravo, vous avez gagné !";
                Tenta.Text = "Vous avez fais " + tentative + " tentatives !";
                findBtn.IsEnabled = false;
            }
        }
    }
}
