using DungeonLibrary;

namespace MonsterLibrary
{
    public class Monster : Character
    {
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        private int _minDamage;
        public int MinDamage
        {
            get { return _minDamage; }
            //cant be more than max damage, cant be less than 1
            set
            {
                if (value > MaxDamage) { _minDamage = 1; }
                //else if (value < 1) { _minDamage = 1; }
                else { _minDamage = value; }
            }//set
        }//public

        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, life, maxLife, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }

        public Monster()
        {
            Name = "SCP 173: The Sculpture";
            MaxLife = 40;
            Life = 40;
            HitChance = 70;
            Block = 8;

            MaxDamage = 30;
            MinDamage = 2;
            Description = "This sculpture appears to be about 6'10 and is made of concrete and rebar. The face seen appears to be painted on with spray paint";
        }//ctor
        //name life hitchance block
        public override string ToString()
        {
            return $@"
******** MONSTER ********
{Name}
Life: {Life}/{MaxLife}
Damage: {MinDamage}-{MaxDamage}
Block: {Block}
----Description----
{Description}

";
        }

        public override int CalcDamage()
        {
            // return base.CalcDamage();
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
        public static Monster GetMonster()
        {
            Monster statue = new Monster();
            Monster bear = new Monster("SCP 1048-A: Builder Bear", 30, 30, 70, 8, 20, 1, $@"A small teddy bear, about 13 inches in height, made entirely out of human ears with a hole near the head region
 __          __
/  \.-"""""" -./  \
\     - -      /
 |   o   o    |
 \  .-'''-.  /
  '-\__Y__/-'
     `---`");

            Monster doctor = new Monster("SCP 049: Plague Doctor", 45, 45, 70, 8, 25, 1, $@"A humanoid anomaly with the appearance of a Plague Doctor. Studies have shown that the mask is apart of the creatures bone structure
            _   _
          .-_; ;_-.
         / /     \ \
        | |       | |
         \ \.---./ /
     .-""~   .---.   ~""-.
   ,`.-~/ .'`---`'. \~-.`,
   '`   | | \(_)/ | |   `'
   ,    \  \ | | /  /    ,
   ;`'.,_\  `-'-'  /_,.'`;
    '-._  _.-'^'-._  _.-'
        ``         ``");

            Monster cain = new Monster("SCP 073: Cain", 50, 50, 60, 10, 20, 1, $@"A heavily tanned male of arabic or middle eastern descent in his early 30s. Looking past his black hair, you can make out his blue eyes. Most of his limbs have been replaced with an unknown meta
         ,   ,
        /////|
       ///// |
      /////  |
     |~~~| | |
     |===| |/|
     | B |/| |
     | I | | |
     | B | | |
     | L |  / 
     | E | /
     |===|/
     '---'");

            Monster man = new Monster("SCP 106: Old Man", 25, 25, 70, 8, 25, 1, $@"An elderly humanoid with a general appearance of advanced decomposition. While his human features may vary, the decomposition is always present
,
            ,:' `..;
            `. ,;;'%
            +;;'%%%%%
             /- %,)%%
             `   \ %%
              =  )/ \
              `-'/ / \
                /\/.-.\
               |  (    |
               |  |   ||
               |  |   ||
           _.-----'   ||
          / \________,'|
         (((/  |       |
         //    |       |
        //     |\      |
       //      | \     |
      //       |  \    |
     //        |   \   |
    //         |    \  |
   //          |    |\ |
  //           |    | \|
 //            \    \
c'             |\    \
               | \    \
               |  \    \
               |.' \    \
              _\    \.-' \ 
             (___.-(__.'\/");

            Monster baba = new Monster("SCP 352: Baba Yaga", 25, 25, 70, 8, 25, 1, $@"She appears to be a very old emaciated woman of indeterminate age and race. Hearing her talk, you can vaguely make out Old Russian mixed with other Russian accents
                   .---.
                  (_---_)
                 (_/6 6\_)
                  (  v  )
                   `\ /'
                .-'': ;``-.
               /   \,Y./   \
              /     (:)___  \
             :   .-'XXX`-.`\_;
              `.__.-XXX-.__.'\_
               /  / XXX \  \   `\_
              /      XXX    \     `\
             /        XXX    \     _`\___
            /                 \  (`--"" - ')
           /                   \ (=-=-=-= -)
           `--...___   ___...--' (________)""");

            Monster nokia = new Monster("SCP 2700: Nokia", 40, 40, 70, 8, 25, 1, $@"A nokia phone with so much energy kept in the center of it that it will destroy the universe
 __i
|---|    
|[_]|    
|:::|    
|:::|    
`\   \   
  \_=_\ ");

            Monster voices = new Monster("SCP 939: With Many Voices", 25, 25, 70, 8, 30, 1, $@"A pack animal with no fur, red slimy-looking skin that walks on all fours and claws on its arched back.
               __
              / _)
     _/\/\/\_/ /
   _|         /
 _|  (  | (  |
/__.-'|_|--|_|");

            Monster king = new Monster("SCP 001: Scarlet King", 45, 45, 70, 8, 40, 1, $@"While its physical appearance is still unknown to the Foundation, it can be concluded that it has a significant influence on humans who come across it
  __  __   ___   __  __ 
  \*) \*)  \*/  (*/ (*/
   \*\_\*\_|O|_/*/_/*/
    \_______________/");

            Bigfoot bigfoot = new Bigfoot("SCP 1000: Bigfoot", 40, 40, 70, 8, 20, 1, "A nocturnal, omnivorous ape, which were classified to be in the Hominini branch. They tend to travel in packs.", true);

            Bigfoot apeBigfoot = new Bigfoot("SCP 1000: Bigfoot", 40, 40, 70, 8, 20, 1, "A nocturnal, omnivorous ape, which were classified to be in the Hominini branch. They tend to travel in packs.", false);

            Doctor aggDoctor = new Doctor();
            Voices angryVoices = new Voices();
            Statue statueLooking = new Statue();
            Nokia nokiaMiddle = new Nokia();
            Man manDimension = new Man();
            King kingFollower = new King();
            Cain cainAble = new Cain();
            
            Bear deadlyBear = new Bear();
            Baba hallucinateBaba = new Baba();


            Random rand = new Random();
            List<Monster> monsters = new List<Monster>()
            {
                  bear, bear, bear, bear, king, king, bigfoot, nokia, nokia, nokia, voices, voices, baba, baba, baba, baba, statue, statue, cain, man, man, man, doctor, doctor, doctor, bear, bear, bear, bear, king, king, bigfoot, nokia, nokia, nokia, voices, voices, baba, baba, baba, baba, statue, statue, cain, man, man, man, doctor, doctor, doctor, bear, bear, bear, bear, bear, deadlyBear, deadlyBear, deadlyBear, king, king, king, kingFollower, bigfoot, apeBigfoot, cain, cainAble, nokia, nokia, nokia, nokia, nokiaMiddle, nokiaMiddle, voices, voices, voices, angryVoices, baba, baba, baba, baba, baba, hallucinateBaba, hallucinateBaba, hallucinateBaba, statue, statue, statue, statueLooking, man, man, man, man, manDimension, manDimension, doctor, doctor, doctor, doctor, aggDoctor, aggDoctor
            };
            return monsters[rand.Next(monsters.Count)];
        }


    }//class
}//name