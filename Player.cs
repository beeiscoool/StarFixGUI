namespace StarFixGUI
{
    internal class Player
    {
        private string name;
        private int lives;
        private int score;

        public string Name
        {
            get { return name; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value.Trim();
                else
                    name = "Scientist";
            }
        }

        public int Lives
        {
            get { return lives; }
            set
            {
                if (value >= 0)
                    lives = value;
            }
        }

        public int Score
        {
            get { return score; }
            private set
            {
                if (value >= 0)
                    score = value;
            }
        }

        public Player(string name)
        {
            Name = name;
            Lives = 3;
            Score = 0;
        }

        public void AddPoint()
        {
            Score += 10;
        }

        public void AddScore(int points)
        {
            if (points > 0)
                Score += points;
        }

        public void LoseLife()
        {
            if (lives > 0)
                lives--;
        }

        public bool IsAlive()
        {
            return lives > 0;
        }

        public void ResetLives()
        {
            Lives = 3;
        }

        public void ResetScore()
        {
            Score = 0;
        }
    }
}