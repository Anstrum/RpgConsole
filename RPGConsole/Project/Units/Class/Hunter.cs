using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Units.Class
{
    class Hunter : Character
    {
        public Hunter(string Name) : base(Name)
        {
            WeaponClass.Add(Enums.WeaponClass.Ranged);
        }
    }
}
