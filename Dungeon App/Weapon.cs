using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Weapon
    {
        //name, minimum damage, maximum damage, isTwoHanded, bonus hit chance
        //ability to use weapon and used by character
        //Fields
        private string weaponName;
        private string weaponType;
        private int minDamage;
        private int maxDamage;
        private int bonusHitChance;
        private bool isTwoHanded;
        private int randomWeaponDamage;

        //properties
        public int RandomWeaponDamage
        {
            get { return randomWeaponDamage; }
            set { randomWeaponDamage = value; }
        }
        public int MaxDamage
        {
            get { return maxDamage; }
            set { maxDamage = value; }
        }
        public int MinDamage
        {
            get { return minDamage; }
            set
            {
                if (value > 0 && value <= maxDamage)
                {
                    minDamage = value;
                }
                else
                {
                    minDamage = 1;
                }

            }
        }

        public bool IsTwoHanded
        {
            get { return isTwoHanded; }
            set { isTwoHanded = value; }
        }

        public int BonusHitChance
        {
            get { return bonusHitChance; }
            set { bonusHitChance = value;}
        }
        
        public string WeaponName
        {
            get { return weaponName; }
            set { weaponName = value; }
        }
        public string WeaponType
        {
            get { return weaponType; }
            set { weaponType = value; }
        }
    }
}
