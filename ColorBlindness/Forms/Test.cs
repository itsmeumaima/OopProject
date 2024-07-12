using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3.Forms
{
    public partial class Test : Form
    {
        //attributes
        private int currentQuestion = 1;
        private int totalQuestions = 14;
        private string[] correctAnswers = { "12", "8", "29", "5", "3", "15", "74", "6", "45", "5", "7", "16", "73", "26" };
        private int correctCount = 0;
        private bool testCompleted = false;
        //Constructor
        public Test()
        {
            InitializeComponent();
            UpdateQuestionNumber();
            LoadQuestion(currentQuestion);
        }
        //member functions
        private void UpdateQuestionNumber()
        {
            lblQuestionNumber.Text = $"Question {currentQuestion} of {totalQuestions}";
        }
        private void LoadQuestion(int questionNumber)
        {
            try
            {
                //Application.StartupPath returns where our app is running
                //and combines it with path to Images directory
                string imageDirectory = Path.Combine(Application.StartupPath, "Images");
                // variable to store name of img in folder Images
                string imageName = $"{questionNumber}.png";
                //Combine the directory path (imageDirectory) with the image file name
                string imagePath = Path.Combine(imageDirectory, imageName);

                if (File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show($"Image file not found: {imagePath}");
                    pictureBox.Image = null; // Clears the pictureBox if image not found
                }
                txtAnswer.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                pictureBox.Image = null; // Clear the pictureBox in case of error
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestion < totalQuestions)
            {
                currentQuestion++;
                UpdateQuestionNumber();
                LoadQuestion(currentQuestion);
            }
        }
        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (testCompleted)
            {
                MessageBox.Show("Test has already been completed. Click 'Restart' to start over.");
                return;
            }
            string userAnswer = txtAnswer.Text.Trim();
            string correctAnswer = correctAnswers[currentQuestion - 1]; // -1 because arrays are 0-indexed
            if (userAnswer.Equals(correctAnswer))
            {
                correctCount++;
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show($"Incorrect. The correct answer is {correctAnswer}");
            }

            if (currentQuestion == totalQuestions)
            {
                CalculateResult();
            }
            else
            {
                currentQuestion++;
                UpdateQuestionNumber();
                LoadQuestion(currentQuestion);
            }
        }
        private void CalculateResult()
        {
            double percentage = (short)correctCount / totalQuestions * 100;
            lblResult.Text = $"Result: {percentage}% correct";

            string diagnosis = DetermineColorBlindness();
            lblDetails.Text = $"Details: {diagnosis}";

            testCompleted = true;
            btnSubmitAnswer.Enabled = false;
            btnNext.Enabled = false;
        }
        //The current passing score is 12 correct of 14 red/green test plates 
        private string DetermineColorBlindness()
        {
            if (correctCount == totalQuestions)
            {
                return "No color blindness detected.";
            }
            else if (correctCount < 12)
            {
                return "You may have color blindness.";
            }
            else
            {
                return "No color blindness detected.";
            }
        }


        private void btnRestart_Click(object sender, EventArgs e)
        {
            currentQuestion = 1;
            correctCount = 0;
            testCompleted = false;
            lblResult.Text = "Result: Not yet tested";
            lblDetails.Text = "Details: ";
            UpdateQuestionNumber();
            LoadQuestion(currentQuestion);
            btnSubmitAnswer.Enabled = true;
            btnNext.Enabled = true;
        }

        private void lblTitle_Click(object sender, EventArgs e) { }

        private void pictureBox_Click(object sender, EventArgs e) { }

        private void Test_Load(object sender, EventArgs e)
        {
                                            
        }
    }
}

