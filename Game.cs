using System;
using System.Collections.Generic;

namespace StarFixGUI
{
    internal class Game
    {
        private Player player;
        private List<Question> questions;
        private int currentQuestionIndex;
        private Random random;

        public Player Player
        {
            get { return player; }
        }

        public List<Question> Questions
        {
            get { return questions; }
        }

        public int CurrentQuestionIndex
        {
            get { return currentQuestionIndex; }
        }

        public bool IsWinner
        {
            get { return player.IsAlive() && currentQuestionIndex >= questions.Count; }
        }

        public Game(string playerName)
        {
            player = new Player(playerName, 3);
            questions = new List<Question>();
            random = new Random();
            currentQuestionIndex = 0;

            LoadQuestions();
            ShuffleQuestions();
        }

        private void LoadQuestions()
        {
            questions = new List<Question>
            {
                new Question("Which planet is known as the Red Planet?",
                    new List<string> { "Earth", "Mars", "Jupiter" }, 1),

                new Question("What is the name of our galaxy?",
                    new List<string> { "Andromeda", "Milky Way", "Orion" }, 1),

                new Question("What do stars mainly produce?",
                    new List<string> { "Water", "Energy", "Ice" }, 1),

                new Question("Which planet is the largest in our solar system?",
                    new List<string> { "Saturn", "Jupiter", "Neptune" }, 1)
            };
        }

        private void ShuffleQuestions()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                int j = random.Next(i, questions.Count);
                (questions[i], questions[j]) = (questions[j], questions[i]);
            }
        }

        public Question GetCurrentQuestion()
        {
            if (currentQuestionIndex < questions.Count)
                return questions[currentQuestionIndex];

            return null;
        }

        public bool SubmitAnswer(int choice)
        {
            Question currentQuestion = GetCurrentQuestion();
            if (currentQuestion == null)
                return false;

            bool isCorrect = currentQuestion.CheckAnswer(choice);

            if (isCorrect)
                player.AddScore(10);
            else
                player.LoseLife();

            currentQuestionIndex++;
            return isCorrect;
        }

        public bool HasMoreQuestions()
        {
            return currentQuestionIndex < questions.Count;
        }

        public bool IsGameOver()
        {
            return !player.IsAlive() || currentQuestionIndex >= questions.Count;
        }

        public string GetFinalMessage()
        {
            if (player.IsAlive())
                return $"Mission successful. Final Score: {player.Score}";
            else
                return $"Mission failed. Final Score: {player.Score}";
        }
    }
}