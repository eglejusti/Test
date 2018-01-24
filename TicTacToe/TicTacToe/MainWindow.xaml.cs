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

namespace TicTacToe
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

        private void Button_Click(object sender, RoutedEventArgs e)
        { }


       

        

        private Player _player = Player.O; // false - x, true - 0 
        private int[,] _matrix = new int[,] {          // masyvas masyve
            { 0, 0, 0 },
            { 0, 0, 0 },
            { 0, 0, 0 }

        };

        private Player? DetermineWinner() //metodas kuri praeina matrica ir tikrina ar kruis nors surenka 3 is eiles. grazinam playeri kuris surinko
        {
            return null;

        }


        private void buttonClicked(object sender, RoutedEventArgs e)  //metodas
        {
            string coordinates = ((Button)sender).Tag.ToString();
            int x = int.Parse(coordinates[0].ToString()) - 1; //nes tagai blogi, matrica ima nuo 0. tai turejo but 01
            int y = int.Parse(coordinates[1].ToString()) - 1;



            if (_matrix[x, y] == 0)
            {
                _matrix[x, y] = (int)_player; //nes i matrica galima rasyti tik skaitine reiksme 

                Player? winner = DetermineWinner();
                if (winner != null)
                {
                    winnerLbl.Content = winner == Player.X ? "X" : "O" + " has won!";              
                }


                ((Button)sender).Content = _player == Player.O ? "0" : "x";
                ((Button)sender).Foreground = _player == Player.O ? Brushes.Blue : Brushes.Red;

                _player = _player == Player.O ? Player.X : Player.O;
            }         
        }
    }
}
