using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl1_Fultze
{
    class Item
    {   // Create instance counters for each
        public class Weapon : Item
        {
            Weapon sword = new Weapon();
            // Instance counters

        }

        public class Potion : Item
        {
           static void Ether(Player target)
            {
                RandomDie x = new RandomDie();
                // Instance counters
                // target.setDamage();
            }
        }

        public class Treasure : Item
        {
            Treasure gold = new Treasure();
            // Instance counters

        }
    }
}
