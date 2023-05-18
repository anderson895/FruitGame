using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Quiz_Game_in_Windows_Form_VS
{
    public partial class Form1 : Form
    {
        // quiz game variables
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 8;
        }
        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.strawverry;
                    lblQuestion.Text = "1. what kind of fruit is this?";

                    button1.Text = "Straw Verry";
                    button2.Text = "Orange";
                    button3.Text = "Mango";
                    button4.Text = "Apple";

                    correctAnswer = 1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.mango;
                    lblQuestion.Text = "2. what kind of fruit is this?";

                    button1.Text = "Staw Verry";
                    button2.Text = "Orange";
                    button3.Text = "Mango";
                    button4.Text = "Apple";

                    correctAnswer = 3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.apple;
                    lblQuestion.Text = "3. what kind of fruit is this?";
                    button1.Text = "Apple";
                    button2.Text = "Orange";
                    button3.Text = "Avocado";
                    button4.Text = "Coconut";
                    correctAnswer = 1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.avocado;
                    lblQuestion.Text = "4. what kind of fruit is this?";
                    button1.Text = "Coconut";
                    button2.Text = "Orange";
                    button3.Text = "Grapes";
                    button4.Text = "Avocado";
                    correctAnswer = 4;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.banana;
                    lblQuestion.Text = "5. what kind of fruit is this?";
                    button1.Text = "Banana";
                    button2.Text = "Avocado";
                    button3.Text = "Orange";
                    button4.Text = "Coconut";
                    correctAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.fineaple;
                    lblQuestion.Text = "6. what kind of fruit is this?";
                    button1.Text = "Blue Verry";
                    button2.Text = "Grapes";
                    button3.Text = "Orange";
                    button4.Text = "Pineapple";
                    correctAnswer = 4;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.grapes;
                    lblQuestion.Text = "7. what kind of fruit is this?";
                    button1.Text = "Orange";
                    button2.Text = "Coconut";
                    button3.Text = "Grapes";
                    button4.Text = "Lemon";
                    correctAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.melon;
                    lblQuestion.Text = "8. what kind of fruit is this?";
                    button1.Text = "wintermelon";
                    button2.Text = "Wintermelon";
                    button3.Text = "Watermelon";
                    button4.Text = "Waterlemon";
                    correctAnswer = 3;
                   
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu MainMenu = new menu();  // Create an instance of Form1
            MainMenu.Show();  // Show Form1
            this.Hide();  // Hide the current form (menu.cs)
        }
    }
}