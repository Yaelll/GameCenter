using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GameCenter.Projects.Simon
{
    /// <summary>
    /// Interaction logic for Simon.xaml
    /// </summary>
    public partial class Simon : Window
    {
        private ObservableCollection<string> simonSequence;
        private int sequenceIndex;
        public Simon()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            simonSequence = new ObservableCollection<string>();
            sequenceIndex = 0;
            DataContext = this;
        }

        private async void StartGame_Click(object sender, RoutedEventArgs e)
        {
            InitializeGame();
            await ShowSequence();
        }

        private async Task ShowSequence()
        {
            AddToSimonSequence();
            foreach (string color in simonSequence)
            {
                await HighlightButton(color);
                await Task.Delay(500);
                ResetButtonColor(color);
                await Task.Delay(200);
            }
            sequenceIndex = 0;
        }

        private void AddToSimonSequence()
        {
            Random random = new Random();
            int randomIndex = random.Next(4);
            string color = GetColorName(randomIndex);
            simonSequence.Add(color);
        }

        private async Task HighlightButton(string color)
        {
            Button button = FindButtonByName(color);
            button.IsEnabled = true;
            await Task.Delay(500);
            button.IsEnabled = false;
        }

        private void ResetButtonColor(string color)
        {
            Button button = FindButtonByName(color);
            button.IsEnabled = true;
        }

        private Button FindButtonByName(string color)
        {
            switch (color)
            {
                case "Red": return RedButton;
                case "Green": return GreenButton;
                case "Blue": return BlueButton;
                case "Yellow": return YellowButton;
                default: return null;
            }
        }

        private string GetColorName(int index)
        {
            switch (index)
            {
                case 0: return "Red";
                case 1: return "Green";
                case 2: return "Blue";
                case 3: return "Yellow";
                default: return string.Empty;
            }
        }

        private void SimonButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            string expectedColor = simonSequence[sequenceIndex];

            if (clickedButton.Content.ToString().ToLower() == expectedColor.ToLower())
            {
                sequenceIndex++;

                if (sequenceIndex == simonSequence.Count)
                {
                    sequenceIndex = 0;
                    _ = ShowSequence();
                }
            }
            else
            {
                MessageBox.Show("Wrong sequence! Game Over.", "Simon Game");
                InitializeGame();
            }
        }

    }
}

