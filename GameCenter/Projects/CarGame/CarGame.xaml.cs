using CarGames;
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
using System.Windows.Threading;

namespace GameCenter.Projects.CarGame
{
    /// <summary>
    /// Interaction logic for CarGame.xaml
    /// </summary>
    public partial class CarGame : Window
    {

        private PlayerCar playerCar;
        private List<Obstacle> obstacles;
        private Random ramdom;
        int score = 0;

        public CarGame()
        {
            InitializeComponent();
            playerCar = new PlayerCar(200, 300, 2,CarImage);
            obstacles = new List<Obstacle>();
            ramdom = new Random();

            DispatcherTimer gameTimer = new DispatcherTimer();
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Tick += GameLoop;
            gameTimer.Start();
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    playerCar.LeftKeyPressed = true;
                    break;
                case Key.Right:
                    playerCar.RightKeyPressed = true;
                    break;
            }
        }
        protected override void OnPreviewKeyUp(KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    playerCar.LeftKeyPressed = false;
                    break;
                case Key.Right:
                    playerCar.RightKeyPressed = false;
                    break;
            }
        }
        private void GameLoop(object sender, EventArgs e)
        {
            playerCar.Move();

            if (ramdom.Next(0, 50) == 1)
            {
                Image obstacleImage = new Image();
                obstacleImage.Source = new BitmapImage(new Uri("C:\\Users\\yaelu\\Desktop\\C#\\Project\\GameCenter\\GameCenter\\Projects\\CarGame\\Images\\Bomb.png"));
                obstacleImage.Width = 50;
                obstacleImage.Height = 50;
                Obstacle obstacle = new Obstacle(ramdom.Next(0, (int)Width), 0, 2, obstacleImage);
                obstacles.Add(obstacle);
                gameCanvas.Children.Add(obstacleImage);
            }
            double collisionBuffer = 5;

            foreach (var obstacle in obstacles)
            {
                obstacle.Move();
                if (playerCar.Representation.Margin.Left + playerCar.Representation.Width - collisionBuffer >= obstacle.Representation.Margin.Left + collisionBuffer
                    && playerCar.Representation.Margin.Left + collisionBuffer <= obstacle.Representation.Margin.Left + obstacle.Representation.Width - collisionBuffer
                    && playerCar.Representation.Margin.Top + collisionBuffer <= obstacle.Representation.Margin.Top + obstacle.Representation.Height - collisionBuffer
                    && playerCar.Representation.Margin.Top + playerCar.Representation.Height - collisionBuffer >= obstacle.Representation.Margin.Top + collisionBuffer)
                {
                    // End the game
                    MessageBox.Show("Game Over");
                    (sender as DispatcherTimer).Stop();
                    break;
                }

                if (obstacle.Y == 450 || obstacle.X == 800)
                {
                    score+=5;
                    scoreTextBlock.Text = "Score: " + score.ToString();
                    if (score == 100)
                    {
                        MessageBox.Show("You Win");

                        (sender as DispatcherTimer).Stop();
                        break;
                    }
                }
            }
        }
        
    }
}
