using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Mage : Character
    {
        public Mage(string Name) : base(Name)
        {
            WeaponClass.Add(Enums.WeaponClass.Magical);
            WeaponClass.Add(Enums.WeaponClass.Ranged);
        }
    }
}
