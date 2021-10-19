using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Misc
{
    static class Asker
    {
        public static int AskChoice(List<string> Choices, string Question )
        {
            bool Confirmed = false;
            ConsoleKey KeyEntered = ConsoleKey.A;
            int Selector = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(Question);
                for(int i = 0; i < Choices.Count; i++)
                {
                    if(i == Selector)
                    {
                        Console.Write(" >  ");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                    Console.WriteLine(Choices[i]);
                }
                KeyEntered = Console.ReadKey().Key;


                if (KeyEntered == ConsoleKey.Z || KeyEntered == ConsoleKey.UpArrow)
                {
                    Selector--;
                    if(Selector < 0)
                    {
                        Selector = 0;
                    }
                }
                if (KeyEntered == ConsoleKey.S || KeyEntered == ConsoleKey.DownArrow)
                {
                    Selector++;
                    if(Selector >= Choices.Count)
                    {
                        Selector = Choices.Count - 1;
                    }
                }

                if(KeyEntered == ConsoleKey.Enter || KeyEntered == ConsoleKey.Spacebar)
                {
                    Confirmed = ConfirmChoice();
                }
            } 
            while (!Confirmed);
            return Selector;
        }

        public static string AskEntry(string Question)
        {
            string Answer;
            bool Confirmed = false;
            do
            {
                Console.Clear();
                Console.WriteLine(Question);
                Answer = Console.ReadLine();
                Console.Clear();
                Confirmed = ConfirmChoice();
            }
            while (!Confirmed);

            return Answer;
        }
        public static bool ConfirmChoice()
        {
            int Selector = 0;
            ConsoleKey KeyEntered = ConsoleKey.A;
            List<string> Choices = new List<string>();
            Choices.Add("Oui");
            Choices.Add("Non");

            do
            {
                Console.Clear();
                Console.WriteLine("Êtes vous sur de votre choix ?");
                for (int i = 0; i < Choices.Count; i++)
                {
                    if (i == Selector)
                    {
                        Console.Write(" >  ");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                    Console.WriteLine(Choices[i]);
                }

                KeyEntered = Console.ReadKey().Key;

                if (KeyEntered == ConsoleKey.S || KeyEntered == ConsoleKey.DownArrow)
                {
                    Selector++;
                    if (Selector >= Choices.Count)
                    {
                        Selector = Choices.Count - 1;
                    }
                }
                if (KeyEntered == ConsoleKey.Z || KeyEntered == ConsoleKey.UpArrow)
                {
                    Selector--;
                    if (Selector < 0)
                    {
                        Selector = 0;
                    }
                }
            } while (KeyEntered != ConsoleKey.Enter && KeyEntered != ConsoleKey.Spacebar);

            if (Selector == 0)
            {
                return true;
            }
            return false;
        }

        public static void WaitKey()
        {
            Console.WriteLine("\n\n\tAppuyez sur une touche pour continuer...");
            Console.ReadKey();
        }
    }
}
