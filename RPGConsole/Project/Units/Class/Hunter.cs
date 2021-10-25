using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units.Class
{
    class Hunter : Character
    {
        public Hunter(string Name) : base(Name)
        {
            Class = CharacterClass.Hunter;
            WeaponClass.Add(Enums.WeaponClass.Ranged);
        }
    }
}
