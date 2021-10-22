using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Units.Class
{
    class Blacksmith : Character
    {
        public Blacksmith(string Name) : base(Name)
        {
            WeaponClass.Add(Enums.WeaponClass.TwoHanded);
            WeaponClass.Add(Enums.WeaponClass.Ranged);
        }
    }
}
