using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Nokia : Monster
    {
        public bool MiddleExposed { get; set; }

        public Nokia()
        {

        }

        public Nokia(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool middleExposed) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            MiddleExposed = middleExposed;
        }
        //To generate a "parent-compliant ctor,"
        //make sure the document is saved,
        //right click on Monster (parent class)
        //Select Quick Actions and Refactorings
        //Generate Constructor Class(params)
        //Add any unique params and handle assignment.
        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int result = Block;
            if (MiddleExposed)
            {
                result += Block / 2; // dividing in half gives it a bonus
                //result = result + (block/2)
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (MiddleExposed ? "What is that bright light?" : "Hm, just a phone.");
        }//tostring
    }
}
