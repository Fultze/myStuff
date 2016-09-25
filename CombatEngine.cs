using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl1_Fultze
{
    class CombatEngine
    {
        private RandomDie _d;

        public CombatEngine() { _d = new RandomDie(); }

        public int Run(int val)
        {
            _d.DieSize = val;
            _d.Roll();
            int damage = _d.DieResult;
            return damage;
        }
    }
}
