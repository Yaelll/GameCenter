using GameCenter.Projects.Calculator;
using GameCenter.Projects.CarGame;
using GameCenter.Projects.CurrencyConverter;
using GameCenter.Projects.Simon;
using GameCenter.Projects.TicTacTow;
using GameCenter.Projects.TodoList;
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

namespace GameCenter
{
   
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            Image image = (sender as Image)!;
            image.Opacity = 0.7;
            GameText.Content = (image.Name) switch
            {
                "Image1" => "Simon Game",
                "Image2" => "To do List Project",
                "Image3" => "Currency Converter",
                "Image4" => "Car Game",
                "Image5" => "Tic Tac Tow",
                "Image6" => "Calculator",
                _ => "please pick an app"
            };
        }

        private void OnMouuseLeave(object sender, MouseEventArgs e)
        {
            (sender as Image)!.Opacity = 1;
        }

        private void Image1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Simon simonGame = new();
            Hide();
            simonGame.ShowDialog();
            Show();
        }

        private void Image2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TodoList toodoListProject = new();
            Hide();
            toodoListProject.ShowDialog();
            Show();
        }

        private void Image3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CurrencyConverterView currencyProject = new();
            Hide();
            currencyProject.ShowDialog();
            Show();
        }

        private void Image4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CarGame carGame = new();
            Hide();
            carGame.ShowDialog();
            Show();
        }
            private void Image5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
            {
                TicTacTow ticTacTowGame = new();
                Hide();
                ticTacTowGame.ShowDialog();
                Show();
            }
        private void Image6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Calculator calculator = new();
            Hide();
            calculator.ShowDialog();
            Show();
        }


    }
}


