using System;
using System.Collections.Generic;

namespace StarFixGUI
{
    internal class Game
    {
        private Player player;
        private Spaceship ship;
        private List<Level> levels;
        private int currentLevelIndex;
        private int currentQuestionIndex;
        private int levelCorrectCount;

        public Player Player
        {
            get { return player; }
        }

        public Spaceship Ship
        {
            get { return ship; }
        }

        public List<Level> Levels
        {
            get { return levels; }
        }

        public int CurrentLevelIndex
        {
            get { return currentLevelIndex; }
        }

        public int CurrentQuestionIndex
        {
            get { return currentQuestionIndex; }
        }

        public string CurrentLevelName
        {
            get { return levels[currentLevelIndex].Name; }
        }

        public bool IsLevelComplete
        {
            get { return currentQuestionIndex >= levels[currentLevelIndex].Questions.Count; }
        }

        public bool IsLastLevel
        {
            get { return currentLevelIndex >= levels.Count - 1; }
        }

        public bool IsGameFinished
        {
            get { return currentLevelIndex >= levels.Count; }
        }

        public Game(string playerName)
        {
            player = new Player(playerName);
            ship = new Spaceship();
            levels = new List<Level>();
            currentLevelIndex = 0;
            currentQuestionIndex = 0;
            levelCorrectCount = 0;

            LoadData();
        }

        private void LoadData()
        {
            levels.Add(new Level("Level 1: Solar System Basics", new List<Question>
            {
                new SpaceQuizQuestion("Which is the Red Planet?",
                    new List<string> { "Mars", "Venus", "Earth" }, 0),

                new SpaceQuizQuestion("Which is closest to the Sun?",
                    new List<string> { "Mercury", "Mars", "Venus" }, 0),

                new SpaceQuizQuestion("What is our Galaxy?",
                    new List<string> { "Milky Way", "Andromeda", "Orion" }, 0),

                new SpaceQuizQuestion("Which planet is famous for having big, bright rings?",
                    new List<string> { "Mercury", "Earth", "Saturn" }, 2),

                new SpaceQuizQuestion("Hottest Planet?",
                    new List<string> { "Mercury", "Venus", "Mars" }, 1)
            }));

            levels.Add(new Level("Level 2: Deep Space Hazards", new List<Question>
            {
                new SpaceQuizQuestion("What is the closest star to Earth?",
                    new List<string> { "The Sun", "Sirius", "Polaris" }, 0),

                new SpaceQuizQuestion("How long does Earth take to orbit the Sun?",
                    new List<string> { "1 day", "1 month", "1 year" }, 2),

                new SpaceQuizQuestion("What year did humans first land on the Moon?",
                    new List<string> { "1969", "1959", "1920" }, 0),

                new SpaceQuizQuestion("First Human in Space?",
                    new List<string> { "Gagarin", "Armstrong", "Glenn" }, 0),

                new SpaceQuizQuestion("Main gas on Jupiter?",
                    new List<string> { "Oxygen", "Hydrogen", "Nitrogen" }, 1)
            }));
        }

        public Question GetCurrentQuestion()
        {
            if (IsGameFinished || IsLevelComplete)
                return null;

            return levels[currentLevelIndex].Questions[currentQuestionIndex];
        }

        public string SubmitAnswer(int choice)
        {
            Question currentQuestion = GetCurrentQuestion();

            if (currentQuestion == null)
                return "No current question available.";

            bool isCorrect = currentQuestion.CheckAnswer(choice);

            if (isCorrect)
            {
                player.AddPoint();
                ship.Repair();
                levelCorrectCount++;
                currentQuestionIndex++;
                return "Correct! " + ship.GetStatusMessage();
            }
            else
            {
                player.LoseLife();
                currentQuestionIndex++;
                return "Incorrect! Structural integrity is dropping.";
            }
        }

        public void RestartLevel()
        {
            ship.ResetProgress(levelCorrectCount);
            player.Lives = 3;
            currentQuestionIndex = 0;
            levelCorrectCount = 0;
        }

        public void ProceedToNextLevel()
        {
            if (!IsLastLevel)
            {
                currentLevelIndex++;
                currentQuestionIndex = 0;
                levelCorrectCount = 0;
                player.Lives = 3;
            }
            else
            {
                currentLevelIndex++;
            }
        }

        public bool HasPlayerLostLevel()
        {
            return player.Lives <= 0;
        }

        public string GetFinalMessage()
        {
            if (player.IsAlive() && IsGameFinished)
            {
                return "MISSION SUCCESS: The ship reached Earth safely.\nFinal Score: " + player.Score;
            }
            else if (!player.IsAlive())
            {
                return "MISSION FAILED: You lost all lives.\nFinal Score: " + player.Score;
            }
            else
            {
                return "MISSION ABORTED.";
            }
        }
    }
}