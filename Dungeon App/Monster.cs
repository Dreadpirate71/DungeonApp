using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Monster : Combatant
    {
        //fields
        private string monsterType;
        private int randomMonster;
        private int randomMonsterDamage;
        private int randomMonsterBonus;
        private Dictionary<int, Monster> monsters;
        private int monsterID;
        


        //properties
        public int MonsterID
        {
            get { return monsterID; }
            set { monsterID = value; }
        }
        public Dictionary<int, Monster> Monsters
        {
            get { return monsters; }
            set { monsters = value; }
        }
        public int RandomMonsterBonus
        {
            get { return randomMonsterBonus; }
            set { randomMonsterBonus = value; }
        }
        public int RandomMonsterDamage
        {
            get { return randomMonsterDamage; }
            set { randomMonsterDamage = value; }
        }
       
        public int RandomMonster
        {
            get { return randomMonster; }
            set { randomMonster = value; }  
        }
        
        public string MonsterType
        {
            get { return monsterType; }
            set { monsterType = value; }
        }
        public void displayMonsterInfo(Monster monster, int monsterMultiplier)
        {
            Console.WriteLine("The monster {0} is a {1} type monster!", monster.Name, monster.MonsterType);
            Console.WriteLine("{0} Maximum Health = {1}.", monster.Name, monster.MaxHealth * monsterMultiplier);
            Console.WriteLine("{0} Minimum Damage = {1}.", monster.Name, monster.MinDamage * monsterMultiplier);
            Console.WriteLine("{0} Maximum Damage = {1}.", monster.Name, monster.MaxDamage * monsterMultiplier);
            Console.WriteLine("{0} Block = {1}.\n", monster.Name, monster.Block * monsterMultiplier);
        }

    }
}
