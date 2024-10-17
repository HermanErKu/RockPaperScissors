using System.Windows;
using System.Windows.Media;

namespace RockPaperScissors
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


        public void NewRound(int yourMove)
        {
            Random random = new Random();
            int computerMove = random.Next(0, 3);

            if (computerMove == yourMove) 
            {
                resultText.Foreground = Brushes.Black;
                resultText.Text = "Tie, you have the same";
                switch(yourMove) { 
                    case 0: computerMoveText.Text = "Rock"; break; 
                    case 1: computerMoveText.Text = "Paper"; break;
                    case 2: computerMoveText.Text = "Scissors"; break; 
                }
            }

            switch (yourMove)
            {
                case 0:
                    if (computerMove == 2) { resultText.Foreground = Brushes.Green; resultText.Text = "You won :)"; computerMoveText.Text = "Paper"; }
                    if (computerMove == 1) { resultText.Foreground = Brushes.Red; resultText.Text = "You lost :("; computerMoveText.Text = "Scissors"; }
                    break;

                case 1:
                    if (computerMove == 2) { resultText.Foreground = Brushes.Red; resultText.Text = "You lost :("; computerMoveText.Text = "Rock"; }
                    if (computerMove == 0) { resultText.Foreground = Brushes.Green; resultText.Text = "You won :)"; computerMoveText.Text = "Scissors"; }
                    break;
                
                case 2:
                    if (computerMove == 1) { resultText.Foreground = Brushes.Green; resultText.Text = "You won :)"; computerMoveText.Text = "Rock"; }
                    if (computerMove == 0) { resultText.Foreground = Brushes.Red; resultText.Text = "You lost :("; computerMoveText.Text = "Paper"; }
                    break;
            }
        }

        private void RockButtonHandler(object sender, RoutedEventArgs e) 
        {
            yourMoveText.Text = "Rock";
            NewRound(0);
        }
        private void PaperButtonHandler(object sender, RoutedEventArgs e) 
        {
            yourMoveText.Text = "Paper";
            NewRound(1);
        }
        private void ScissorsButtonHandler(object sender, RoutedEventArgs e) 
        {
            yourMoveText.Text = "Scissors";
            NewRound(2);
        }
    }
}