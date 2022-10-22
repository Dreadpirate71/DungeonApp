using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Dungeon
    {
        //title, menu, rooms, room descriptions
        static void Main(string[] args)
        {
            Console.Title = "Dungeon of Doom";
            Console.WriteLine("Are you ready to do battle?");

            
            bool exit = false;
            bool validClassChoice = false;
            bool validWeaponChoice = false;
           
            Dictionary<int, Room> battleRooms = new Dictionary<int, Room>();
            Room battleRoom1 = new Room()
            {
                RoomID = 1,
                RoomName = "The Chamber of the Mad",
                RoomDescription = "All the mindless, depraved are kept here."
            };
            battleRooms.Add(1, battleRoom1);
            Room battleRoom2 = new Room()
            {
                RoomID = 2,
                RoomName = "The Holding Pens",
                RoomDescription = "The temporary visitors stay here."
            };
            battleRooms.Add(2, battleRoom2);
            Room battleRoom3 = new Room()
            {
                RoomID = 3,
                RoomName = "The Workshop",
                RoomDescription = "All types of dangerous things are created here."
            };
            battleRooms.Add(3, battleRoom3);
            Room battleRoom4 = new Room()
            {
                RoomID = 4,
                RoomName = "The Chamber of Pain",
                RoomDescription = "The purveyors of pain are perfecting their craft here."
            };
            battleRooms.Add (4, battleRoom4);
            Room battleRoom5 = new Room()
            {
                RoomID = 5,
                RoomName = "The Jailers Room",
                RoomDescription = "The Keeper of Keys and Secrets of the Dungeon of Doom"
            };
            battleRooms.Add(5, battleRoom5);
            
            
           //Create dictionary of monsters
            Dictionary <int, Monster> monsters = new Dictionary <int, Monster>();
            Monster monster1 = new Monster()
            {
                MonsterID = 1,
                Name = "Jack The Ripper",
                MonsterType = "Humanoid",
                MaxHealth = 100,
                MinDamage = 3,
                MaxDamage = 12,
                Block = 2
            };
            monsters.Add(1, monster1);
            Monster monster2 = new Monster()
            {
                MonsterID = 2,
                Name = "Cyclops",
                MonsterType = "Beast",
                MaxHealth = 60,
                MinDamage = 5,
                MaxDamage = 18,
                Block = 1
            };
            monsters.Add(2, monster2);
            Monster monster3 = new Monster()
            {
                MonsterID = 3,
                Name = "Terminator",
                MonsterType = "Machine",
                MaxHealth = 80,
                MinDamage = 4,
                MaxDamage = 16,
                Block = 2
            };
            monsters.Add(3, monster3);
            Monster monster4 = new Monster()
            {
                MonsterID = 4,
                Name = "The Jailer",
                MonsterType = "Titan",
                MaxHealth = 200,
                MinDamage = 10,
                MaxDamage = 20,
                Block = 8
            };
            monsters.Add(4, monster4);
            Monster monster5 = new Monster()
            {
                MonsterID = 5,
                Name = "Vlad the Impaler",
                MonsterType = "Humanoid",
                MaxHealth = 60,
                MinDamage = 5,
                MaxDamage = 18,
                Block = 2

            };
            monsters.Add(5, monster5);

            Room room = new Room();
            Monster monster = new Monster();
            Character character = new Character();
            Weapon weapon = new Weapon();
            character.CharacterWeapon = weapon;

            do
            {
                Console.WriteLine("Please choose an action:\n C.) Create a Character\n E.) Enter a room in the dungeon\n G.) Gauntlet Mode\n P.) Player Info\n M.) Monster Info\n X.) Exit\n");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
             
                switch (userChoice)
                {
                    case ConsoleKey.C:
                        Console.Write("Enter a character name: ");
                        character.Name = Console.ReadLine();
                      
                        do
                        {
                            Console.WriteLine("Please choose a class for your character: \n N.) Ninja \n S.) Sorcerer\n W.) Warrior\n");
                            ConsoleKey userClass = Console.ReadKey(true).Key;
                            if (userClass == ConsoleKey.N)
                            {
                                character.CharacterClass = "Ninja";
                                character.Block = 3;
                                character.MaxHealth = 80;
                                character.HitChance = 15;
                                validClassChoice = true;

                            }
                            else if (userClass == ConsoleKey.S)
                            {
                                character.CharacterClass = "Sorcerer";
                                character.Block = 2;
                                character.MaxHealth = 70;
                                character.HitChance = 12;
                                validClassChoice=true;
                            }
                            else if (userClass == ConsoleKey.W)
                            {
                                character.CharacterClass = "Warrior";
                                character.Block = 5;
                                character.MaxHealth = 100;
                                character.HitChance = 10;
                                validClassChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Please enter a valid choice!\n");
                                continue;
                            }
                        } while (validClassChoice != true);
                        
                        do
                        {
                            Console.WriteLine("Please choose your weapon: \n D.) Dagger\n P.) Polearm \n S.) Sword\n W.) Wand\n");
                            ConsoleKey userWeapon = Console.ReadKey(true).Key;
                            if (userWeapon == ConsoleKey.D)
                            {
                                weapon.BonusHitChance = 2;
                                weapon.MinDamage = 3;
                                weapon.MaxDamage = 12;
                                weapon.IsTwoHanded = false;
                                weapon.WeaponName = "Lightning Bolt";
                                validWeaponChoice = true;
                            }
                            else if (userWeapon == ConsoleKey.P)
                            {
                                weapon.BonusHitChance = 1;
                                weapon.MinDamage = 3;
                                weapon.MaxDamage = 10;
                                weapon.IsTwoHanded = true;
                                weapon.WeaponName = "Truth Teller";
                                validWeaponChoice=true;
                            }
                            else if (userWeapon == ConsoleKey.S)
                            {
                                weapon.BonusHitChance = 3;
                                weapon.MinDamage = 4;
                                weapon.MaxDamage = 15;
                                weapon.IsTwoHanded = true;
                                weapon.WeaponName = "Excalibur";
                                validWeaponChoice = true;
                            }
                            else if (userWeapon == ConsoleKey.W)
                            {
                                weapon.BonusHitChance= 4;
                                weapon.MinDamage = 1;
                                weapon.MaxDamage = 8;
                                weapon.IsTwoHanded = false;
                                weapon.WeaponName = "Fire Starter";
                                validWeaponChoice=(true);
                            }
                        } while (validWeaponChoice != true);
                    
                        break;
                    case ConsoleKey.E:

                        if (character.Name == null)
                        {
                            Console.WriteLine("You need to create a character before you can enter a dungeon room!\n");
                            continue;
                        }
                        else
                        {
                            bool exitRoom = false;
                            int lowerBoundRoom = 1;
                            int upperBoundRoom = battleRooms.Count;
                            int lowerBoundMonster = 1;
                            int upperBoundMonster = monsters.Count;
                            var randomNumRoom = new Random();
                            var randomNumMonster = new Random();
                            var randomNumWeapon = new Random();
                            var randomNumMonsterDamage = new Random();
                            var randomNumMonsterBonus = new Random();

                            monster.RandomMonster = randomNumMonster.Next(lowerBoundMonster, upperBoundMonster);                           
                            room.RandomRoom = randomNumRoom.Next(lowerBoundRoom, upperBoundRoom);                            
                            weapon.RandomWeaponDamage = randomNumWeapon.Next(character.CharacterWeapon.MinDamage, character.CharacterWeapon.MaxDamage);
                            monster.RandomMonsterBonus = randomNumMonsterBonus.Next(1, 20);
                            monster.CurrentHealth = monsters[monster.RandomMonster].MaxHealth;
                            character.CurrentHealth = character.MaxHealth;

                            Console.WriteLine("You have entered {0}.", battleRooms[room.RandomRoom].RoomName );
                            Console.WriteLine("The monster in this room is {0}.\n", monsters[monster.RandomMonster].Name);
                            do
                            {
                                Console.WriteLine("Please choose an action:\n A.) Attack\n R.) Run away\n M.) Monster Info\n X.) Exit");
                                ConsoleKey userChoiceRoom = Console.ReadKey(true).Key;

                                switch (userChoiceRoom)
                                {
                                    case ConsoleKey.A:
                                        if (monster.CurrentHealth <= 0)
                                        {
                                            Console.WriteLine("You have already defeated {0}! Try another room for a different foe!\n", monsters[monster.RandomMonster].Name);
                                            break;
                                        }
                                        else if (character.CurrentHealth <= 0)
                                        {
                                            Console.WriteLine("{0}, you have failed in your quest to defeat {1}! Perhaps in your next life you will be victorious!\n", character.Name, monsters[monster.RandomMonster].Name);
                                            break;
                                        }
                                        weapon.RandomWeaponDamage = randomNumWeapon.Next(character.CharacterWeapon.MinDamage, character.CharacterWeapon.MaxDamage);
                                        monster.RandomMonsterDamage = randomNumMonsterDamage.Next(monsters[monster.RandomMonster].MinDamage, monsters[monster.RandomMonster].MaxDamage);
                                        character.HitDamage = ((character.HitChance + weapon.BonusHitChance + weapon.RandomWeaponDamage) - monsters[monster.RandomMonster].Block);
                                        monster.CurrentHealth -= character.HitDamage;
                                        monster.HitDamage = (monster.RandomMonsterDamage + monster.RandomMonsterBonus) - character.Block;
                                        character.CurrentHealth -= monster.HitDamage;
                                        Console.WriteLine("You did {0} damage! {1} now has {2} health.", character.HitDamage, monsters[monster.RandomMonster].Name, monster.CurrentHealth);
                                        Console.WriteLine("{0} did {1} damage! {2} now has {3} health.\n", monsters[monster.RandomMonster].Name, monster.HitDamage, character.Name, character.CurrentHealth);
                                        if (character.CurrentHealth <= 0)
                                        {
                                            Console.WriteLine("You have been defeated by {0}!", monsters[monster.RandomMonster].Name);
                                            break;
                                        }
                                        else if (monster.CurrentHealth <= 0)
                                        {
                                            Console.WriteLine("You have conquered {0}!", monsters[monster.RandomMonster].Name);
                                            break;
                                        }
                                        continue;
                                    case ConsoleKey.R:
                                        Console.WriteLine("You have chosen to run away from {0} and live to fight another day", monsters[monster.RandomMonster].Name);
                                        break;
                                    case ConsoleKey.M:
                                        Console.WriteLine("The monster {0} is a {1} type monster!", monsters[monster.RandomMonster].Name, monsters[monster.RandomMonster].MonsterType);
                                        Console.WriteLine("{0} Maximum Health = {1}.", monsters[monster.RandomMonster].Name, monsters[monster.RandomMonster].MaxHealth);
                                        Console.WriteLine("{0} Minimum Damage = {1}.", monsters[monster.RandomMonster].Name, monsters[monster.RandomMonster].MinDamage);
                                        Console.WriteLine("{0} Maximum Damage = {1}.",monsters[monster.RandomMonster].Name, monsters[monster.RandomMonster].MaxDamage);
                                        Console.WriteLine("{0} Block = {1}.", monsters[monster.RandomMonster].Name, monsters[monster.RandomMonster].Block);
                                        Console.WriteLine("{0} Current Health = {1}.\n", monsters[monster.RandomMonster].Name, monster.CurrentHealth);
                                        break;
                                    case ConsoleKey.X:
                                        exitRoom = true;
                                        break;
                                    default:
                                        Console.WriteLine("Please enter a choice from the menu!\n");
                                        continue;
                                }
                            } while (exitRoom != true);
                            break;
                        }
                    case ConsoleKey.M:
                        
                        foreach (var itemMonster in monsters.Values)
                        {
                            Console.WriteLine("The Monster -{0}- is a {1} type monster.", itemMonster.Name, itemMonster.MonsterType);
                            Console.WriteLine("{0} Max Health = {1}.", itemMonster.Name, itemMonster.MaxHealth);
                            Console.WriteLine("{0} Minimum Damage = {1}.", itemMonster.Name, itemMonster.MinDamage);
                            Console.WriteLine("{0} Maximum Damage = {1}.", itemMonster.Name, itemMonster.MaxDamage);
                            Console.WriteLine("{0} Block = {1}.\n", itemMonster.Name, itemMonster.Block);
                        }
                        break;
                    case ConsoleKey.P:
                        Console.WriteLine("Character's Name is: {0}.", character.Name);
                        Console.WriteLine("{0} has {1} Max Health.", character.Name, character.MaxHealth);
                        Console.WriteLine("{0} wields {1}!", character.Name, character.CharacterWeapon.WeaponName);
                        Console.WriteLine("{0} is a {1}.", character.Name, character.CharacterClass);
                        Console.WriteLine("{0} has a hit chance of {1} and a block of {2}\n", character.Name, character.HitChance, character.Block);
                        break;
                    case ConsoleKey.X:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a choice from the menu!\n");
                        continue;
                }
            }while (!exit);
        }

    }
}
