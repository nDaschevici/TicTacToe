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

namespace XandO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string player = "p1";
        public static int winner = 0;
        public MainWindow()///////////// Main Here
        {
            InitializeComponent();
        }
        // Button clicks
        public void B1_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B1.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B1.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B1.IsEnabled = false;
            CheckWinner();
        }

        public void B2_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B2.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";

            }
            else
            {
                B2.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B2.IsEnabled = false;
            CheckWinner();
        }

        public void B3_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B3.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B3.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B3.IsEnabled = false;
            CheckWinner();
        }

        public void B4_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B4.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B4.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B4.IsEnabled = false;
            CheckWinner();
        }
        public void B5_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B5.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B5.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B5.IsEnabled = false;
            CheckWinner();
        }

        public void B6_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B6.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B6.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B6.IsEnabled = false;
            CheckWinner();
        }

        public void B7_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B7.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B7.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B7.IsEnabled = false;
            CheckWinner();
        }

        public void B8_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B8.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B8.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B8.IsEnabled = false;
            CheckWinner();
        }

        public void B9_Click(object sender, RoutedEventArgs e)
        {
            if (player == "p1")
            {
                B9.Content = "X";
                player = "p2";
                //Turn();
                txtTurn.Text = "Turn: Player 2";
            }
            else
            {
                B9.Content = "O";
                player = "p1";
                //Turn();
                txtTurn.Text = "Turn: Player 1";
            }
            B9.IsEnabled = false;
            CheckWinner();
        }

        // Reset and Exit buttons - To Do
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            //Find another method to restart  <<<<<----------         TO DO
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void StopGame()
        {
            B1.IsEnabled = false;
            B2.IsEnabled = false;
            B3.IsEnabled = false;
            B4.IsEnabled = false;
            B5.IsEnabled = false;
            B6.IsEnabled = false;
            B7.IsEnabled = false;
            B8.IsEnabled = false;
            B9.IsEnabled = false;
        }

        //Score                        -------------------               Score here TO DO!!    
        public static void Score()
        {
            //To Do          
        }
        //Check Winner
        public void CheckWinner()
        {
            //Randurile
            if (B1.Content == B2.Content && B2.Content == B3.Content)
            {
                if (B1.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B1.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }

            }
            else if (B4.Content == B5.Content && B5.Content == B6.Content)
            {
                if (B4.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B4.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }
            }
            else if (B7.Content == B8.Content && B8.Content == B9.Content)
            {
                if (B7.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B7.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }
            }
            // Coloanele
            else if (B1.Content == B4.Content && B4.Content == B7.Content)
            {
                if (B7.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B7.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }
            }
            else if (B2.Content == B5.Content && B8.Content == B5.Content)
            {
                if (B5.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B5.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }
            }
            else if (B3.Content == B6.Content && B9.Content == B6.Content)
            {
                if (B3.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B3.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }
            }
            // Diagonalele
            else if (B1.Content == B5.Content && B9.Content == B5.Content)
            {
                if (B5.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B5.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }
            }
            else if (B3.Content == B5.Content && B7.Content == B5.Content)
            {
                if (B7.Content == "X")
                {
                    winner = 1;
                    txtTurn.Text = "Player 1 Won!";
                    StopGame();
                }
                else if (B7.Content == "O")
                {
                    winner = 2;
                    txtTurn.Text = "Player 2 Won!";
                    StopGame();
                }
            }
        }

        //Turn
        /*
                public void Turn()
                {

                    if (player == "p1")
                    {
                        txtTurn.Text = "Turn: Player 1";
                    }
                    else if (player == "p2")
                    {
                        txtTurn.Text = "Turn: Player 2";
                    }
 
                    if (winner == 1)
                    {
                        txtTurn.Text = "Player 1 won!";
                    }
                    else if (winner == 2)
                    {
                        txtTurn.Text = "Player 2 won!";
                    }

                }
         */


        ///End
    }
}
