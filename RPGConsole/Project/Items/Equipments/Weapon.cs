using System;
using System.Collections.Generic;
using System.Text;
using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Items.Equipments
{
    class Weapon
    {
        KeyValuePair<string, WeaponClass> Type;
        public Weapon()
        {
        }

        public KeyValuePair<string, WeaponClass> GetInfo()
        {
            return Type;
        }
        public void Init(KeyValuePair<string, WeaponClass> Type)
        {
            this.Type = Type;
        }
    }
}
