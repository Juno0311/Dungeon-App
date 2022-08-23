using DungeonLibrary;

namespace MonsterLibrary
{
    public class Monster : Character
    {
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public string Mega { get; set; }

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

        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, string mega) : base(name, life, maxLife, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
            Mega = mega;
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
            Mega = "It's a regular statue...";
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

********You think to yourself:
{Mega}
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

            #region regular monsters
            Bigfoot bigfoot = new Bigfoot("SCP 1000: Bigfoot", 40, 40, 70, 8, 20, 1, "A nocturnal, omnivorous ape, which were classified to be in the Hominini branch. They tend to travel in packs.", false, "Is that bigfoot?! ");
            King king = new King("SCP 001: Scarlet King", 45, 45, 70, 8, 40, 1, $@"While its physical appearance is still unknown to the Foundation, it can be concluded that it has a significant influence on humans who come across it
  __  __   ___   __  __ 
  \*) \*)  \*/  (*/ (*/
   \*\_\*\_|O|_/*/_/*/
    \_______________/", false, "What the hell is that thing?");
            Voices voices = new Voices("SCP 939: With Many Voices", 25, 25, 70, 8, 30, 1, $@"A pack animal with no fur, red slimy-looking skin that walks on all fours and claws on its arched back.
               __
              / _)
     _/\/\/\_/ /
   _|         /
 _|  (  | (  |
/__.-'|_|--|_|", false, "Is that a dog? Weird...");
            Nokia nokia = new Nokia("SCP 2700: Nokia", 40, 40, 70, 8, 25, 1, $@"A nokia phone with so much energy kept in the center of it that it will destroy the universe
 __i
|---|    
|[_]|    
|:::|    
|:::|    
`\   \   
  \_=_\ ", false, "A nokia phone... Why is it out here?");
            Baba baba = new Baba("SCP 352: Baba Yaga", 25, 25, 70, 8, 25, 1, $@"She appears to be a very old emaciated woman of indeterminate age and race. Hearing her talk, you can vaguely make out Old Russian mixed with other Russian accents
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
           `--...___   ___...--' (________)""", false, "What is she doing out of containment?");
            Man man = new Man("SCP 106: Old Man", 25, 25, 70, 8, 25, 1, $@"An elderly humanoid with a general appearance of advanced decomposition. While his human features may vary, the decomposition is always present
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
             (___.-(__.'\/", false, "Why is an old man here?");
            Cain cain = new Cain("SCP 073: Cain", 50, 50, 60, 10, 20, 1, $@"A heavily tanned male of arabic or middle eastern descent in his early 30s. Looking past his black hair, you can make out his blue eyes. Most of his limbs have been replaced with an unknown meta
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
     '---'", false, "Is that the Cain?");
            Doctor doctor = new Doctor("SCP 049: Plague Doctor", 45, 45, 70, 8, 25, 1, $@"A humanoid anomaly with the appearance of a Plague Doctor. Studies have shown that the mask is apart of the creatures bone structure
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
        ``         ``", false, "Aww, a cute little bear!");
            Bear bear = new Bear("SCP 1048-A: Builder Bear", 30, 30, 70, 8, 20, 1, $@"A small teddy bear, about 13 inches in height, made out of brown shades of fabric.
 __          __
/  \.-"""""" -./  \
\     - -      /
 |   o   o    |
 \  .-'''-.  /
  '-\__Y__/-'
     `---`", false, "Why is there a plague doctor here??");
            #endregion
            #region mega monsters
            Bigfoot apeBigfoot = new Bigfoot("SCP 1000: Bigfoot", 40, 40, 70, 8, 20, 1, "A nocturnal, omnivorous ape, which were classified to be in the Hominini branch. They tend to travel in packs. This one seems aggitated", true, "Is that ape standing?");
            Statue statueLooking = new Statue("SCP 173: The Sculpture", 40, 40, 70, 8, 30, 2, "This sculpture appears to be about 6'10 and is made of concrete and rebar. The face seen appears to be painted on with spray paint", true, "It's looking at you! Turn away now!");
            King kingFollower = new King("SCP 001: Scarlet King", 45, 45, 70, 8, 40, 1, $@"While its physical appearance is still unknown to the Foundation, it can be concluded that it has a significant influence on humans who come across it
  __  __   ___   __  __ 
  \*) \*)  \*/  (*/ (*/
   \*\_\*\_|O|_/*/_/*/
    \_______________/", true, "PRAISE BE TO THE SCARLET KING!!!");
            Voices angryVoices = new Voices("SCP 939: With Many Voices", 25, 25, 70, 8, 30, 1, $@"A pack animal with no fur, red slimy-looking skin that walks on all fours and claws on its arched back.
               __
              / _)
     _/\/\/\_/ /
   _|         /
 _|  (  | (  |
/__.-'|_|--|_|", true, "It looks like a dinosaur... I should run");
            Nokia nokiaMiddle = new Nokia("SCP 2700: Nokia", 40, 40, 70, 8, 25, 1, $@"A nokia phone with so much energy kept in the center of it that it will destroy the universe
 __i
|---|    
|[_]|    
|:::|    
|:::|    
`\   \   
  \_=_\ ", true, "Is the middle of the phone poking out?");
            Baba hallucinateBaba = new Baba("SCP 352: Baba Yaga", 25, 25, 70, 8, 25, 1, $@"She appears to be a very old emaciated woman of indeterminate age and race. Hearing her talk, you can vaguely make out Old Russian mixed with other Russian accents
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
           `--...___   ___...--' (________)""", true, "Why is she holding a knife...");
            Man manDimension = new Man("SCP 106: Old Man", 25, 25, 70, 8, 25, 1, $@"An elderly humanoid with a general appearance of advanced decomposition. While his human features may vary, the decomposition is always present
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
             (___.-(__.'\/",true, "Where did he take me? Where am I?");
            Cain cainAble = new Cain("SCP 073: Cain", 50, 50, 60, 10, 20, 1, $@"A heavily tanned male of arabic or middle eastern descent in his early 30s. Looking past his black hair, you can make out his blue eyes. Most of his limbs have been replaced with an unknown meta
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
     '---'", true, "Is that the Cain? He looks like he just saw God");
            Doctor aggDoctor = new Doctor("SCP 049: Plague Doctor", 45, 45, 70, 8, 25, 1, $@"A humanoid anomaly with the appearance of a Plague Doctor. Studies have shown that the mask is apart of the creatures bone structure
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
        ``         ``", true, "Why is there a plague doctor here, and why do they look so pissed?");
            Bear deadlyBear = new Bear("SCP 1048-A: Builder Bear", 30, 30, 70, 8, 20, 1, $@"A small teddy bear, about 13 inches in height, made entirely out of human ears with a hole near the head region
 __          __
/  \.-"""""" -./  \
\     - -      /
 |   o   o    |
 \  .-'''-.  /
  '-\__Y__/-'
     `---`", true, "What the hell is that thing?");
            #endregion

            Random rand = new Random();
            List<Monster> monsters = new List<Monster>()
            {
                  bear, bear, bear, bear, king, king, bigfoot, nokia, nokia, nokia, voices, voices, baba, baba, baba, baba, statue, statue, cain, man, man, man, doctor, doctor, doctor, bear, bear, bear, bear, king, king, bigfoot, nokia, nokia, nokia, voices, voices, baba, baba, baba, baba, statue, statue, cain, man, man, man, doctor, doctor, doctor, bear, bear, bear, bear, bear, deadlyBear, deadlyBear, deadlyBear, king, king, king, kingFollower, bigfoot, apeBigfoot, cain, cainAble, nokia, nokia, nokia, nokia, nokiaMiddle, nokiaMiddle, voices, voices, voices, angryVoices, baba, baba, baba, baba, baba, hallucinateBaba, hallucinateBaba, hallucinateBaba, statue, statue, statue, statueLooking, man, man, man, man, manDimension, manDimension, doctor, doctor, doctor, doctor, aggDoctor, aggDoctor
            };
            return monsters[rand.Next(monsters.Count)];
        }


    }//class
}//name