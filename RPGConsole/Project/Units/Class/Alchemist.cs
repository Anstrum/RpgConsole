using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Units.Class
{
    class Alchemist : Character
    {
        public Alchemist(string Name) : base(Name)
        {
            WeaponClass.Add(Enums.WeaponClass.Magical);
            WeaponClass.Add(Enums.WeaponClass.OneHanded);
        }
    }
}
