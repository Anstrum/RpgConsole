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
        List<Character> Characters = new List<Character>();
        public Game()
        {
            Knight Nanaka = new Knight();
            Character Wishk = new Barbarian();
            Character Xfactors = new Mage();
            Character Jaetan = new Rogue();
            Map Map = new Map();
        }


        public void Init(string GameDuration, int Difficulty, int CharacterAmount)
        {
            for(int i = 0; i < CharacterAmount; i++)
            {

            }
        }
    }
}
 