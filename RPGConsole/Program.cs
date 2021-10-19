using System;
using System.Collections.Generic;
using RPGConsole.Project;
using RPGConsole.Project.Misc;


namespace RPGConsole
{
    class Program
    {
        static Game Game;
        static void Main(string[] args)
        {
            Game = new Game();

            Console.WriteLine("Game: " + Game.Name);
            Asker.WaitKey();

            int Difficulty = Asker.AskChoice(new List<string>() {"Easy", "Normal", "Hard"}, "Choose a difficulty");
            Console.Clear();

            Console.WriteLine("Game: " + Game.Name);
            Console.WriteLine("Difficulty: " + Difficulty);
            Asker.WaitKey();

            int Length = 0;

            switch(Asker.AskChoice(new List<string>() { "10 Rooms", "30 Rooms", "50 Rooms" }, "Choose a game length"))
            {
                case 0: case 1: case 2:
                    Length = 10;
                    break;
            }
            Console.Clear();

            Console.WriteLine("Game: " + Game.Name);
            Console.WriteLine("Difficulty: " + Difficulty);
            Console.WriteLine("Length: " + Length);
            Asker.WaitKey();

            Game.Init(Asker.AskEntry("Enter game name"), Length, Difficulty);
        }
    }
}
