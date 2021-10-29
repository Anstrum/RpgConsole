using System;
using System.Collections.Generic;
using RPGConsole.Project;
using RPGConsole.Project.Enums;
using RPGConsole.Project.Misc;


namespace RPGConsole
{
    class Program
    {
        static Game Game;
        static bool InitGame = true;
        static void Main(string[] args)
        {
            IdGenerator.Init();
            if(Asker.AskChoice(new List<string>() {"Oui", "Non"}, "Voulez vous activer le débug ?") == 0)
            {
                Debug.Activate();
            }
            #region SkipInit

            if (Asker.AskChoice(new List<string>() { "Oui", "Non" }, "Voulez vous passer l'init du jeu ?") == 0)
            {
                InitGame = false;
            }
            #endregion


            Game = new Game();
            if (InitGame)
            {
                string Name = Asker.AskEntry("Enter game name");
                Console.Clear();


                DifficultyLevel Difficulty;
                switch (Asker.AskChoice(new List<string>() { "Easy", "Normal", "Hard" }, "Choose a difficulty"))
                {
                    case 0:
                        Difficulty = DifficultyLevel.Easy;
                        break;
                    case 1:
                        Difficulty = DifficultyLevel.Medium;
                        break;
                    case 2:
                        Difficulty = DifficultyLevel.Hard;
                        break;

                    default:
                        Difficulty = DifficultyLevel.Medium;
                        break;
                }
                Console.Clear();



                int Length = 0;
                switch (Asker.AskChoice(new List<string>() { "20 Rooms", "50 Rooms", "100 Rooms" }, "Choose a game length"))
                {
                    case 0:
                        Length = 20;
                        break;
                    case 1:
                        Length = 50;
                        break;
                    case 2:
                        Length = 100;
                        break;
                }
                Console.Clear();


                Console.WriteLine("Game: " + Name);
                Console.WriteLine("Difficulty: " + Difficulty);
                Console.WriteLine("Length: " + Length);
                Asker.WaitKey();
                Console.Clear();


                Game.Init(Name, Difficulty, Length);
            }
            Debug.Print("Game Init Success");
            Game.Run();
        }
    }
}
