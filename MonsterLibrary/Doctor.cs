using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public sealed class Doctor : Monster
    {
        public bool Aggressive { get; set; }

        public Doctor()
        {

        }

        public Doctor(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool aggressive) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Aggressive = aggressive;
        }
        //To generate a "parent-compliant ctor,"
        //make sure the document is saved,
        //right click on Monster (parent class)
        //Select Quick Actions and Refactorings
        //Generate Constructor Class(params)
        //Add any unique params and handle assignment.
        public override int CalcHitChance()
        {
            //return base.CalcBlock();
            int result = HitChance;
            if (Aggressive)
            {
                result += HitChance / 4; // dividing in half gives it a bonus
                //result = result + (block/2)
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (Aggressive ? "That Plague Doctor looks angry" : "Why the hell is there a plague doctor here?!?!");
        }//tostring
    }//class
}
