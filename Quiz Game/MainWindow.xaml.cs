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

namespace Quiz_Game
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionNumber = new List<int> {1,2,3,4,5,6,7,8,9,10 };
        int qNum=0;
        int i;
        int score;
        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();

        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;
            if (senderButton.Tag.ToString()=="1")
            {
                score++;
            }
            if (qNum<0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }
            scoreText.Content = "Answered Correctly " + score + "/" + questionNumber.Count;
            NextQuestion();
        }
        private void restartGame()
        {
            score = 0;
            qNum = -1;
        }
        private void NextQuestion() { }
        private void StartGame() { }

    }
}
