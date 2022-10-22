using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Character : Combatant
    {
        //name, hit chance, max life, health, block, equipped weapon
        //fields
        private string characterName;
        private string characterClass;
        private Weapon characterWeapon;
        public int hitDamage;
        //properties
     
        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        public string CharacterClass
        {
            get { return characterClass; }
            set { characterClass = value; }
        }
        public Weapon CharacterWeapon
        {
            get { return characterWeapon; }
            set { characterWeapon = value; }
        }
        /* TODO:
         * Ability to create a character object to be used in the dungeon for creating your player and the monsters 
         * Calculate the hit chance (e.g. player hit chance + weapon hit chance)
         * Calculate the damage (e.g. using System.Random to choose a number between the equipped weapon min and max dmg)
         * 
         */
    }
}
