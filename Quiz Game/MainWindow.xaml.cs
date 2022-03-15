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
            //si la respuesta riene el tag 1 score++
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
            StartGame();
        }
        private void NextQuestion() {
        

            if (qNum < questionNumber.Count)
            {
                i = questionNumber[qNum];
            }
            else
            {
                restartGame();
            }
            foreach (var x in myGrid.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.Khaki;
            }
            switch (i)
            {
                case 1:
                    txtQuestion.Text = "Question 1 : 3+7";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/1.jpg"));
                    break;
                case 2:
                    txtQuestion.Text = "Question 2 : 3+7";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/2.jpg"));
                    break;
                case 3:
                    txtQuestion.Text = "Question 3 : 10+7";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "17";
                    Ans4.Content = "9";
                    Ans3.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/3.jpg"));
                    break;
                case 4:
                    txtQuestion.Text = "Question 4 : 3-7";
                    Ans1.Content = "4";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/4.jpg"));
                    break;
                case 5:
                    txtQuestion.Text = "Question 5 : 3+7-1";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans4.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/5.jpg"));
                    break;
                case 6:
                    txtQuestion.Text = "Question 6 : 3+7";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/6.jpg"));
                    break;
                case 7:
                    txtQuestion.Text = "Question 7 : 30+0";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "30";
                    Ans1.Tag = "4";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/7.jpg"));
                    break;
                case 8:
                    txtQuestion.Text = "Question 8 : 3+7";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/8.jpg"));
                    break;
                case 9:
                    txtQuestion.Text = "Question 9 : 3+7";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/9.jpg"));
                    break;
                case 10:
                    txtQuestion.Text = "Question 10 : 3+7";
                    Ans1.Content = "10";
                    Ans2.Content = "20";
                    Ans3.Content = "5";
                    Ans4.Content = "9";
                    Ans1.Tag = "1";
                    qImage.Source = new BitmapImage(new Uri("C:/Users/mariu/source/repos/Quiz Game/Quiz Game/Imagines/10.jpg"));
                    break;
            }
        }
        private void StartGame() {
            var randomList = questionNumber.OrderBy(a => Guid.NewGuid()).ToList();
            questionNumber = randomList;
            questionOrder.Content = null;
            for (int i = 0; i < questionNumber.Count; i++)
            {
                questionOrder.Content += " " + questionNumber[i].ToString();

            }

        }

    }
}
