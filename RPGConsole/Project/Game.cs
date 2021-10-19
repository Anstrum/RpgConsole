using System;
using System.Collections.Generic;
using System.Text;
using RPGConsole.Project;
using RPGConsole.Project.Units;
using RPGConsole.Project.Units.Class;


namespace RPGConsole.Project
{
    class Game
    {
        public string Name;
        private bool Ended;
        private List<Character> Characters = new List<Character>();
        private Map Map;


        public Game()
        {
        }


        public void Init(string Name, int GameDuration, int Difficulty)
        {
            this.Name = Name;
        }
    }
}
 