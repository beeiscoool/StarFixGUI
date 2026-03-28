namespace StarFixGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblPlayer = new Label();
            lblScore = new Label();
            lblLives = new Label();
            lblTimer = new Label();
            lblQuestion = new Label();
            txtName = new TextBox();
            btnStart = new Button();
            gameTimer = new System.Windows.Forms.Timer(components);
            lblEnterName = new Label();
            lblChoices = new Label();
            txtAnswer = new TextBox();
            label1 = new Label();
            btnSubmit = new Button();
            lblLevel = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Lime;
            lblTitle.Location = new Point(293, -3);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(732, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "STARFIX MISSION CONTROL";
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.BackColor = Color.Transparent;
            lblPlayer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(483, 345);
            lblPlayer.Margin = new Padding(4, 0, 4, 0);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(106, 29);
            lblPlayer.TabIndex = 1;
            lblPlayer.Text = "Player: -";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(483, 445);
            lblScore.Margin = new Padding(4, 0, 4, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(106, 29);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score: 0";
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.BackColor = Color.Transparent;
            lblLives.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLives.ForeColor = Color.White;
            lblLives.Location = new Point(483, 389);
            lblLives.Margin = new Padding(4, 0, 4, 0);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(101, 29);
            lblLives.TabIndex = 3;
            lblLives.Text = "Lives: 3";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(1276, 50);
            lblTimer.Margin = new Padding(4, 0, 4, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(109, 29);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "Time: 30";
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = Color.Transparent;
            lblQuestion.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.ForeColor = Color.Yellow;
            lblQuestion.Location = new Point(13, 147);
            lblQuestion.Margin = new Padding(4, 0, 4, 0);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(620, 80);
            lblQuestion.TabIndex = 5;
            lblQuestion.Text = "Press Start to begin";
            // 
            // txtName
            // 
            txtName.Location = new Point(585, 76);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 35);
            txtName.TabIndex = 10;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Yellow;
            btnStart.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(857, 62);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(222, 60);
            btnStart.TabIndex = 11;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // lblEnterName
            // 
            lblEnterName.AutoSize = true;
            lblEnterName.BackColor = Color.Transparent;
            lblEnterName.ForeColor = Color.White;
            lblEnterName.Location = new Point(333, 79);
            lblEnterName.Margin = new Padding(4, 0, 4, 0);
            lblEnterName.Name = "lblEnterName";
            lblEnterName.Size = new Size(216, 29);
            lblEnterName.TabIndex = 12;
            lblEnterName.Text = "Enter your name :";
            // 
            // lblChoices
            // 
            lblChoices.AutoSize = true;
            lblChoices.Location = new Point(13, 262);
            lblChoices.Name = "lblChoices";
            lblChoices.Size = new Size(135, 29);
            lblChoices.TabIndex = 13;
            lblChoices.Text = "CHOICES :";
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(138, 419);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(150, 35);
            txtAnswer.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 425);
            label1.Name = "label1";
            label1.Size = new Size(106, 29);
            label1.TabIndex = 15;
            label1.Text = "Answer:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Yellow;
            btnSubmit.Location = new Point(13, 502);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(169, 63);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.BackColor = Color.Red;
            lblLevel.Location = new Point(101, 19);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(66, 29);
            lblLevel.TabIndex = 17;
            lblLevel.Text = "level";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.oop_ass_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1683, 724);
            Controls.Add(lblLevel);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtAnswer);
            Controls.Add(lblChoices);
            Controls.Add(lblEnterName);
            Controls.Add(btnStart);
            Controls.Add(txtName);
            Controls.Add(lblQuestion);
            Controls.Add(lblTimer);
            Controls.Add(lblLives);
            Controls.Add(lblScore);
            Controls.Add(lblPlayer);
            Controls.Add(lblTitle);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "StarFix Mission Control";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPlayer;
        private Label lblScore;
        private Label lblLives;
        private Label lblTimer;
        private Label lblQuestion;
        private TextBox txtName;
        private Button btnStart;
        private System.Windows.Forms.Timer gameTimer;
        private Label lblEnterName;
        private Label lblChoices;
        private TextBox txtAnswer;
        private Label label1;
        private Button btnSubmit;
        private Label lblLevel;
    }
}
