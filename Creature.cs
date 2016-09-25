using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawl1_Fultze
{
    class Creature
    {

        public int HitPoints { get; set; } // Hitpoint Property
        private int Damage = 0; // Damage Property 
        private static int instanceCount = 0; // Instance Counter 
        public bool Action = false;

        // Instance counter Constructor
        public Creature() { instanceCount++; } 

        // Returns the number of instances of this class that have been created
        public int getInstanceCount(){ return instanceCount; }

        // Creature copy Constructor
        public Creature(Creature obj)
        {
            this.HitPoints = obj.HitPoints;
            this.Damage = obj.Damage;
        }

        // The Alive method is used to find out if Creature is dead
        public bool Alive() { return HitPoints <= 0 ? false : true;}

        // The creatures method of attacking 
        public int attack(int power, Player target)
        {
              if(Alive() == true ) 
                {
                    CombatEngine turn = new CombatEngine();
                    int x = turn.Run(power);
                    target.Action = true;
                    this.Action = false;
                    return target.setDamage(x);
                }

            return 0;

        }

        // The setDamage method is used when this Creature takes damage
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

        // Returns the Creatures current HitPoints
        public int getHitPoints() { return this.HitPoints; }

        // Returns the Creatures total Damage taken
        public int getDamage() { return this.Damage; }

    } // END OF CLASS ***

} // END OF NAMESPACE ***

