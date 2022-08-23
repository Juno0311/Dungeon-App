using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Cain : Monster
    {
        public bool SawAble { get; set; }

        public Cain()
        {

        }

        public Cain(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool sawAble) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            SawAble = sawAble;
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
            if (SawAble)
            {
                result += Block / 4; // dividing in half gives it a bonus
                //result = result + (block/2)
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (SawAble ? "That Plague Doctor looks angry" : "Why the hell is there a plague doctor here?!?!");
        }//tostring
    }
}
