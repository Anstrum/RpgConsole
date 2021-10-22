using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Units.Class
{
    class Priest : Character
    {
        public Priest(string Name) : base(Name)
        {
            WeaponClass.Add(Enums.WeaponClass.Magical);
        }
    }
}
