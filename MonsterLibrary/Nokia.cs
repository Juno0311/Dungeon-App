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

        public Nokia(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool middleExposed, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            MiddleExposed = middleExposed;
        }
        public override int CalcBlock()
        {
            int result = Block;
            if (MiddleExposed)
            {
                result += Block / 2;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString();
        }//tostring
    }
}
