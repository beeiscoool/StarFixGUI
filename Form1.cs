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
            lblLevel.Text = "Level: -";
            lblQuestion.Text = "Enter your name and press Start to begin your mission.";
            lblChoices.Text = "";
            lblScore.Text = "Score: 0";
            lblLives.Text = "Lives: 3";
            lblTimer.Text = "Time: 30";

            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;

            gameTimer.Interval = 1000;
            gameTimer.Stop();
            gameTimer.Tick += gameTimer_Tick;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name first.", "Missing Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            game = new Game(txtName.Text.Trim());

            txtAnswer.Enabled = true;
            btnSubmit.Enabled = true;
            txtName.Enabled = false;
            btnStart.Enabled = false;

            LoadQuestion();
            StartTimer();
        }

        private void LoadQuestion()
        {
            if (game == null)
                return;

            if (game.IsGameFinished)
            {
                EndGame();
                return;
            }

            if (game.IsLevelComplete)
            {
                HandleLevelCompletion();
                return;
            }

            Question q = game.GetCurrentQuestion();

            if (q == null)
            {
                EndGame();
                return;
            }

            lblPlayer.Text = "Player: " + game.Player.Name;
            lblLevel.Text = game.CurrentLevelName;
            lblQuestion.Text = q.GetFormattedQuestion();

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

        private void StopTimer()
        {
            gameTimer.Stop();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                MessageBox.Show("Please start the game first.", "Game Not Started",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAnswer.Text))
            {
                MessageBox.Show("Please enter your answer first.", "No Answer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnswer.Focus();
                return;
            }

            int userAnswer;
            if (!int.TryParse(txtAnswer.Text.Trim(), out userAnswer))
            {
                MessageBox.Show("Please enter only 1, 2, or 3.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnswer.Clear();
                txtAnswer.Focus();
                return;
            }

            if (userAnswer < 1 || userAnswer > 3)
            {
                MessageBox.Show("Answer must be 1, 2, or 3 only.", "Invalid Choice",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnswer.Clear();
                txtAnswer.Focus();
                return;
            }

            StopTimer();

            string resultMessage = game.SubmitAnswer(userAnswer - 1);

            lblScore.Text = "Score: " + game.Player.Score;
            lblLives.Text = "Lives: " + game.Player.Lives;

            MessageBox.Show(resultMessage, "Mission Update",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (game.HasPlayerLostLevel())
            {
                MessageBox.Show(
                    "Critical failure. You lost all lives.\nThis level will restart.",
                    "Level Restart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                game.RestartLevel();
                LoadQuestion();
                StartTimer();
                return;
            }

            if (game.IsLevelComplete)
            {
                HandleLevelCompletion();
                return;
            }

            LoadQuestion();
            StartTimer();
        }

        private void HandleLevelCompletion()
        {
            StopTimer();

            if (game.IsLastLevel)
            {
                game.ProceedToNextLevel();
                EndGame();
                return;
            }

            DialogResult result = MessageBox.Show(
                "LEVEL STABILIZED!\nProceed to the next level?",
                "Level Complete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                game.ProceedToNextLevel();
                LoadQuestion();
                StartTimer();
            }
            else
            {
                EndGame();
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            lblTimer.Text = "Time: " + timeLeft;

            if (timeLeft <= 0)
            {
                StopTimer();

                MessageBox.Show("Time's up! You lost 1 life.", "Timer",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                game.Player.LoseLife();

                lblScore.Text = "Score: " + game.Player.Score;
                lblLives.Text = "Lives: " + game.Player.Lives;

                if (game.HasPlayerLostLevel())
                {
                    MessageBox.Show(
                        "Critical failure. You lost all lives.\nThis level will restart.",
                        "Level Restart",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    game.RestartLevel();
                    LoadQuestion();
                    StartTimer();
                    return;
                }

                // move to next question after timeout
                game.SubmitAnswer(-1);

                if (game.IsLevelComplete)
                {
                    HandleLevelCompletion();
                    return;
                }

                if (game.IsGameFinished)
                {
                    EndGame();
                    return;
                }

                LoadQuestion();
                StartTimer();
            }
        }

        private void EndGame()
        {
            StopTimer();

            txtAnswer.Enabled = false;
            btnSubmit.Enabled = false;
            txtName.Enabled = true;
            btnStart.Enabled = true;

            if (game != null)
            {
                lblPlayer.Text = "Player: " + game.Player.Name;
                lblScore.Text = "Score: " + game.Player.Score;
                lblLives.Text = "Lives: " + game.Player.Lives;
                lblQuestion.Text = game.GetFinalMessage();
            }
            else
            {
                lblQuestion.Text = "Mission ended.";
            }

            lblChoices.Text = "";
            lblLevel.Text = "Mission Ended";
            lblTimer.Text = "Time: 0";
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnSubmit.Enabled)
            {
                btnSubmit.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}