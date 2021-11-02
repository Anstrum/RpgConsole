using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Effects;
using RPGConsole.Project.Spells;
using RPGConsole.Project.Items;
using RPGConsole.Project.Items.Equipments;
using RPGConsole.Project.Enums;
using RPGConsole.Project.Misc;

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
        protected ObjectId Id;
        protected List<Effect> Effects;
        private Inventory Inventory;
        protected List<Spell> Spells;

        protected Weapon WeaponId;

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
        public List<Spell> GetSpells() { return Spells; }
        public bool IsConfused() { return Confused; }
        public string GetId() { return Id.ToString(); }
        #endregion
        #region Stats Setters
        public void SetWeapon(KeyValuePair<string, WeaponClass> Weapon) 
        { 
            this.Inventory.AddItem(new Weapon(Weapon.Key, Weapon.Value)); 
        }
        #endregion

        public Entity(string Name, int Level, string Id)
        {
            this.Id = new ObjectId(Id);
            this.Effects = new List<Effect>();
            this.Spells = new List<Spell>();
            this.Inventory = new Inventory(IdGenerator.CreateId());
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
        public bool IsDead() { return Health <= 0; }
        public Inventory GetInventory() { return Inventory; }
    }
}