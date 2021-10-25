using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Barbarian : Character
    {
        public Barbarian(string Name) : base(Name)
        {
            Class = CharacterClass.Barbarian;
            WeaponClass.Add(Enums.WeaponClass.OneHanded);
        }
    }
}
