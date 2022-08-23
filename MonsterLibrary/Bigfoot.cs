using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Bigfoot : Monster
    {
        public bool MoreApeLike { get; set; }

       
        public Bigfoot(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool moreApeLike, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            MoreApeLike = moreApeLike;
        }
     
        public override int CalcBlock()
        {
            //return base.CalcBlock();
            int result = Block;
            if (MoreApeLike)
            {
                result += Block / 2;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (MoreApeLike ? "Is that ape standing?" : "Wow, it's Bigfoot!");
        }//tostring
    }
}
