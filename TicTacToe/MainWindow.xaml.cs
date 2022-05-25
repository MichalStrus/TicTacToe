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
        public bool IsPlayer1Turn { get; set; }
        public int Count { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        public void NewGame()
        {
            IsPlayer1Turn = false;
            Count = 0;
            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsPlayer1Turn ^= true; // za pomocą operacji bitowych zmienia wyrażenie z true na false i z false na true
            Count++;

            if (Count > 9)
            {
                NewGame();
                return;
            }
            var button = sender as Button;
            if (Convert.ToString(button.Content) == "X" && IsPlayer1Turn == false)
            {
                IsPlayer1Turn = true;
                Count--;
            }
            else if (Convert.ToString(button.Content) == "O" && IsPlayer1Turn == false)
            {
                IsPlayer1Turn = true;
                Count--;
            }
            else if (Convert.ToString(button.Content) == "O" && IsPlayer1Turn == true)
            {
                IsPlayer1Turn = false;
                Count--;
            }
            else if (Convert.ToString(button.Content) == "X" && IsPlayer1Turn == true)
            {
                IsPlayer1Turn = false;
                Count--;
            }
            else { button.Content = IsPlayer1Turn ? "O" : "X"; }

            if (CheckIfPlayerWon())
            {
                Count = 9;
            }
            /*if (IsPlayer1Turn)
                button.Content = "O";
            else
                button.Content = "X"; */
        }
        private bool CheckIfPlayerWon()
        {
            if (Convert.ToString(Button_0_0.Content) != string.Empty && 
                Button_0_0.Content == Button_0_1.Content && Button_0_0.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.DarkCyan;
                Button_0_1.Background = Brushes.DarkCyan;
                Button_0_2.Background = Brushes.DarkCyan;
                return true;
            }

            if (Convert.ToString(Button_1_0.Content) != string.Empty && 
                Button_1_0.Content == Button_1_1.Content && Button_1_0.Content  == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.DarkCyan;
                Button_1_1.Background = Brushes.DarkCyan;
                Button_1_2.Background = Brushes.DarkCyan;
                return true;
            }
            if(Convert.ToString(Button_2_0.Content) != string.Empty && 
                Button_2_0.Content == Button_2_1.Content && Button_2_0.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.DarkCyan;
                Button_2_1.Background = Brushes.DarkCyan;
                Button_2_2.Background = Brushes.DarkCyan;
                return true;                    
            }
            if (Convert.ToString(Button_0_0.Content) != string.Empty &&
                Button_0_0.Content == Button_1_0.Content && Button_0_0.Content  == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.DarkCyan;
                Button_1_0.Background = Brushes.DarkCyan;
                Button_2_0.Background = Brushes.DarkCyan;
                return true;
            }
            if (Convert.ToString(Button_0_1.Content) != string.Empty && 
                Button_0_1.Content == Button_1_1.Content && Button_0_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.DarkCyan;
                Button_1_1.Background = Brushes.DarkCyan;
                Button_2_1.Background = Brushes.DarkCyan;
                return true;
            }
            if (Convert.ToString(Button_0_2.Content) != string.Empty && 
                Button_0_2.Content == Button_1_2.Content && Button_0_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.DarkCyan;
                Button_1_2.Background = Brushes.DarkCyan;
                Button_2_2.Background = Brushes.DarkCyan;
                return true;
            }
            if (Convert.ToString(Button_0_0.Content) != string.Empty && 
                Button_0_0.Content == Button_1_1.Content && Button_0_0.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.DarkCyan;
                Button_1_1.Background = Brushes.DarkCyan;
                Button_2_2.Background = Brushes.DarkCyan;
                return true;
            }
            if (Convert.ToString(Button_0_2.Content) != string.Empty && 
                Button_0_2.Content == Button_1_1.Content && Button_2_0.Content == Button_0_2.Content)
            {
                Button_0_2.Background = Brushes.DarkCyan;
                Button_1_1.Background = Brushes.DarkCyan;
                Button_2_0.Background = Brushes.DarkCyan;
                return true;
            }
            return false;
        }
    }
}
