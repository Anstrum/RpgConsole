using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Alchemist : Character
    {
        public Alchemist(string Name) : base(Name)
        {
            Class = CharacterClass.Alchemist;
            WeaponClass.Add(Enums.WeaponClass.Magical);
            WeaponClass.Add(Enums.WeaponClass.OneHanded);
        }
    }
}
