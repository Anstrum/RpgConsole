using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Units.Class
{
    class Mystic : Character
    {
        public Mystic(string Name) : base(Name)
        {
            WeaponClass.Add(Enums.WeaponClass.Magical);
        }
    }
}
