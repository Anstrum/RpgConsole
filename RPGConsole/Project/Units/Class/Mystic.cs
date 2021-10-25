using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Mystic : Character
    {
        public Mystic(string Name) : base(Name)
        {
            Class = CharacterClass.Mystic;
            WeaponClass.Add(Enums.WeaponClass.Magical);
        }
    }
}
