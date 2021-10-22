using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Effects;
using RPGConsole.Project.Spells;
using RPGConsole.Project.Items;
using RPGConsole.Project.Items.Equipments;
using RPGConsole.Project.Enums;

namespace RPGConsole.Project.Units
{
    abstract class Entity
    {
        protected string Name;
        protected int Level;
        protected double Health;
        protected double MaxHealth;
        protected double Mana;
        protected double MaxMana;
        protected double Strengh;
        protected double Armor;
        protected double MagicArmor;
        protected double Weight;
        protected double Speed;

        protected List<Effect> Effects;
        protected List<Item> Items;
        protected List<Armor> Equipments;
        protected List<Spell> Spells;

        protected Weapon Weapon;

        protected bool Confused;


        #region Stats Getters
        public string GetName() { return Name; }
        public int GetLevel() { return Level; }
        public double GetHealth() { return Health; }
        public double GetMana() { return Mana; }
        public double GetStrengh() { return Strengh; }
        public double GetArmor() { return Armor; }
        public double GetMagicArmor() { return MagicArmor; }
        public double GetWeight() { return Weight; }
        public double GetSpeed() { return Speed; }
        public List<Effect> GetEffects() { return Effects; }
        public List<Item> GetItems() { return Items; }
        public List<Armor> GetEquipment() { return Equipments; }
        public List<Spell> GetSpells() { return Spells; }
        public bool IsConfused() { return Confused; }
        public Weapon GetWeapon() { return Weapon; }
        #endregion
        #region Stats Setters
        public void SetWeapon(string WeaponType, WeaponClass Class) 
        { 
            this.Weapon.Init(WeaponType, Class); 
        }
        #endregion





        public Entity(string Name, int Level)
        {
            Items = new List<Item>();
            Effects = new List<Effect>();
            Equipments = new List<Armor>();
            Spells = new List<Spell>();
            Weapon = new Weapon();
            this.Name = Name;
            this.Level = Level;
        }
        public void Attack()
        {
        }
        public void Heal()
        {

        }
        public void Defend()
        {

        }
        public bool IsDead()
        {
            return Health <= 0;
        }
    }
}