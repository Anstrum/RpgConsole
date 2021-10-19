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

            int Answer = Asker.AskChoice(new List<string>() { "Barbarian", "Knight", "Mage", "Rogue" }, "Choisissez votre classe");
            Console.Clear();
            Console.Write("Vous avez choisi la classe ");
            switch(Answer)
            {
                case 0:
                    Console.WriteLine("Barbare");
                    break;
                case 1:
                    Console.WriteLine("Knight");
                    break;
                case 2:
                    Console.WriteLine("Mage");
                    break;
                case 3:
                    Console.WriteLine("Rogue");
                    break;
            }
            //Game = new Game();
            //Game.Init();
        }
    }
}
