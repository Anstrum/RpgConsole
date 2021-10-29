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


        }
        public static string CreateId()
        {

        }
    }
}
