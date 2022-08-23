using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class King : Monster
    {
        public bool YouBelieve { get; set; }

        public King()
        {

        }

        public King(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool youBelieve) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            YouBelieve = youBelieve;
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
            if (YouBelieve)
            {
                result += Block / 2; // dividing in half gives it a bonus
                //result = result + (block/2)
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (YouBelieve ? "IT'S THE SCARLET KING! PRAISE BE TO HIM" : "What is that?");
        }//tostring
    }
}
