using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units
{
    abstract class Character : Entity
    {
        protected CharacterClass Class;
        protected WeaponClass WeaponClass;
        private double Experience;
        private double ExperienceToMax;

        public Character(string Name, CharacterClass Class, WeaponClass WeaponClass) : base(Name, 1)
        {
            this.Class = Class;
            this.WeaponClass = WeaponClass;
            Experience = 0;
            ExperienceToMax = 2.5 * (Level * Level * Level) - 5 * (Level * Level) + 200 * Level - 140 ;
        }

    #region Getter
        public string GetName()
        {
            return Name;
        }
        public CharacterClass GetClass()
        {
            return Class;
        }
        public WeaponClass GetWeaponClass()
        {
            return WeaponClass;
        }

    #endregion
    }
}