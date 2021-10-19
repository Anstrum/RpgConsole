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

            CreateCharacters(Asker.AskChoice(new List<string>() { "1", "2", "3", "4"}, "Select team size:") + 1);




        }


        void CreateCharacters(int TeamLength)
        {
            for(int i = 1; i <= TeamLength; i++)
            {
                string Name = Asker.AskEntry("Character " + i + " enter your name:");
                CharacterClass Class;
                WeaponClass WeaponClass;

                switch (Asker.AskChoice(new List<string>() { CharacterClass.Barbarian.ToString(), CharacterClass.Knight.ToString(), CharacterClass.Mage.ToString(), CharacterClass.Rogue.ToString() }, "Character " + i + " select your class"))
                {
                    case 0:
                        Class = CharacterClass.Barbarian;
                        break;
                    case 1:
                        Class = CharacterClass.Knight;
                        break;
                    case 2:
                        Class = CharacterClass.Mage;
                        break;
                    case 3:
                        Class = CharacterClass.Rogue;
                        break;
                    default:
                        Class = CharacterClass.Knight;
                        break;
                }
                switch (Asker.AskChoice(new List<string>() { WeaponClass.Ranged.ToString(), WeaponClass.TwoHanded.ToString(), WeaponClass.OneHanded.ToString(), WeaponClass.Magical.ToString() }, "Character " + i + " select your weapon speciality"))
                {
                    case 0:
                        WeaponClass = WeaponClass.Ranged;
                        break;
                    case 1:
                        WeaponClass = WeaponClass.TwoHanded;
                        break;
                    case 2:
                        WeaponClass = WeaponClass.OneHanded;
                        break;
                    case 3:
                        WeaponClass = WeaponClass.Magical;
                        break;
                    default:
                        WeaponClass = WeaponClass.OneHanded;
                        break;
                }
                switch(Class)
                {
                    case CharacterClass.Barbarian:
                        Characters.Add(new Barbarian(Name, WeaponClass));
                        break;
                    case CharacterClass.Knight:
                        Characters.Add(new Knight(Name, WeaponClass));
                        break;
                    case CharacterClass.Mage:
                        Characters.Add(new Mage(Name, WeaponClass));
                        break;
                    case CharacterClass.Rogue:
                        Characters.Add(new Rogue(Name, WeaponClass));
                        break;
                }
            }
        }
    }
}
