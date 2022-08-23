using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Baba : Monster
    {
        public bool YouHallucinated { get; set; }

        public Baba(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool youHallucinated, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            YouHallucinated = youHallucinated;
        }
        public override int CalcBlock()
        {
            int result = Block;
            if (YouHallucinated)
            {
                result += Block / 2;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (YouHallucinated ? "What did I just see?" : "Is that an old woman?");
        }//tostring
    }
}
