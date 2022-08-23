using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        public Race CharacterRace { get; set; }
        private Weapon _equippedWeapon;
        public Weapon EquippedWeapon
        {
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }
        }

        public Player(string name, int hitChance, int block, int maxLife, int life, Race characterRace, Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life)
        {
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
            switch (CharacterRace)
            {
                case Race.Class_D:
                    MaxLife += 10;
                    Life += 10;
                    break;

                case Race.Researcher:
                    MaxLife += 20;
                    break;

                case Race.Field_Agent:
                    Block += 5;
                    break;

                case Race.O5_Council_Member:
                    MaxLife += 60;
                    Life += 60;
                    break;

                case Race.Site_Director:
                    MaxLife += 35;
                    Life += 35;
                    break;

                case Race.Containment_Specalist:
                    Block += 10;
                    break;

                default:
                    break;
            }//switch
        }//ctor

        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Class_D:
                    description = "As a Class-D member, you are the most disposible of members. You have seen many other members in your group taken off to different containment rooms and never return.";
                    break;

                case Race.Researcher:
                    description = "You are one of the more wise workers in the foundation, as it is your job to study the different anomalies kept at your site.";
                    break;

                case Race.Field_Agent:
                    description = "You spend the most time off-site as it is your job to be the eyes and ears for the foundation to find any signs of anomalous activity.";
                    break;

                case Race.O5_Council_Member:
                    description = "As an 05 Council Member, you are one of the most elite members of the foundation. Metaphorically speaking, you are at the top of the food chain";
                    break;

                case Race.Site_Director:
                    description = "Consider yourself the general manager. Anything that happens in the site is on your behalf as you run this site.";
                    break;

                case Race.Containment_Specalist:
                    description = "As a Containment Specalist, you are trained to capture anomalies and have them shipped out to the nearest foundation site.";
                    break;

                default:
                    break;
            }
            return base.ToString() +
                $"\nWeapon: {EquippedWeapon.Name}\n"
                + description;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            return damage;
        }

    }//class
}//name
