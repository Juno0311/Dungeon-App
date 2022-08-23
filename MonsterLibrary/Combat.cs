using DungeonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterLibrary
{
    public class Combat
    {
        //this class will not have any fields properties or constructors
        //a method warehouse for combat functionality
        public static void DoAttack(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(300);
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//if
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            //player attacks first
            DoAttack(player, monster);
            //monster attacks second, if they're alive
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }//end DoBattle()

        }//end DoBattle()

    }//class
}//name
