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

        public Bear(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool typeA, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            TypeA = typeA;
        }
        public override int CalcHitChance()
        {
            int result = HitChance;
            if (TypeA)
            {
                result += HitChance / 4;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (TypeA ? "That Bear looks scary" : "Aww, cute teddy bear!");
        }//tostring
    }
}
