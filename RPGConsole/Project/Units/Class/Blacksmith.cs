using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Blacksmith : Character
    {
        public Blacksmith(string Name) : base(Name)
        {
            Class = CharacterClass.Blacksmith;
            WeaponClass.Add(Enums.WeaponClass.TwoHanded);
            WeaponClass.Add(Enums.WeaponClass.Ranged);
        }
    }
}
