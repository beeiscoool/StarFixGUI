using System;
using System.Windows.Forms;

namespace StarFixGUI
{
    public partial class Form1 : Form
    {
        private Game game;
        private int timeLeft;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            lblPlayer.Text = "Player: -";
            lblLevel.Text = "Level: 1";
            lblQuestion.Text = "Enter your name and press Start to begin.";
            lblChoices.Text = "";
            lblScore.Text = "Score: 0";
            lblLives.Text = "Lives: 3";
            lblTimer.Text = "Time: 30";

            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;

            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            gameTimer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name first.");
                return;
            }

            game = new Game(txtName.Text.Trim());

            lblPlayer.Text = "Player: " + game.Player.Name;
            txtAnswer.Enabled = true;
            btnSubmit.Enabled = true;

            DisplayQuestion();
            StartTimer();
        }

        private void DisplayQuestion()
        {
            if (game == null)
                return;

            Question q = game.GetCurrentQuestion();

            if (q == null)
            {
                EndGame();
                return;
            }

            lblPlayer.Text = "Player: " + game.Player.Name;
            lblLevel.Text = "Question: " + (game.CurrentQuestionIndex + 1);
            lblQuestion.Text = q.QuestionText;

            lblChoices.Text =
                "1. " + q.Options[0] + Environment.NewLine +
                "2. " + q.Options[1] + Environment.NewLine +
                "3. " + q.Options[2];

            lblScore.Text = "Score: " + game.Player.Score;
            lblLives.Text = "Lives: " + game.Player.Lives;

            txtAnswer.Clear();
            txtAnswer.Focus();
        }

        private void StartTimer()
        {
            timeLeft = 30;
            lblTimer.Text = "Time: " + timeLeft;
            gameTimer.Start();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Please start the game first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Please enter your answer first.");
                txtAnswer.Focus();
                return;
            }

            int userAnswer;

            if (!int.TryParse(txtAnswer.Text.Trim(), out userAnswer))
            {
                MessageBox.Show("Please enter only 1, 2, or 3.");
                txtAnswer.Clear();
                txtAnswer.Focus();
                return;
            }

            if (userAnswer < 1 || userAnswer > 3)
            {
                MessageBox.Show("Answer must be 1, 2, or 3 only.");
                txtAnswer.Clear();
                txtAnswer.Focus();
                return;
            }

            gameTimer.Stop();

            bool correct = game.SubmitAnswer(userAnswer - 1);

            if (correct)
                MessageBox.Show("Correct!");
            else
                MessageBox.Show("Wrong answer!");

            lblScore.Text = "Score: " + game.Player.Score;
            lblLives.Text = "Lives: " + game.Player.Lives;

            if (game.IsGameOver())
            {
                EndGame();
                return;
            }

            DisplayQuestion();
            StartTimer();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = "Time: " + timeLeft;

            if (timeLeft <= 0)
            {
                gameTimer.Stop();
                MessageBox.Show("Time's up!");

                if (game != null)
                {
                    game.Player.LoseLife();

                    lblScore.Text = "Score: " + game.Player.Score;
                    lblLives.Text = "Lives: " + game.Player.Lives;

                    if (game.HasMoreQuestions())
                    {
                        game.SubmitAnswer(-1);
                    }

                    if (game.IsGameOver())
                    {
                        EndGame();
                        return;
                    }

                    DisplayQuestion();
                    StartTimer();
                }
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();

            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;

            lblPlayer.Text = "Player: " + game.Player.Name;
            lblScore.Text = "Score: " + game.Player.Score;
            lblLives.Text = "Lives: " + game.Player.Lives;
            lblChoices.Text = "";
            lblTimer.Text = "Time: 0";

            if (game.IsWinner)
            {
                lblQuestion.Text = "Congratulations! Mission successful!";
                lblLevel.Text = "Completed";
                MessageBox.Show("Well done! You answered all questions.");
            }
            else
            {
                lblQuestion.Text = "Game Over!";
                lblLevel.Text = "Ended";
                MessageBox.Show("Game Over! " + game.GetFinalMessage());
            }
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                btnSubmit.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}