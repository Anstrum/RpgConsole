using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project;
using RPGConsole.Project.Enums;
using RPGConsole.Project.Units;
using RPGConsole.Project.Units.Class;

namespace RPGConsole.Project
{
    class Game
    {
        public string Name;
        private DifficultyLevel Difficulty;
        private Map Map;
        private bool Ended;
        private List<Character> Characters = new List<Character>();


        
        public bool IsOver()
        {
            return Ended;
        }

        public void Init(string Name, DifficultyLevel Difficulty, int GameDuration)
        {
            this.Name = Name;
            this.Difficulty = Difficulty;
            //Map = new Map(GameDuration);
        }
    }
}
