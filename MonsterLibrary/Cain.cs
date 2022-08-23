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

        public Cain(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool sawAble, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            SawAble = sawAble;
        }
        public override int CalcBlock()
        {
            int result = Block;
            if (SawAble)
            {
                result += Block / 4;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (SawAble ? "That Plague Doctor looks angry" : "Why the hell is there a plague doctor here?!?!");
        }//tostring
    }
}
