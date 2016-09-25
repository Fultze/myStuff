using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl1_Fultze
{
    class Player
    {
        public int HitPoints { get; set; } // Hitpoint Property
        private int Damage = 0; // Damage Property
        private static int instanceCount = 0; // Instance counter
        public bool Action = true; // Can't remember what this 
        public string Location { get; set; }
        

        private int experience; // create method for experience
        public int inventory = 0; // instance counter for how many items player has

        // Instance counter Constructor
        public Player() { instanceCount++; }

        // Player copy Constructor
        public Player(Player obj)
        {
            this.HitPoints = obj.HitPoints;
            this.Damage = obj.Damage;
        }

        // The Alive method is used to find out if Player is dead
        public bool Alive() { return HitPoints <= 0 ? false : true; }

        // The Player method of attacking 
        public int attack(int power, Creature target)
        {
            if (Alive() == true)
            {
                CombatEngine turn = new CombatEngine();
                int x = turn.Run(power);
                target.Action = true;
                this.Action = false;
                return target.setDamage(x);
            }

            return 0;

        }


        // The setDamage method is used when this Player takes damage
        public int setDamage(int amount)
        {
            while (Alive() == true)
            {
                HitPoints -= amount;
                Damage += amount;

                if (HitPoints < 0)
                    HitPoints = 0;

                return Damage;
            }
            return 0;
        }

        // Returns the Player current HitPoints
        public int getHitPoints() { return this.HitPoints; }

        // Returns the Player total Damage taken
        public int getDamage() { return this.Damage; }

        public void getItem(int number)
        {
            inventory++;
        }

        public void usePotion(int amount)
        {
            HitPoints += amount;
            

        }
    }
}
