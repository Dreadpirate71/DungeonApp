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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "Dungeon of Doom";
            Console.WriteLine("Are you ready to do battle?\n");

            
            bool exit = false;
            bool validClassChoice = false;
            bool validWeaponChoice = false;
            bool exitBattleRoom = false;

            Dictionary<string, int> merchantInventory = new Dictionary<string, int>();
            merchantInventory.Add("Health Potion", 20);
            merchantInventory.Add("Shield", 40);
            merchantInventory.Add("Hero Weapon", 100);

            Dictionary<int, Room> battleRooms = new Dictionary<int, Room>();
            Room battleRoom1 = new Room()
            {
                RoomID = 1,
                RoomName = "The Holding Pens",
                RoomDescription = "The temporary visitors stay here."
            };
            battleRooms.Add(1, battleRoom1);
            Room battleRoom2 = new Room()
            {
                RoomID = 2,
                RoomName = "The Chamber of the Mad",
                RoomDescription = "All the mindless, depraved are kept here."
                
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
                Name = "Cyclops",
                MonsterType = "Beast",
                MaxHealth = 60,
                MinDamage = 5,
                MaxDamage = 18,
                Block = 1,
                Loot = 10,
                Experience = 10
            };
            monsters.Add(1, monster1);
            Monster monster2 = new Monster()
            {
                MonsterID = 2,
                Name = "Jack The Ripper",
                MonsterType = "Humanoid",
                MaxHealth = 60,
                MinDamage = 5,
                MaxDamage = 18,
                Block = 3,
                Loot = 10,
                Experience = 10,
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
                Block = 4,
                Loot = 15,
                Experience = 15
            };
            monsters.Add(3, monster3);
            Monster monster4 = new Monster()
            {
                MonsterID = 4,
                Name = "Vlad the Impaler",
                MonsterType = "Humanoid",
                MaxHealth = 200,
                MinDamage = 10,
                MaxDamage = 20,
                Block = 2,
                Loot = 20,
                Experience = 20
            };
            monsters.Add(4, monster4);
            Monster monster5 = new Monster()
            {
                MonsterID = 5,
                Name = "The Jailer",
                MonsterType = "Titan",
                MaxHealth = 400,
                MinDamage = 20,
                MaxDamage = 40,
                Block = 8,
                Loot = 40,
                Experience = 40
            };
            monsters.Add(5, monster5);
            Room room = new Room();
            Monster monster = new Monster();
            Character character = new Character();
            Weapon weapon = new Weapon();
            character.CharacterWeapon = weapon;
            Inventory inventory = new Inventory();
            Combatant combatant = new Combatant();
            Hero hero = new Hero();
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPlease choose an action:\n C.) Create a Character\n E.) Enter a room in the dungeon\n G.) Gauntlet Mode\n P.) Player Info\n M.) Monster Info\n X.) Exit Game\n");
                ConsoleKey userChoice = Console.ReadKey(true).Key;
             
                switch (userChoice)
                {
                    case ConsoleKey.C:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Enter a character name: ");
                        character.Name = Console.ReadLine();
                      
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
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
                                character.HitChance = 20;
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
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Please enter a valid choice!\n");
                                continue;
                            }
                        } while (validClassChoice != true);
                        
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
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
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("You need to create a character before you can enter a dungeon room!\n");
                            continue;
                        }
                        else
                        {
                            room.ExitRoom = false;
                            var randomNumRoom = new Random();
                            var randomNumMonster = new Random();

                            monster.RandomMonster = randomNumMonster.Next(1, monsters.Count+1);                           
                            room.RandomRoom = randomNumRoom.Next(1, battleRooms.Count+1);                            

                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("You have entered {0}.", battleRooms[room.RandomRoom].RoomName );
                            Console.WriteLine("The monster in this room is {0}.\n", monsters[monster.RandomMonster].Name);
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Please choose an action:\n A.) Attack\n R.) Run away\n M.) Monster Info\n X.) Exit Room\n");
                                ConsoleKey userChoiceRoom = Console.ReadKey(true).Key;

                                switch (userChoiceRoom)
                                {
                                    case ConsoleKey.A:
                                    {
                                        room.ExitRoom = combatant.DoBattle(monsters[monster.RandomMonster], character, character.CharacterWeapon, room.ExitRoom, hero);
                                        break;
                                    }
                                    case ConsoleKey.R:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("You have chosen to run away from {0} and live to fight another day", monsters[monster.RandomMonster].Name);
                                        break;
                                    }
                                    case ConsoleKey.M:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        monster.displayMonsterInfo(monsters[monster.RandomMonster], 1);
                                        break;
                                    }
                                    case ConsoleKey.X:
                                    {
                                        room.ExitRoom = true;
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;
                                    }
                                    default:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Please enter a choice from the menu!\n");
                                        continue;
                                    }
                                }
                            } while (room.ExitRoom!= true);
                            break;
                        }
                    case ConsoleKey.G:
                    {
                        Console.ForegroundColor= ConsoleColor.Magenta;
                        Console.WriteLine("You have chosen to challenge yourself in gauntlet mode!");
                        Console.WriteLine("You will face a new monster in each room, each one gets progressively stronger and more dangerous!");
                        Console.WriteLine("You can elevate your character to hero status by defeating enemies and increasing your strength and damage!");
                        Console.WriteLine("So if you fail or want to prepare yourself for the battles ahead you can exit and increase your experience and loot.");
                        Console.WriteLine("Once you have gained 200 experience you will be elevated to Hero Class! with bonus health and power!");
                        Console.WriteLine("Within these walls there is a enterprising merchant that will sell his goods to adventurers willing to pay his price!");
                        Console.WriteLine("Please choose wisely from the following options as your life may depend on it {0}!\n", character.Name);
                        
                        room.GauntletRoomID = 1;
                        room.ExitRoom = false;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please choose an action:\n B.) Buy From Merchant\n E.) Enter a room in the dungeon\n P.) Player Info\n M.) Monster Info\n X.) Exit Gauntlet Mode\n");
                            ConsoleKey userGauntletChoice = Console.ReadKey(true).Key;
                            switch (userGauntletChoice)
                            {
                                    case ConsoleKey.B:
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("Please choose an item you would like to purchase:\n H.) Health Potion\n S.) Shield\n W.) Hero Weapon\n");
                                    ConsoleKey userMerchantChoice = Console.ReadKey(true).Key;
                                    inventory.BuyInventoryItem(userMerchantChoice, merchantInventory, character );
                                    break;
                                }

                                case ConsoleKey.E:
                                {
                                    room.ExitRoom = false;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("{0}, you have entered the {1}. {2} has been empowered since you last saw it!", character.Name, battleRooms[room.GauntletRoomID].RoomName, monsters[room.GauntletRoomID].Name);
                                    do
                                    {
                                        Console.ForegroundColor= ConsoleColor.Green;
                                        Console.WriteLine("Please choose what action:\n A.) Attack\n M.) Monster Info\n P.) Player Info\n R.) Run Away\n X.) Exit Room\n");
                                        ConsoleKey userGauntletRoomChoice = Console.ReadKey(true).Key;
                                        
                                        switch (userGauntletRoomChoice)
                                        {
                                            case ConsoleKey.A:
                                            {
                                                combatant.DoBattle(monsters[room.GauntletRoomID], character, character.CharacterWeapon, room.GauntletRoomID, hero);
                                                    if (monsters[room.GauntletRoomID].CurrentHealth <= 0)
                                                        {
                                                            room.GauntletRoomCompleted = room.GauntletRoomID;
                                                            room.GauntletRoomID += 1;
                                                        }
                                                break;
                                            }
                                            case ConsoleKey.M:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                monster.displayMonsterInfo(monsters[room.GauntletRoomID], monsters[room.GauntletRoomID].MonsterID*2);
                                                break;
                                            }
                                            case ConsoleKey.P:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Blue;
                                                character.displayCharacterInfo(character);
                                                break;
                                            }
                                            case ConsoleKey.X:
                                            {
                                                room.ExitRoom = true;
                                                Console.ForegroundColor = ConsoleColor.White;
                                                break;
                                            }
                                            default:
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.WriteLine("Please enter a valid choice!\n");
                                                continue;
                                            }
                                        }
                                        break;
                                    } while (room.ExitRoom != true);
                                    break;
                                }
                                case ConsoleKey.M:
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    for (int i = 1; i <= monsters.Count; i++)
                                    {
                                        monster.displayMonsterInfo(monsters[i], i*2);
                                        Console.WriteLine();
                                    }
                                    break;
                                }
                                case ConsoleKey.P:
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    character.displayCharacterInfo(character);
                                    break;
                                }
                                case ConsoleKey.X:
                                {
                                    room.ExitRoom = true;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                                default:
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Please enter a valid choice!\n");
                                    continue;
                                }
                            }
                        } while (room.ExitRoom != true);
                        break;
                    }
                    case ConsoleKey.M:
                    {
                        for (int i = 1; i <= monsters.Count; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            monster.displayMonsterInfo(monsters[i], 1);
                            Console.WriteLine();
                        }
                        break;
                    }
                    case ConsoleKey.P:
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        character.displayCharacterInfo(character);
                        break;
                    }
                    case ConsoleKey.X:
                    {
                            Console.ForegroundColor = ConsoleColor.White;
                            Environment.Exit(0);
                        break;
                    }
                    default:
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Please enter a choice from the menu!\n");
                        continue;
                    }
                }
            }while (!exit);
        }
    }
}
