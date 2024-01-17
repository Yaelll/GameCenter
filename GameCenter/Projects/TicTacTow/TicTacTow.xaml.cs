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

namespace GameCenter.Projects.TicTacTow
{
    /// <summary>
    /// Interaction logic for TicTacTow.xaml
    /// </summary>
    public partial class TicTacTow : Window
    {
        private char _currentPlayer = 'X';
        private char[,] _gameBoard = new char[3, 3];

        public TicTacTow()
        {
            InitializeComponent();

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button != null && string.IsNullOrEmpty(button.Content as string))
            {
                button.Content = _currentPlayer.ToString();
                int row = Grid.GetRow(button);
                int column = Grid.GetColumn(button);
                _gameBoard[row, column] = _currentPlayer;

                if (CheckForWin())
                {
                    MessageBox.Show($"{_currentPlayer} wins!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                    ResetGame();
                }
                else
                {
                    if (IsBoardFull())
                    {
                        MessageBox.Show("It's a draw!", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetGame();
                    }
                    else
                    {
                        _currentPlayer = _currentPlayer == 'X' ? 'O' : 'X';
                    }
                }
            }
        }

        private bool CheckForWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (_gameBoard[i, 0] == _currentPlayer && _gameBoard[i, 1] == _currentPlayer && _gameBoard[i, 2] == _currentPlayer)
                    return true;
            }

            for (int i = 0; i < 3; i++)
            {
                if (_gameBoard[0, i] == _currentPlayer && _gameBoard[1, i] == _currentPlayer && _gameBoard[2, i] == _currentPlayer)
                    return true;
            }

            if (_gameBoard[0, 0] == _currentPlayer && _gameBoard[1, 1] == _currentPlayer && _gameBoard[2, 2] == _currentPlayer)
                return true;

            if (_gameBoard[0, 2] == _currentPlayer && _gameBoard[1, 1] == _currentPlayer && _gameBoard[2, 0] == _currentPlayer)
                return true;

            return false;
        }

        private void ResetGame()
        {
            _currentPlayer = 'X';
            _gameBoard = new char[3, 3];

            // Clear the game board
            foreach (Button button in MainGrid.Children)
            {
                button.Content = "";
            }
        }
        private bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (_gameBoard[i, j] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

    