using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TicTacToe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        bool player1turn = true;
        private string click(Button b)
        {
            if (b.Content.ToString() != "")
                return b.Content.ToString();
            if (player1turn)
            {
                player1turn = false;
                turnTextBlock.Text = "Player 2 Turn";
                return "X";
            }
            else
            {
                player1turn = true;
                turnTextBlock.Text = "Player 1 Turn";
                return "O";
            }
        }

        void check()
        {
            string[,] board = new string[3, 3];
            board[0, 0] = button1.Content.ToString();
            board[0, 1] = button2.Content.ToString();
            board[0, 2] = button3.Content.ToString();
            board[1, 0] = button4.Content.ToString();
            board[1, 1] = button5.Content.ToString();
            board[1, 2] = button6.Content.ToString();
            board[2, 0] = button7.Content.ToString();
            board[2, 1] = button8.Content.ToString();
            board[2, 2] = button9.Content.ToString();

            if(board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2] && board[0, 0] != "")
            {
                _ = new MessageDialog("Winner is: " + board[0, 0]).ShowAsync();
                resetboard();
            }
            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2] && board[1, 0] != "")
            {
                _ = new MessageDialog("Winner is: " + board[1, 0]).ShowAsync();
                resetboard();
            }
            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2] && board[2, 0] != "")
            {
                _ = new MessageDialog("Winner is: " + board[2, 0]).ShowAsync();
                resetboard();
            }
            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0] && board[0, 0] != "")
            {
                _ = new MessageDialog("Winner is: " + board[0, 0]).ShowAsync();
                resetboard();
            }
            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1] && board[0, 1] != "")
            {
                _ = new MessageDialog("Winner is: " + board[0, 1]).ShowAsync();
                resetboard();
            }
            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2] && board[0, 2] != "")
            {
                _ = new MessageDialog("Winner is: " + board[0, 2]).ShowAsync();
                resetboard();
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != "")
            {
                _ = new MessageDialog("Winner is: " + board[0, 0]).ShowAsync();
                resetboard();
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != "")
            {
                _ = new MessageDialog("Winner is: " + board[2, 0]).ShowAsync();
                resetboard();
            }
            if (board[0, 0] != "" && board[1, 0] != "" && board[2, 0] != "" && board[0, 1] != "" && board[1, 1] != "" && board[2, 1] != "" && board[0, 2] != "" && board[1, 2] != "" && board[2, 2] != "")
            {
                _ = new MessageDialog("Draw").ShowAsync();
                resetboard();
            }
        }

        void resetboard()
        {
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = click(button1);
            check();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            button2.Content = click(button2);
            check();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            button3.Content = click(button3);
            check();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            button5.Content = click(button5);
            check();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            button4.Content = click(button4);
            check();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            button6.Content = click(button6);
            check();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            button8.Content = click(button8);
            check();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            button7.Content = click(button7);
            check();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            button9.Content = click(button9);
            check();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
