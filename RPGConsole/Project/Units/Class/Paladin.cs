using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Paladin : Character
    {
        public Paladin(string Name) : base(Name)
        {
            Class = CharacterClass.Paladin;
            WeaponClass.Add(Enums.WeaponClass.Magical);
            WeaponClass.Add(Enums.WeaponClass.TwoHanded);
        }
    }
}
