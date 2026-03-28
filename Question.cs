using System;
using System.Collections.Generic;

namespace StarFixGUI
{
    // Abstraction
    public abstract class Question
    {
        // Encapsulation
        private string questionText;
        private List<string> options;
        private int correctAnswer;

        // Public read-only properties
        public string QuestionText
        {
            get { return questionText; }
        }

        public List<string> Options
        {
            get { return options; }
        }

        protected int CorrectAnswer
        {
            get { return correctAnswer; }
        }

        // Constructor
        protected Question(string questionText, List<string> options, int correctAnswer)
        {
            this.questionText = questionText;
            this.options = options;
            this.correctAnswer = correctAnswer;
        }

        // Polymorphism: child classes must implement this
        public abstract string GetFormattedQuestion();

        // Virtual method so child classes can override if needed
        public virtual bool CheckAnswer(int userAnswer)
        {
            return userAnswer == correctAnswer;
        }
    }

    // Inheritance
    public class SpaceQuizQuestion : Question
    {
        public SpaceQuizQuestion(string questionText, List<string> options, int correctAnswer)
            : base(questionText, options, correctAnswer)
        {
        }

        // Polymorphism: method overriding
        public override string GetFormattedQuestion()
        {
            return "[MISSION DATA]: " + QuestionText;
        }

        // Optional override
        public override bool CheckAnswer(int userAnswer)
        {
            return base.CheckAnswer(userAnswer);
        }
    }
}