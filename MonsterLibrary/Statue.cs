using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Statue : Monster
    {
        public bool LookingAtYou { get; set; }

        public Statue(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool lookingAtYou, string mega) : base(name, life, maxLife, hitChance, block, maxDamage, minDamage, description, mega)
        {
            LookingAtYou = lookingAtYou;
        }
       
        public override int CalcBlock()
        {
            int result = Block;
            if (LookingAtYou)
            {
                result += Block / 2;
            }
            return result;
        }//calcblock


        public override string ToString()
        {
            return base.ToString();
        }//tostring
    }//class
}
