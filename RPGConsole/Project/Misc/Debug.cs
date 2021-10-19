using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Misc
{
    static class Debug
    {
        private static bool DebugActive;
        public static void Activate()
        {
            DebugActive = true;
        }

        public static void Print(string DebugText)
        {
            if (DebugActive)
            {
                Console.WriteLine("[DEBUG]\t" + DebugText);
            }
        }
    }
}
