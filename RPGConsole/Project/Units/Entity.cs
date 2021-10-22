using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Effects;
using RPGConsole.Project.Spells;
using RPGConsole.Project.Items;
using RPGConsole.Project.Items.Equipments;

namespace RPGConsole.Project.Units
{
    abstract class Entity
    {
        protected string Name;
        protected int Level;
        protected double Health;
        protected double Mana;
        protected double Strengh;
        protected double Armor;
        protected double MagicArmor;
        protected double Weight;
        protected double Speed;

        protected List<Effect> Effects;
        protected List<Item> Items;
        protected List<Armor> Equipment;
        protected List<Spell> Spells;

        protected bool IsConfused;

        public Entity(string Name, int Level)
        {
            Items = new List<Item>();
            Effects = new List<Effect>();
            Equipment = new List<Armor>();
            Spells = new List<Spell>();
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
        public List<Effect> GetEffects()
        {
            return Effects;
        }
        public bool IsDead()
        {
            return Health <= 0;
        }
    }
}