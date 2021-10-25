using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Priest : Character
    {
        public Priest(string Name) : base(Name)
        {
            Class = CharacterClass.Priest;
            WeaponClass.Add(Enums.WeaponClass.Magical);
        }
    }
}
