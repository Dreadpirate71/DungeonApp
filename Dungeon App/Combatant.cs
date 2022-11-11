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
        private int experience;
        private int loot;



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
        public int Loot
        {
            get { return loot; }
            set { loot = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public void DoGauntletBattle(Monster monster, Character character, Weapon weapon, int monsterMultiplier)
        {
            bool exitRoom = false;
            var randomNumWeapon = new Random();
            var randomNumMonsterDamage = new Random();
            var randomNumMonsterBonus = new Random();

           
            
            //weapon.RandomWeaponDamage = randomNumWeapon.Next(character.CharacterWeapon.MinDamage, character.CharacterWeapon.MaxDamage);
            //monster.RandomMonsterBonus = randomNumMonsterBonus.Next(1, 20);
            monster.CurrentHealth = monster.MaxHealth*monsterMultiplier;
            character.CurrentHealth = character.MaxHealth;
            do
            {
                Console.WriteLine("Please choose an action:\n A.) Attack\n R.) Run away\n X.) Exit Room");
                ConsoleKey userChoiceRoom = Console.ReadKey(true).Key;

                switch (userChoiceRoom)
                {
                    case ConsoleKey.A:
                        if (monster.CurrentHealth <= 0)
                        {
                            Console.WriteLine("You have already defeated {0}! Try another room for a different foe!\n", monster.Name);
                            break;
                        }
                        else if (character.CurrentHealth <= 0)
                        {
                            Console.WriteLine("{0}, you have failed in your quest to defeat {1}! Perhaps in your next life you will be victorious!\n", character.Name, monster.Name);
                            break;
                        }
                        
                        monster.RandomMonsterDamage = randomNumMonsterDamage.Next(monster.MinDamage, monster.MaxDamage);
                        monster.RandomMonsterBonus = randomNumMonsterBonus.Next(1, 20);
                        weapon.RandomWeaponDamage = randomNumWeapon.Next(character.CharacterWeapon.MinDamage, character.CharacterWeapon.MaxDamage);
                        character.HitDamage = (character.HitChance + weapon.BonusHitChance + weapon.RandomWeaponDamage) - monster.Block;
                        monster.CurrentHealth -= character.HitDamage;
                        monster.HitDamage = (monster.RandomMonsterDamage + monster.RandomMonsterBonus)*monsterMultiplier - character.Block;
                        if (monster.HitDamage < 0)
                        {
                            character.CurrentHealth -= 0;
                        }
                        else
                        {
                            character.CurrentHealth -= monster.HitDamage;
                        }
                        Console.WriteLine("You did {0} damage! {1} now has {2} health.", character.HitDamage, monster.Name, monster.CurrentHealth);
                        Console.WriteLine("{0} did {1} damage! {2} now has {3} health.\n", monster.Name, monster.HitDamage, character.Name, character.CurrentHealth);
                        if (character.CurrentHealth <= 0)
                        {
                            character.TotalCharacterLoot -= monster.Loot;
                            Console.WriteLine("{0}, you have been defeated by {1}!", character.Name, monster.Name);
                            Console.WriteLine("{0}, you now have {1} gold.", character.Name, character.TotalCharacterLoot);
                            break;
                        }
                        else if (monster.CurrentHealth <= 0)
                        {
                            character.TotalCharacterLoot += monster.Loot*monsterMultiplier;
                            character.TotalCharacterExperience += monster.Experience*monsterMultiplier;
                            Console.WriteLine("{0}, you have conquered {1}!", character.Name, monster.Name);
                            Console.WriteLine("{0}, you now have {1} experience and {2} gold!", character.Name, character.TotalCharacterExperience, character.TotalCharacterLoot);
                            break;
                        }
                        continue;
                    case ConsoleKey.R:
                        Console.WriteLine("You have chosen to run away from {0} and live to fight another day", monster.Name);
                        break;
                    case ConsoleKey.X:
                        exitRoom = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a choice from the menu!\n");
                        continue;
                }
            } while (exitRoom != true);
        }
    }
}
