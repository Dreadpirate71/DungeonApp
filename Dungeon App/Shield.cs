using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon_App
{
    internal class Shield
    {
        private int shieldBlock;
        private int shieldBonusDamage;

        //constructors
        public int ShieldBlock
        {
            get { return shieldBlock; }
            set { shieldBlock = value; }
        }
        public int ShieldBonusDamage
        {
            get { return shieldBonusDamage; }
            set { shieldBonusDamage = value; }
        }
    }
}
