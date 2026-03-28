using System.Collections.Generic;

namespace StarFixGUI
{
    public class Level
    {
        private string levelName;
        private List<Question> questions;

        public string LevelName
        {
            get { return levelName; }
        }

        public List<Question> Questions
        {
            get { return questions; }
        }

        public Level(string levelName, List<Question> questions)
        {
            this.levelName = levelName;
            this.questions = questions;
        }
    }
}

