using System;
using System.Collections.Generic;
using System.Text;

using RPGConsole.Project.Effects;

namespace RPGConsole.Project.Units
{
    class Entity
    {
        protected string Name;
        protected int Health;
        protected int Mana;
        protected int Strengh;
        protected int Armor;
        protected int MagicArmor;
        protected int Weight;
        protected int Speed;
        protected List<Effect> Effects;


        public Entity()
        {

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
    }
}