using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;
using RPGConsole.Project.Misc;

namespace RPGConsole.Project.Items.Equipments
{
    class Weapon : Item
    {
        KeyValuePair<string, WeaponClass> Type;
        public Weapon(string WeaponType, WeaponClass WeaponClass) : base(IdGenerator.CreateId(), ItemType.Weapon)
        {
            Type = new KeyValuePair<string, WeaponClass>();
            this.Type = new KeyValuePair<string, WeaponClass>(WeaponType, WeaponClass);
        }
        public Weapon(string WeaponType, WeaponClass WeaponClass, bool Equiped) : base(IdGenerator.CreateId(), ItemType.Weapon)
        {
            Type = new KeyValuePair<string, WeaponClass>();
            this.Type = new KeyValuePair<string, WeaponClass>(WeaponType, WeaponClass);
            this.Equiped = Equiped;
        }

        public KeyValuePair<string, WeaponClass> GetInfo()
        {
            return Type;
        }
    }
}
