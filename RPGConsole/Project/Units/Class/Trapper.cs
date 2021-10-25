using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Trapper : Character
    {
        public Trapper(string Name) : base(Name)
        {
            Class = CharacterClass.Trapper;
            WeaponClass.Add(Enums.WeaponClass.OneHanded);
            WeaponClass.Add(Enums.WeaponClass.Ranged);
        }
    }
}
