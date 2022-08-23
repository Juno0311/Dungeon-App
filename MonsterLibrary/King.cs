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

        public King(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool youBelieve, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            YouBelieve = youBelieve;
        }
        
        public override int CalcBlock()
        {
            int result = Block;
            if (YouBelieve)
            {
                result += Block / 2;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (YouBelieve ? "IT'S THE SCARLET KING! PRAISE BE TO HIM" : "What is that?");
        }//tostring
    }
}
