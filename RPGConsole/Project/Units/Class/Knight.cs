using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Knight : Character
    {
        public Knight(string Name) : base(Name)
        {
            Class = CharacterClass.Knight;
            WeaponClass.Add(Enums.WeaponClass.OneHanded);
            WeaponClass.Add(Enums.WeaponClass.TwoHanded);
            WeaponClass.Add(Enums.WeaponClass.Ranged);
        }
    }
}
