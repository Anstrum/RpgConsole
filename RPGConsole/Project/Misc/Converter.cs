using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Misc
{
    static class Converter
    {

        public static int AnyToInt(string Text)
        {
            int Value = 0;
            foreach(char C in Text)
            {
                Value += (int) C;
            }
            Console.WriteLine(Value);
            Console.ReadKey();
            return Value;
        }
    }
}
