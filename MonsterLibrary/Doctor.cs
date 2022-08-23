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

        public Doctor(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool aggressive, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            Aggressive = aggressive;
        }
        public override int CalcHitChance()
        {
            int result = HitChance;
            if (Aggressive)
            {
                result += HitChance / 4;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString() + (Aggressive ? "That Plague Doctor looks angry" : "Why the hell is there a plague doctor here?!?!");
        }//tostring
    }//class
}
