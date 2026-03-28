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
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
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
            set
            {
                if (value >= 0)
                    score = value;
            }
        }

        public Player(string name, int lives)
        {
            this.name = name;
            this.lives = lives;
            score = 0;
        }

        public void AddScore(int points)
        {
            score += points;
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
    }
}