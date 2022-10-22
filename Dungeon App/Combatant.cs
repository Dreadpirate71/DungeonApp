using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Combatant
    {
        private int maxHealth;
        private int minDamage;
        private int maxDamage;
        private int block;
        private int hitDamage;
        private int currentHealth;
        private int hitChance;
        private string name;



        //properties
       public string Name
        {
            get { return name; }
            set { name = value; } 
        }
        public int HitDamage
        {
            get { return hitDamage; }
            set { hitDamage = value; }
        }
       
        public int MaxHealth
        {
            get { return maxHealth; }
            set { maxHealth = value; }
        }
        public int CurrentHealth
        {
            get { return currentHealth; }
            set { currentHealth = value; }
        }
        
        public int MinDamage
        {
            get { return minDamage; }
            set { minDamage = value; }
        }
        public int MaxDamage
        {
            get { return maxDamage; }
            set { maxDamage = value; }
        }
        public int Block
        {
            get { return block; }
            set { block = value; }
        }
        public int HitChance
        {
            get { return hitChance; }
            set { hitChance = value; }
        }

    }
}
