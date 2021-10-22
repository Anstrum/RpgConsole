using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project;
using RPGConsole.Project.Misc;
using RPGConsole.Project.Enums;
using RPGConsole.Project.Units;
using RPGConsole.Project.Units.Class;

//Experience Per Mob Lvl
/*       75 * (( 1 / 6 ) * Level * Level ) + 50           */


namespace RPGConsole.Project
{
    class Game
    {
        public string Name;
        private DifficultyLevel Difficulty;
        private Map Map;
        private bool Ended;
        private List<Character> Characters = new List<Character>();

        private Enum Test;

        public bool IsOver()
        {
            return Ended;
        }

        public void Init(string Name, DifficultyLevel Difficulty, int GameDuration)
        {
            this.Name = Name;
            this.Difficulty = Difficulty;
            //Map = new Map(GameDuration);
            for(int i = 0; i < Asker.AskChoice(new List<string>() { "1", "2", "3", "4" }, "Select team size:") + 1;  i++)
            {
                Console.Clear();

                Console.WriteLine("Character " + i + 1 + " Create your character");
                Asker.WaitKey();
                Console.Clear();
                CreateCharacter();
            }

            Console.Clear();

            foreach (Character Character in Characters)
            {
                Console.WriteLine("Character: " + Character.GetName());
                Console.WriteLine("Class: " + Character.GetClass());
                Console.WriteLine("Weapon: " + Character.GetWeaponClass());
                Asker.WaitKey();
                Console.Clear();
            }
        }


        void CreateCharacter()
        {
            Console.WriteLine(Enum.GetNames(typeof(CharacterClass)));
            string Name = Asker.AskEntry("Enter your name:");
            CharacterClass Class;
        }
    }
}
