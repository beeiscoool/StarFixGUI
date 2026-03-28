using System.Collections.Generic;

namespace StarFixGUI
{
    internal class Level
    {
        private string name;
        private List<Question> questions;

        public string Name
        {
            get { return name; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value.Trim();
                else
                    name = "Unnamed Level";
            }
        }

        public List<Question> Questions
        {
            get { return questions; }
            private set
            {
                if (value != null)
                    questions = value;
                else
                    questions = new List<Question>();
            }
        }

        public int QuestionCount
        {
            get { return questions.Count; }
        }

        public Level(string name, List<Question> questions)
        {
            Name = name;
            Questions = questions;
        }

        public Question GetQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
                return questions[index];

            return null;
        }
    }
}