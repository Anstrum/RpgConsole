using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Necromancer : Character
    {
        public Necromancer(string Name) : base(Name)
        {
            Class = CharacterClass.Necromancer;
            WeaponClass.Add(Enums.WeaponClass.Magical);
            WeaponClass.Add(Enums.WeaponClass.OneHanded);
            WeaponClass.Add(Enums.WeaponClass.TwoHanded);
        }
    }
}
