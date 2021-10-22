using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Units.Class
{
    class Paladin : Character
    {
        public Paladin(string Name) : base(Name)
        {
            WeaponClass.Add(Enums.WeaponClass.Magical);
            WeaponClass.Add(Enums.WeaponClass.TwoHanded);
        }
    }
}
