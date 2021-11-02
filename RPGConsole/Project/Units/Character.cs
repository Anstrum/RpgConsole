using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Enums;
using RPGConsole.Project.Misc;

namespace RPGConsole.Project.Units
{
    abstract class Character : Entity
    {
        protected CharacterClass Class;
        protected List<WeaponClass> WeaponClass;
        private double Experience;
        private double ExperienceToMax;
        public Character(string Name) : base(Name, 1, IdGenerator.CreateId())
        {
            WeaponClass = new List<WeaponClass>();
            Experience = 0;
            ExperienceToMax = 2.5 * (Level * Level * Level) - 5 * (Level * Level) + 200 * Level - 140 ;
        }

    #region Getter
        public CharacterClass GetClass() { return Class; }
        public List<WeaponClass> GetWeaponClass() { return WeaponClass; }
    #endregion
    }
}