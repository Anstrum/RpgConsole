using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Misc
{
    static class IdGenerator
    {
        private static List<string> GeneratedIds = new List<string>();
        private static List<char> AuthorizedChars = new List<char>();

        public static void Init()
        {
            GeneratedIds.Clear();
            AuthorizedChars.Clear();
            AuthorizedChars.AddRange(new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                                        'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                                        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                        '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'});
        }
        public static string CreateId()
        {
            Random Random;
            if (GeneratedIds.Count == 0)
            {
                Random = new Random(DateTime.Now.Millisecond);
            }
            else
            {
                Random = new Random(Converter.AnyToInt(GeneratedIds[GeneratedIds.Count - 1]));
            }

            string MyId = "";
            do
            {
                for (int i = 0; i < 20; i++)
                {
                    MyId += AuthorizedChars[Random.Next(0, AuthorizedChars.Count)];
                }
            } while (!AlreadyExits(MyId));
            GeneratedIds.Add(MyId);
            return MyId;
        }
        private static bool AlreadyExits(string Value)
        {
            foreach(string Id in GeneratedIds)
            {
                if(Value == Id)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
