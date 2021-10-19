using System;
using System.Collections.Generic;
using System.Text;

namespace RPGConsole.Project.Enums
{
    public static class Weapons
    {
        public static Dictionary<string, WeaponClass> WeaponList = new Dictionary<string, WeaponClass>()
        {
            { "WarHammer", WeaponClass.TwoHanded },
            { "BattleAxe", WeaponClass.TwoHanded },
            { "LongSword", WeaponClass.TwoHanded },
            { "Spear", WeaponClass.TwoHanded },
            { "CombatStaff", WeaponClass.TwoHanded },
            { "Nodachi", WeaponClass.TwoHanded },
            { "Ohmlatl", WeaponClass.TwoHanded },

            { "Bow", WeaponClass.Ranged },
            { "Crossbow", WeaponClass.Ranged },
            { "Kunaï", WeaponClass.Ranged },
            { "Shurikens", WeaponClass.Ranged },
            { "Gun", WeaponClass.Ranged },
            { "DoubleGun", WeaponClass.Ranged },
            { "Sniper", WeaponClass.Ranged },
            { "Shotgun", WeaponClass.Ranged },

            { "Katana", WeaponClass.OneHanded },
            { "Sword", WeaponClass.OneHanded },
            { "ShieldSword", WeaponClass.OneHanded },
            { "Axe", WeaponClass.OneHanded },
            { "Hammer", WeaponClass.OneHanded },
            { "DoubleAxe", WeaponClass.OneHanded },
            { "DoubleDagger", WeaponClass.OneHanded },
            { "Flail", WeaponClass.OneHanded },

            { "Tome", WeaponClass.Magical },
            { "Wand", WeaponClass.Magical },
            { "Staff", WeaponClass.Magical },
            { "Orb", WeaponClass.Magical },
            { "Lyre", WeaponClass.Magical },
            { "Glove", WeaponClass.Magical },
            { "GemStones", WeaponClass.Magical },
        };
    }
}
