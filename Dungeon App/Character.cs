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
        private int totalCharacterLoot;
        private int totalCharacterExperience;
        private int heroLevel;

        //properties
        public int HeroLevel
        {
            get { return heroLevel; }
            set { heroLevel = value; }
        }
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
        public int TotalCharacterLoot
        {
            get { return totalCharacterLoot; }
            set { totalCharacterLoot = value; }
        }
        public int TotalCharacterExperience
        {
            get { return totalCharacterExperience; }
            set { totalCharacterExperience = value; }
        }
        public void displayCharacterInfo(Character character)
        {
            Console.WriteLine("Character's Name is: {0}.", character.Name);
            Console.WriteLine("{0} has {1} Max Health.", character.Name, character.MaxHealth);
            Console.WriteLine("{0} wields {1}!", character.Name, character.CharacterWeapon.WeaponName);
            Console.WriteLine("{0} is a {1}.", character.Name, character.CharacterClass);
            Console.WriteLine("{0} has a hit chance of {1} and a block of {2}", character.Name, character.HitChance, character.Block);
            Console.WriteLine("{0} has {1} total experience and {2} total gold\n", character.Name, character.TotalCharacterExperience, character.TotalCharacterLoot);
            Console.WriteLine("{0} has a hero level of {1}", character.Name, character.HeroLevel);
        }
    }
}
