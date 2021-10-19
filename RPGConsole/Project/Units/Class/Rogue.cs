using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Rogue : Character
    {
        public Rogue(string Name, WeaponClass WeaponClass) : base(Name, CharacterClass.Barbarian, WeaponClass)
        {

        }
    }
}
