using System.Collections.Generic;

namespace StarFixGUI
{
    public class Question
    {
        private string questionText;
        private List<string> options;
        private int correctAnswer;

        public string QuestionText
        {
            get { return questionText; }
        }

        public List<string> Options
        {
            get { return options; }
        }

        public int CorrectAnswer
        {
            get { return correctAnswer; }
        }

        public Question(string questionText, List<string> options, int correctAnswer)
        {
            this.questionText = questionText;
            this.options = options;
            this.correctAnswer = correctAnswer;
        }

        public bool CheckAnswer(int userAnswer)
        {
            return userAnswer == correctAnswer;
        }
    }
}