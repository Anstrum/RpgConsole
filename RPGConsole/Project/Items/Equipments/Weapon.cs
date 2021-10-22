using System;
using System.Collections.Generic;
using System.Text;
using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Items.Equipments
{
    class Weapon
    {
        string Type;
        WeaponClass Class;

        public Weapon()
        {
        }
        public string GetName()
        {
            return Type;
        }
        public WeaponClass GetClass()
        {
            return Class;
        }
        public void Init(string Type, WeaponClass Class)
        {
            this.Type = Type;
            this.Class = Class;
        }
    }
}
