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
            Console.WriteLine(Asker.AskEntry("Veuillez saisir un nom"));

            int Answer =Asker.AskChoice(new List<string>() { "Barbarian", "Knight", "Mage", "Rogue" }, "Choisissez votre classe");

            //Game = new Game();
            //Game.Init();
        }
    }
}
