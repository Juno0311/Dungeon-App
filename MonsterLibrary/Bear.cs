using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Bear : Monster
    {
        public bool TypeA { get; set; }

        public Bear()
        {

        }

        public Bear(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool typeA) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            TypeA = typeA;
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
            if (TypeA)
            {
                result += HitChance / 4; // dividing in half gives it a bonus
                //result = result + (block/2)
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (TypeA ? "That Bear looks scary" : "Aww, cute teddy bear!");
        }//tostring
    }
}
