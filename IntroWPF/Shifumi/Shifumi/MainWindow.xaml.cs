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

namespace Shifumi
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

        void PlayerChoice(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Player.Text = btn.Content.ToString();
        }

        void Game(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int iaChoice = rnd.Next(0, 3);

            switch (iaChoice)
            {
                case 0:
                    AI.Text = "Pierre";
                    break;

                case 1:
                    AI.Text = "Feuille";
                    break;

                case 2:
                    AI.Text = "Ciseaux";
                    break;
            }

            if(Player.Text == AI.Text)
            {
                Result.Text = "égalité !";
            }
            else if ((Player.Text == "Pierre" && AI.Text == "Ciseaux") ||
                     (Player.Text == "Feuille" && AI.Text == "Pierre") ||
                     (Player.Text == "Ciseaux" && AI.Text == "Feuille"))
            {
                Result.Text = "Gagné !";
            }
            else if ((Player.Text == "Pierre" && AI.Text == "Feuille") ||
                     (Player.Text == "Ciseaux" && AI.Text == "Pierre") ||
                     (Player.Text == "Feuille" && AI.Text == "Ciseaux"))
            {
                Result.Text = "Perdu !";
            }
        }
    }
}
