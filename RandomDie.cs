using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl1_Fultze
{
    class RandomDie
    {
        // Fields
        private int _dieSize;
        private int _dieResult;
        private Random _rand;

        // No Args Constructor
        public RandomDie()
        {
            //_rand = new Random();
			_rand = new Random((int)DateTime.Now.Ticks & 0x0A60FFFF);
        }

        // Die Size (read/write)
        public int DieSize
        {
            get { return _dieSize; }
            set { _dieSize = value; }
        }
        
        public void Roll()
        {
            _dieResult = _rand.Next(_dieSize);
        }
        // Die Results (read-only)
        public int DieResult
        {
            get { return _dieResult; }
        }
    }
}
