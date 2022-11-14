using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Hero : Character
    { 
        private int heroBonusHealth;
        private int heroBonusDamage;
        private int heroBonusBlock;
        
        private Shield heroShield;
        private Weapon heroWeapon;

        //constructor
        public Weapon HeroWeapon
        {
            get { return heroWeapon; }
            set { heroWeapon = value; }
        }
        public Shield HeroShield
        {
            get { return heroShield; }
            set { heroShield = value; }
        }
        
        public int HeroBonusHealth
        {
            get { return heroBonusHealth; }
            set { heroBonusHealth = value; }
        }
        public int HeroBonusDamage
        {
            get { return heroBonusDamage; }
            set { heroBonusDamage = value; }
        }
        public int HeroBonusBlock
        {
            get { return heroBonusBlock;}
            set { heroBonusBlock = value; }
        }
        public void ElevateHeroLevel(Character character)
        {
            character.HeroLevel = character.TotalCharacterExperience / 100;
            heroBonusBlock = character.HeroLevel * 2;
            heroBonusDamage = character.HeroLevel * 10;
            heroBonusHealth = character.HeroLevel * 40;
            character.MaxHealth += heroBonusHealth;
            character.HitChance += heroBonusDamage;
            character.MinDamage += heroBonusDamage;
            character.Block += heroBonusBlock; 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}, you are now have a hero level of {1}!\n", character.Name, character.HeroLevel);
        }

    }
}
