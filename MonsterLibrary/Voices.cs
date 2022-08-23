using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Voices : Monster
    {
        public bool Angry { get; set; }

        public Voices(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool angry, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            Angry = angry;
        }
      
        public override int CalcHitChance()
        {
            int result = HitChance;
            if (Angry)
            {
                result += 5;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString();
        }//tostring
    }
}
