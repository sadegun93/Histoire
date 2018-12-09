using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*AdegunS-HW01
 Author: Stephen Adegun
 Game Development and Algorithmic Problem Solving I
 September 7th, 2018
 Purpose: Simple Assignments and Output
 HW02 - Expressions Casting & String Class (Modified 09/14/2018)
 HW03 - String Math Random Classes (Modified 09/19/2018)
 HW04 - Test Functional Class Methods (Modified 09/26/2018)
 HW05 - Method Overloading & Parameters (Modified c.10/07/2018)
 HW06 - If Statements (Modified c. 10/13/2018)
 HW07 - Loops (Modified c. 10/20/2018)
 HW08 - Arrays (Modified c. 10/30/2018)
 HW09 - Lists & Dictionaries (Modified 11/05/2018)
 HW10 - Attributes and Encapsulation (Modified 11/07/2018)
 HW11 - Abstraction & Overriding Methods (Modified 11/16/2018)
 HW12 - Polymorphism, Interfaces and Inheritance (Modified 11/30/2018)
 Histoire Completed 12/9/2019
 */

namespace Histoire
{
    public class Wolf
    {
        //Will include all canine and wolflike creatures, such as the Warg mentioned in the Fourth Floor game over scenario, and the two created in the method below.

        //All gets and/or sets that are created exist since their accompanying variable is used outside of the class in which it was created.

        int WargRoll;
        public int GetWargRoll
        {
            get
            {
                return WargRoll;
            }
        }
        public int SetWargRoll
        {
            set
            {
                WargRoll = value;
            }
        }

        int health;
        public int SetHealth
        {
            set
            {
                health = value;
            }
        }

        int[] eyes = new int[10];
        public int[] GetEyes
        {
            get
            {
                return eyes;
            }
            set
            {
                eyes = value;
            }
        }

        int[] tails = new int[10];
        public int[] GetTails
        {
            get
            {
                return tails;
            }
            set
            {
                tails = value;
            }
        }

        int legs;
        public int SetLegs
        {
            set
            {
                legs = value;
            }
        }

        string eyeColor;
        public string SetEyeColor
        {
            set
            {
                eyeColor = value;
            }
        }

        string[] furColor = new string[10];
        public string[] GetFurColor
        {
            get
            {
                return furColor;
            }
            set
            {
                furColor = value;
            }
        }

        //Keeps track of what the player does should they encounter the lesser Warg
        string lesserWargChoice;
        public string GetLesserWargChoice
        {
            get
            {
                return lesserWargChoice;
            }
        }
        public string SetLesserWargChoice
        {
            set
            {
                lesserWargChoice = value;
            }
        }

        //Keeps track of what the player does should they encounter the normal Warg
        string normalWargChoice;
        public string GetNormalWargChoice
        {
            get
            {
                return normalWargChoice;
            }
        }
        public string SetNormalWargChoice
        {
            set
            {
                normalWargChoice = value;
            }
        }

        //Briefly introduces the two wargs as the player enters the first floor
        public void MeetWarg(Wolf lesserWarg, Wolf Warg, string playername, int wargAttributes)
        {
            Console.WriteLine("After taking in all of the exhibits that were on the floor, " + playername + " heard low growling.\nThey tense up, and tried to stay still as two wargs crept out into the hall.");
            Console.WriteLine("The smaller of the two wargs was " + lesserWarg.furColor[wargAttributes] + " and was limping on its " + lesserWarg.legs + " legs.\nIt's " + lesserWarg.eyes[wargAttributes] + " " + lesserWarg.eyeColor + " eyes were darting all around the floor. It doesn't seem like it saw you.");

            Console.WriteLine("The larger of the two wargs seemed much more threatening. It's " + Warg.furColor[wargAttributes] + " fur was dirty,\nspeckled gray with tiny flecks of rubble.\nThey had " + Warg.legs + " legs. It glanced at you with its " + Warg.eyes[wargAttributes] + " " + Warg.eyeColor + " eyes but didn't acknowledge you.\n" + Warg.tails[wargAttributes] + " tails were swishing behind it vigorously.");
        }

        //The player approaches the wargs, and the game randomly decides which one they have to deal with.
        public int ApproachWargs(string playername)
        {
            Console.WriteLine("\"The wargs are in your way, " + playername + ". We need to get around them somehow.\"");
            WargRoll = Config.RollDie(1, 3);
            return WargRoll;
        }

        //If the game rolls a one and the player approaches the lesser warg, 
        //then they are given a number of choices on how to deal with it.
        public string ApproachlesserWarg ()
        {
            Console.WriteLine("While the larger Warg paid you little mind, the smaller one glanced at you.");
            Console.ReadLine();
            Console.WriteLine("\"It looks like that one intends to give you some trouble. You have to do something.\"");
            Console.WriteLine("\"From what I see, there are a few things that you can do.\"");
            Console.ReadLine();
            Console.WriteLine("\"There's some rubble over there. You can always try to distract it by destroying it with your magic.\"");
            Console.WriteLine("\n\"Or you could always try running past it. After all, it is missing a leg. You should be able to outrun it.\"");
            Console.WriteLine("\n\"Or, for some horrible reason, you can try killing the thing. If it's missing a leg, it must already be hurt.\"");
            Console.WriteLine("\n\"What do you want to do?\"");
            Console.ReadLine();
            Console.WriteLine("1. Distract it\n2. Run past it\n3. Attack it\n4. Quit");
            lesserWargChoice = Console.ReadLine().Trim();
            return lesserWargChoice;
        }

        //After approaching the warg and making a choice, the game will determine if the player made a valid input and, 
        //if not, it will be looped until they do.
        //Then, with the 1, 2, 3, or 4, it plays out one of the scenarios.
        public void EncounterlesserWarg(string lesserWargChoice, string playername)
        {
            int lesserWargChoiceNum;

            bool lesser = int.TryParse(lesserWargChoice, out lesserWargChoiceNum);

            //Prompts the player to enter a 1 - 4 assuming their original input was invalid
            while (lesser == false || lesserWargChoiceNum >= 5)
            {
                Console.WriteLine("Your entry was invalid. Please enter a 1, 2, 3 or 4. What do you want to do?");
                Console.WriteLine("1. Distract it\n2. Run past it\n3. Attack it\n4. Quit");
                lesserWargChoice = Console.ReadLine().Trim();
                lesser = int.TryParse(lesserWargChoice, out lesserWargChoiceNum);
            }


            switch (lesserWargChoiceNum)
            {
                case 1:
                    //Distract the Warg
                    Console.WriteLine("As the Warg limped towards " + playername + ", " + SetUp.GetPlayerPersonal + " took the opportunity to conjure a small fireball near the rubble.");
                    Console.WriteLine("It blew up the rubble, which flew everywhere. Some of the tiny shards hit the Warg.\nIt turned around and started in that direction to investigate.");
                    Console.WriteLine("\"Now's your chance! Go!\"");
                    Console.WriteLine("At the voice's behest, " + playername + " started further down the floor's hall, a safe distance away from the beast.");
                    break;
                case 2:
                    //Run past the warg
                    Console.WriteLine("The Warg was inching closer, and with each step, " + playername + "'s heart beat faster and faster.");
                    Console.WriteLine("\"Don't just stand there! Now's your chance!\"");
                    Console.WriteLine(playername + " did as they were told and sprinted past the Warg. It turned and gave chase.");
                    Console.WriteLine("It followed for a time, but eventually, the sounds of its three feet faded.\nWhen " + SetUp.GetPlayerPersonal + " did, " + playername + " took that as a sign that " + SetUp.GetPlayerPersonal + " could stop and rest.");
                    Console.WriteLine("\"Looks like you got rid of it. Now we can look at the rest of the floor. Let's hope nothing else jumps out.\"\n\"You need to regain your stamina.\"");
                    break;
                case 3:
                    //Try to kill the warg, but fail
                    Console.WriteLine(playername + " conjured a spear of ice that floated by " + SetUp.GetPlayerPossess + " head for a moment.\nThe spear flew at the Warg, piercing it in the leg.");
                    Console.WriteLine("The beast howled in pain, but quickly shook it off. It lunged forward at " + playername + ".");
                    Config.GameEnd(playername);
                    break;
                case 4:
                    Config.QuitGame();
                    break;
                default:
                    Console.WriteLine("\"I'm not sure how the game is letting this happen. It shouldn't have been possible for this to be anything other than a 1 - 4.\"\n\"But, might as well exit since this anomaly has happened.\"");
                    //Console.Write("Press any key to continue . . .");
                    //Console.Read();
                    Environment.Exit(0);
                    break;
            }
        }

        //If the game rolls a two and the player approaches the larger warg, 
        //then they are given a number of choices on how to deal with it.
        public string ApproachNormalWarg(Wolf Warg)
        {
            Console.WriteLine("The larger warg stopped and looked at you with it's " + Warg.eyeColor + " eyes. They sent a shiver down their spine.");
            Console.ReadLine();
            Console.WriteLine("\"This isn't good. Of all the ones to notice you, it's that one.\"");
            Console.WriteLine("\"You have to try and do something, but what?\"");
            Console.ReadLine();
            Console.WriteLine("\"...\"");
            Console.ReadLine();
            Console.WriteLine("\"Ah, I have some ideas!\"");
            Console.ReadLine();
            Console.WriteLine("\"There's some rubble over there. You can always try to distract it by destroying it with your magic.\"");
            Console.WriteLine("\n\"You can't outrun it the way it is, but if you cripple it, maybe you'll have a chance.\"");
            Console.WriteLine("\n\"You can stand and fight. Maybe you'll be able to get the upper hand and kill it.\"");
            Console.WriteLine("\n\"What do you want to do?\"");

            Console.ReadLine();
            Console.WriteLine("1. Distract it\n2. Run past it\n3. Attack it\n4. Quit");
            normalWargChoice = Console.ReadLine().Trim();
            return normalWargChoice;
        }

        //After approaching the warg and making a choice, the game will determine if the player made a valid input and, 
        //if not, it will be looped until they do.
        //Then, with the 1, 2, 3, or 4, it plays out one of the scenarios.
        public void EncounternormalWarg(string normalWargChoice, string playername)
        {
            int normalWargChoiceNum;

            bool normal = int.TryParse(normalWargChoice, out normalWargChoiceNum);

            //Prompts the player to enter a 1 - 4 assuming their original input was invalid
            while (normal == false || normalWargChoiceNum >= 5)
            {
                Console.WriteLine("Your entry was invalid. Please enter a 1, 2, 3 or 4. What do you want to do?");
                Console.WriteLine("1. Distract it\n2. Run past it\n3. Attack it\n4. Quit");
                normalWargChoice = Console.ReadLine().Trim();
                normal = int.TryParse(normalWargChoice, out normalWargChoiceNum);
            }

            switch (normalWargChoiceNum)
            {
                case 1:
                    //Distract
                    Console.WriteLine("As the Warg crept towards " + playername + ", " + SetUp.GetPlayerPersonal + " took the opportunity to conjure a small fireball near the rubble.");
                    Console.WriteLine("It blew up the rubble, which flew everywhere. Some of the tiny shards hit the Warg.\nIt turned around and started in that direction to investigate.");
                    Console.WriteLine("\"Now's your chance! Go!\"");
                    Console.WriteLine("At the voice's behest, " + playername + " started further down the floor's hall, a safe distance away from the beast.");
                    break;
                case 2:
                    //Run past the warg, but fail
                    Console.WriteLine(playername + " conjured a spear of ice and shot it at one of the Warg's legs. When the ice dug in, it howled.");
                    Console.WriteLine("Despite the pain it must have been in, it didn't stop.");
                    Console.WriteLine("The Warg was inching closer, and with each step, " + playername + "'s heart beat faster and faster.");
                    Console.WriteLine("\"Don't just stand there! Now's your chance!\"");
                    Console.WriteLine(playername + " did as they were told and sprinted past the Warg. It turned and gave chase.");
                    Console.WriteLine("It followed for a time, but eventually, the sounds of its three feet faded. When " + SetUp.GetPlayerPersonal + " did, " + playername + "took that as a sign that " + SetUp.GetPlayerPersonal + " could stop and rest.");
                    Console.WriteLine("\"Looks like you got rid of it. Now we can look at the rest of the floor. Let's hope nothing else jumps out. You need to regain your stamina.\"");
                    Console.WriteLine(playername + " was resting, but " + SetUp.GetPlayerPossess + " breath got caught in " + SetUp.GetPlayerPossess + " throat when " + SetUp.GetPlayerPersonal + " heard light footsteps.");
                    Console.WriteLine("The warg entered one of the exhibits and went around to catch " + SetUp.GetPlayerSubject + " off guard.");
                    Console.WriteLine(playername + " tried to run, but was just too tired. The Warg tackled " + SetUp.GetPlayerSubject + " and " + SetUp.GetPlayerPersonal + " slammed into the ground.\nAs it's warm breath coated the back of " + SetUp.GetPlayerPossess + " neck, " + SetUp.GetPlayerPersonal + " heard " + SetUp.GetPlayerPossess + " guide crying out to " + SetUp.GetPlayerSubject + ".");
                    Config.GameEnd(playername);
                    break;
                case 3:
                    //Kill the warg
                    Console.WriteLine("The Warg lunged right at " + playername + ". " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " just narrowly rolled out of the way, landing on a knee.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " thought about what " + SetUp.GetPlayerPersonal + " could do, but there was little time to think.");
                    Console.WriteLine("An idea popped into " + SetUp.GetPlayerPossess + " head just at the Warg was charging at " + SetUp.GetPlayerSubject + " again.\nIt would have been risky, but it was worth a shot.\nAnything was better than being eaten.");
                    Console.WriteLine(playername + " waited until the last moment, right before the Warg was in killing distance.\nWhen it was close enough for " + playername + " to smell it's breath, " + SetUp.GetPlayerPersonal + " took action.");
                    Console.WriteLine("A spire shot up out of the ground, piercing the Warg's head. It let out one final,\npained yelp upon the impact, and then it's legs went limp.");
                    Console.WriteLine(playername + " stared at it for a second, trying to comprehend what had just happened.\nAt last, " + SetUp.GetPlayerPersonal + " shook " + SetUp.GetPlayerPossess + " head and stood.");
                    Console.WriteLine("\"I just have to commend you for that performance! It was magnificent, given the circumstances.\nNow that you killed it, we can get on with your journey.\"");
                    break;
                case 4:
                    Config.QuitGame();
                    break;
                default:
                    Console.WriteLine("\"I'm not sure how the game is letting this happen. It shouldn't have been possible for this to be anything other than a 1 - 4.\"\n\"But, might as well exit since this anomaly has happened.\"");
                    //Console.Write("Press any key to continue . . .");
                    //Console.Read();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
