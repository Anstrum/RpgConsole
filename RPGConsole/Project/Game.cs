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


        #region Init
        public void Init(string Name, DifficultyLevel Difficulty, int GameDuration)
        {
            this.Name = Name;
            this.Difficulty = Difficulty;

            Map = new Map(GameDuration);
            List<string> Choices = new List<string>() {"Oui", "Non", "Revoir la map" };
            int Choice = 4;
            bool Regenerate = true;
            bool ShowMap = true;
            do
            {
                if(Regenerate)
                {
                    Map.Generate(GameDuration);
                    Regenerate = false;
                }
                if(ShowMap)
                {
                    Map.Draw();
                    Asker.WaitKey();
                    ShowMap = false;
                }

                Choice = Asker.AskChoice(Choices, "Do you want to use this map:");

                switch(Choice)
                {
                    case 1:
                        Regenerate = true;
                        ShowMap = true;
                        break;
                    case 2:
                        ShowMap = true;
                        break;
                }
                Console.Clear();
            } while (Choice != 0);



            int TeamSize = Asker.AskChoice(new List<string>() { "1", "2", "3", "4" }, "Select team size:");
            for (int i = 0; i < TeamSize + 1;  i++)
            {
                Console.Clear();
                Console.WriteLine("Character " + (i+1) + " Create your character");
                Asker.WaitKey();
                Console.Clear();
                CreateCharacter();
            }
            Console.Clear();

            foreach (Character Character in Characters)
            {
                Console.WriteLine("Character: " + Character.GetName());
                Console.WriteLine("Class: " + Character.GetClass());
                Console.WriteLine("Weapon: " + Character.GetWeapon().GetInfo().Key) ;
                Console.WriteLine("Weapon Class: " + Character.GetWeapon().GetInfo().Value.ToString());
                Asker.WaitKey();
                Console.Clear();
            }
        }
        

        void CreateCharacter()
        {
            string Name = Asker.AskEntry("Enter your name:");
            CharacterClass Class;
            int Answer = 0;
            List<string> Choices = new List<string>();
            foreach(string characterClass in Enum.GetNames(typeof(CharacterClass)))
            {
                Choices.Add(characterClass);
            }

            Answer = Asker.AskChoice(Choices, "Select your class");
            Class = (CharacterClass)Enum.Parse(typeof(CharacterClass), Enum.GetNames(typeof(CharacterClass))[Answer]);
            
            switch(Class)
            {
                case CharacterClass.Alchemist:
                    Characters.Add(new Alchemist(Name));
                    break;
                case CharacterClass.Barbarian:
                    Characters.Add(new Barbarian(Name));
                    break;
                case CharacterClass.Blacksmith:
                    Characters.Add(new Blacksmith(Name));
                    break;
                case CharacterClass.Hunter:
                    Characters.Add(new Hunter(Name));
                    break;
                case CharacterClass.Knight:
                    Characters.Add(new Knight(Name));
                    break;
                case CharacterClass.Mage:
                    Characters.Add(new Mage(Name));
                    break;
                case CharacterClass.Mystic:
                    Characters.Add(new Mystic(Name));
                    break;
                case CharacterClass.Necromancer:
                    Characters.Add(new Necromancer(Name));
                    break;
                case CharacterClass.Paladin:
                    Characters.Add(new Paladin(Name));
                    break;
                case CharacterClass.Priest:
                    Characters.Add(new Priest(Name));
                    break;
                case CharacterClass.Trapper:
                    Characters.Add(new Trapper(Name));
                    break;
            }

            Choices.Clear();

            List<WeaponClass> CharacterWeapons = Characters[Characters.Count - 1].GetWeaponClass();
            foreach(KeyValuePair<string, WeaponClass> Weapon in Weapons.WeaponList)
            {
                foreach (WeaponClass Type in CharacterWeapons)
                {
                    if(Weapon.Value == Type)
                    {
                        Choices.Add(Weapon.Key);
                    }
                }
            }

            int WeaponId = Asker.AskChoice(Choices, "Select a weapon");
            foreach(KeyValuePair<string, WeaponClass> weapon in Weapons.WeaponList)
            {
                if (weapon.Key == Choices[WeaponId])
                {
                    Characters[Characters.Count - 1].SetWeapon(weapon);
                    return;
                }
            }
            Console.WriteLine("AAA");
            Console.ReadKey();
        }

        #endregion
        #region Run
        public void Run()
        {

        }
        #endregion
        #region Misc
        public bool IsOver()
        {
            return Ended;
        }
        #endregion

    }
}

