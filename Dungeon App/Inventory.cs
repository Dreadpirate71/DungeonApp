using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Inventory
    {
        //fields
        private string merchantItem;

        //private Dictionary<string, int> merchantInventory;
        public Dictionary<string, int> MerchantInventory
        {
            get { return merchantInventory; }
            set { merchantInventory = value; }
        }

        Dictionary<string, int> merchantInventory = new Dictionary<string, int>();
        public string MerchantItem
        {
            get { return merchantItem; }
            set { merchantItem = value; }
        }
        

        public void BuyInventoryItem(ConsoleKey key, Dictionary<string, int> merchantInventory, Character character)
        {
            switch (key)
            {
                case ConsoleKey.H:
                    //Console.WriteLine(merchantInventory["Healing Potion"]);
                    merchantItem = "Healing Potion";
                    character.CurrentHealth += 20;
                    character.TotalCharacterLoot -= merchantInventory[merchantItem];
                    Console.WriteLine("{0}, you now have a total of {1} gold!", character.Name, character.TotalCharacterLoot);
                    break;
                case ConsoleKey.S:
                    if (character.HeroLevel >= 1)
                    {
                        merchantItem = "Shield";
                        Shield shield = new Shield();
                        shield.ShieldBlock += character.HeroLevel * 10;
                        shield.ShieldBonusDamage += character.HeroLevel * 10;
                        character.HitDamage += shield.ShieldBonusDamage;
                        character.Block += shield.ShieldBlock;
                        character.TotalCharacterLoot -= merchantInventory[merchantItem];
                        Console.WriteLine("{0}, your total hit damage is now {1}, and your total block is {2}", character.Name, character.HitDamage, character.Block);
                        Console.WriteLine("{0}, you now have a total of {1} gold!", character.Name, character.TotalCharacterLoot);
                    }
                    else
                    {
                        Console.WriteLine("You need to be hero level 1 before you can purchase a shield.");
                    }
                    break;
                case ConsoleKey.W:
                    if (character.HeroLevel > 3)
                    {
                        merchantItem = "Hero Weapon";
                        Weapon heroWeapon = new Weapon();
                        heroWeapon.MinDamage = character.HeroLevel * 10;
                        heroWeapon.MaxDamage = character.HeroLevel * 20;
                        heroWeapon.BonusHitChance = character.HeroLevel * 10;
                        character.CharacterWeapon = heroWeapon;
                        character.TotalCharacterLoot -= merchantInventory[merchantItem];
                    }
                    else
                    {
                        Console.WriteLine("You need to be hero level 3 before you can purchase a hero weapon.");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice!");
                    break;
            }
        }
    }
}
