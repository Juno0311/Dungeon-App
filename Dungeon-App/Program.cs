using DungeonLibrary;
using MonsterLibrary;
using System;
using System.Diagnostics;
using System.Media;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // SoundPlayer music = new SoundPlayer();
         //   music.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "ambience.wav";
         //   music.PlayLooping();
            Console.WriteLine("╔╦╦╦═╦╗╔═╦═╦══╦═╗\r\n║║║║╩╣╚╣═╣║║║║║╩╣\r\n╚══╩═╩═╩═╩═╩╩╩╩═╝\r\n");
            Console.Title = "SCP Dungeon Battle";

            int score = 0;
            //Create a player
            //Character below will be replaced with Player at a later date. Using this for testing.
            //Character player = new Character("Test Character", 10, 10, 100, 100);
            Weapon pistol = new Weapon(25, 1, "Pistol", 10, false, WeaponType.Pistol);

            #region name
            Console.Write("Hello, Adventurer! What is your name? ");
            string userName = Console.ReadLine();
            #endregion

            #region race
            var races = Enum.GetValues(typeof(Race));
            int index = 1;
            foreach (var race in races)
            {
                Console.WriteLine($"{index}) {race}");
                index++;
            }
            Console.WriteLine("Please select a race from the list above using a numerical value.");
            int userInput = int.Parse(Console.ReadLine()) - 1;
            Race userRace = (Race)userInput;
            #endregion

            Console.Clear();

            Player player = new Player(userName, 70, 5, 40, 40, userRace, pistol);
            bool exit = false;

            do
            {
               

                bool reload = false;//boolean for inner loop. Reload new monster/room when true
                Console.WriteLine($"Hello, {player.Name}, may this site guide you to freedom.");
                string room = GetRoom();
                Console.WriteLine(room);
                Monster monster = Monster.GetMonster();
                Console.WriteLine("In the corner of the room, you can see " + monster.Name);
                do
                {
                 Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "S) SCP Info\n" +
                        "X) Exit\n");
                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case "A":
                            Console.WriteLine("Attack!");
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                score++;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"\nYou killed {monster.Name}!");
                                Console.ResetColor();
                                reload = true;
                            }
                            if (player.Life <= 0)
                            {
                                Console.WriteLine("Better luck next time, soldier\a");
                                exit = true;
                            }
                            //handle winning (reload) and losing (exit)
                            break;

                        case "R":
                            Console.WriteLine("You ran for the nearest door.");
                            Console.WriteLine($"{monster.Name} tries to reach out for you as you flee");
                            reload = true;
                            break;

                        case "P":
                            Console.WriteLine("Player Info");
                            Console.WriteLine(player);
                            Console.WriteLine("Monsters Defeated: " + score);
                            break;

                        case "S":
                            Console.WriteLine("SCP Info");
                            Console.WriteLine(monster);
                            break;

                        case "X":
                        case "E":
                        case "Escape":
                            Console.WriteLine("Hope you enjoyed <3");
                            //exit the game
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Please try again...");
                            break;
                    }
                } while (!exit && !reload);
            } while (!exit);
            Console.WriteLine("You defeated " + score + " SCP" + (score == 1 ? '.' : 's'));
            Console.WriteLine("\n\nThanks for playing! Press any key to exit...");
            Console.ReadKey();
        }//end Main()
        #region rooms
        private static string GetRoom()
        {
            string[] rooms =
            {
                "Break Room. You notice vending machines lined against the wall.",
                        "Cafeteria. You notice empty tables with trays and drinks left behind.",
                        "Laboratory. You notice instruments presumably used on the creatures kept here.",
                        "Hallway. It is lined with doors leading to more SCP rooms.",
                        "Library. The shelves are packed with books and files that cover anything and everything in the facility.",
                        "Armoury. The weapons left behind look rusted and inoperable.",
                        "Staff Dormatory. The beds were left a mess and personal belongings are scattered everywhere.",
                        "Class-D Zone. The beds look like nothing more than a twin matteress and thin fleece blanket. The walls are barren",
                        "Electrical Room. The air feels hot asnd sticky, you don't want to stay in here for long.",
                        "Medical Bay. The equipment looks busted and ruined."
            };
            Random rand = new Random();
            int arrayIndex = rand.Next(rooms.Length);
            string room = rooms[arrayIndex];
            return room;
        }//get room
        #endregion
    }//end class
}//end namespace