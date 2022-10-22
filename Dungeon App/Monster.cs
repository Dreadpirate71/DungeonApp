using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Monster : Combatant
    {
        //fields
        //private string monsterName;
        private string monsterType;
        //private string[,] monsters;
        private int[,] monsterStats;
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
       
        /*public string[,]Monsters
        {
            get { return monsters; }
            set { monsters = value; }
        }*/
        public int[,] MonsterStats
        {
            get { return monsterStats; }
            set { monsterStats = value; }
        }
    }
}
