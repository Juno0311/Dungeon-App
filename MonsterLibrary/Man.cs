using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Man : Monster
    {
        public bool HisDimension { get; set; }

        public Man(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool hisDimension, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            HisDimension = hisDimension;
        }
        public override int CalcBlock()
        {
            int result = Block;
            if (HisDimension)
            {
                result += Block / 4;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (HisDimension ? "Where am I?" : "Where is he?");
        }//tostring
    }
}
