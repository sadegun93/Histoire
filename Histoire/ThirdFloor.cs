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
    class ThirdFloor
    {
        //This is the floor that the player wakes up on. They are introduced to their guide and begin to explore the floor.
        //When they reach the stairs, they find that they are being blocked by rubble, which they will move.
        //If they fail, it is a game over.

        //All gets and/or sets that are created exist since their accompanying variable is used outside of the class in which it was created.

        //Local name string, and a name to save the last name
        string localName;
        string lastName;
        public string LocalName
        {
            get
            {
                return localName;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        //To use the roll die at the end of the class
        Config tfConfig = new Config();

        //constant string of colors
        const string MY_COLORS = ("red,blue,orange,green,aquamarine,yellow,black,white");
        public static string GetMyColors
        {
            get
            {
                return MY_COLORS;
            }
        }
        //stores the value of the first comma in the string
        int firstComma;
        public int GetFirstComma
        {
            get
            {
                return firstComma;
            }
        }
        //stores the value of the second comma in the string
        int secondComma;
        public int GetSecondComma
        {
            get
            {
                return secondComma;
            }
        }
        //stores the value of the second comma minus the first comma minus one, since putting that as the length in a Substring takes up too much space.
        int thirdWord;
        public int GetThirdWord
        {
            get
            {
                return thirdWord;
            }
        }
        //Stores the third color from the cosntant string
        string thirdColor;
        public string GetThirdColor
        {
            get
            {
                return thirdColor;
            }
        }

        //number of steps saved in stepsstring, then converted to int, which is then subtracted from the number of steps to door
        //remainingsteps used when players still have a way to go before reaching the stairs
        //walk boolean is to see if players enter a number or not when wanting to move
        bool walk;
        const int DOWN_TO_FLOOR_TWO = 75;
        public static int GetDownToFloorTwo
        {
            get
            {
                return DOWN_TO_FLOOR_TWO;
            }
        }
        string stepsstring;
        public string GetStepsString
        {
            get
            {
                return stepsstring;
            }
        }
        int steps;
        public int GetSteps
        {
            get
            {
                return steps;
            }
        }
        int remainingsteps;
        //public int remainingsteps2;

        //This array exists to contain keep track of the walking to stairs scenarios that players have seen
        //If they see them, but don't walk enough steps to trigger the next event, they would just see it again
        //That should be avoided
        int[] stairWalk = new int[8];

        //Used to save whether or not the player rolled high enough to remove the rubble leading down to the second floor or not
        bool live;
        public bool GetLive
        {
            get
            {
                return live;
            }
        }

        //Encompasses exploration of the third floor, such as movement and when the player reaches the end of the floor and is ready to exit.
        public void ExploringThirdFloor(string stepsstring, int steps, string localName, string lastName, int DOWN_TO_FLOOR_TWO, int firstComma, int secondComma, string MY_COLORS, int thirdWord)
        {
            localName = SetUp.GetPlayerName;

            Console.WriteLine("\"I was wondering something, " + localName + ". What's your last name?\"");
            lastName = Console.ReadLine();

            while(String.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("\"Come on, now. No need to be so cold. What's your last name?\"");
                lastName = Console.ReadLine();
            }

            SetUp.SetFullName = localName + " " + SetUp.UppercaseFirst(lastName); ;

            Console.WriteLine("Ah, so your full name is " + SetUp.GetFullName + ". A fine name, that is.");

            Console.ReadLine();

            Console.Write("How many steps would you like to move?"); //Select any number between 1 and 10.");
            stepsstring = Console.ReadLine().Trim();

            walk = int.TryParse(stepsstring, out steps);

            while ((string.IsNullOrEmpty(stepsstring) == true) || walk == false)
            {
                if (string.IsNullOrEmpty(stepsstring) == true)
                {
                    stepsstring = "A blank space";
                }

                Console.WriteLine("\"Erm, I asked you to tell me how many steps you wanted to move, " + localName + ".\"");
                Console.WriteLine("\"" + stepsstring + " is not a number.\"");
                Console.Write("Please tell me how many steps you want to move.");
                stepsstring = Console.ReadLine().Trim();
                walk = int.TryParse(stepsstring, out steps);
            }

            //Code for moving around the floor
            //Start with calculating remaining steps until stairs
            remainingsteps = DOWN_TO_FLOOR_TWO - steps;
            //remainingsteps2 = remainingsteps;
            //For when players haven't yet reached the steps and still have a ways to go.
            if (steps < (DOWN_TO_FLOOR_TWO - 2))
            {
                Console.WriteLine("\"You still have some walking to do.\"\n\"At your current pace, it looks like the steps are " + remainingsteps + " steps away.\"");
            }
            //In the unlikely event that the player enters exactly 74, the message about them not being at the stairs would have been gramatically incorrect for the remaining step.
            if (steps == (DOWN_TO_FLOOR_TWO - 1))
            {
                Console.WriteLine("\"It looks like the steps just up ahead. Just one more step.\"");
            }
            //If the player would have passed the stairs, this stops them.
            if (steps >= DOWN_TO_FLOOR_TWO)
            {
                Console.WriteLine("\"Good. Looks like you're nearing the stairs. Let's head down.\"");
            }

            WalkingToStairs(remainingsteps);

            for (int r = remainingsteps; r > 1; r = remainingsteps)
            {
                Console.Write("How many steps would you like to move? "); //Select any number between 1 and 10.");
                stepsstring = Console.ReadLine().Trim();

                walk = int.TryParse(stepsstring, out steps);

                while ((string.IsNullOrEmpty(stepsstring) == true) || walk == false)
                {
                    if (string.IsNullOrEmpty(stepsstring) == true)
                    {
                        stepsstring = "A blank space";
                    }

                    Console.WriteLine("\"Erm, I asked you to tell me how many steps you wanted to move, " + localName + ".\"");
                    Console.WriteLine("\"" + stepsstring + " is not a number.\"");
                    Console.Write("Please tell me how many steps you want to move. ");
                    stepsstring = Console.ReadLine().Trim();
                    walk = int.TryParse(stepsstring, out steps);
                }

                if (steps <= (remainingsteps - 2))
                {
                    Console.WriteLine("\"You still have some walking to do. Looks like the stairs are still " + (remainingsteps - steps) + " steps away.\"");
                }
                if (steps == (remainingsteps - 1))
                {
                    Console.WriteLine("\"Looks like the stairs are just up ahead. One more step.\"");
                }
                if (steps >= remainingsteps)
                {
                    Console.WriteLine("\"Looks like we're nearing the stairs. Time to head down.\"");
                }
                remainingsteps = remainingsteps - steps;

                WalkingToStairs(remainingsteps);
            }
        }

        //This method, when filled out, will play out various scenarios for the player as they approach the stairs
        //Methods will change as the player gets closer and closer.
        public int WalkingToStairs(int remainingsteps)
        {
            //Create 8 different if statements in a new method to coincide with remaining steps
            //being 5 - 1, 6- 15, 16 - 25, and etc up to 66 - 75.
            //Each different collection of remainingsteps will play out a different small scenario

            if (remainingsteps <= 75 && remainingsteps >= 66)
            {
                if(stairWalk[0] == 0)
                {
                    //Player asks for a bit of information about guide
                    //Guide introduces themself as guardian diety, comparing it to a guardian angel
                    //to make it easier to understand
                    Console.ReadLine();
                    Console.WriteLine("'Who are you?'");
                    Console.WriteLine("\"This again? I suppose you do deserve an explanation of sorts.\"");
                    Console.WriteLine("\"Have you ever heard of a 'Patron Deity'?\"");
                    Console.WriteLine("'I've heard that before, but I don't know what it means.'");
                    Console.WriteLine("\"Makes sense. There are many who care to learn. Doesn't affect you much.\"\n\"Just think of me as your guardian angel.\"");
                    Console.ReadLine();
                }

                stairWalk[0]++;
                return stairWalk[0];
            }
            if (remainingsteps <= 65 && remainingsteps >= 56)
            {
                if (stairWalk[1] == 0)
                {
                    //The player wonders what happened, and the guide
                    //suggests that it was a terrible strong earthquake or some other similar natural disaster
                    Console.ReadLine();
                    Console.WriteLine("'What happened anyway?'");
                    Console.WriteLine("\"In all honesty, I'm not entirely sure. My best guess is an earthquake. Or maybe some other natural disaster.\"");
                    Console.ReadLine();
                }

                stairWalk[1]++;
                return stairWalk[1];
            }
            if (remainingsteps <= 55 && remainingsteps >= 46)
            {
                if (stairWalk[2] == 0)
                {
                    //Guide says that the player was out for some time
                    //In that time, a number of wild animals had entered, and tells the player to be extra cautious
                    Console.ReadLine();
                    Console.WriteLine("\"You were out for quite a long time. Animals got into the museum while you were unconscious.\"");
                    Console.WriteLine("'Animals? I doubt you mean some cute, friendly dog or cat, right?'");
                    Console.WriteLine("\"If only it were that innocent. No, these are beasts.\"");
                    Console.ReadLine();
                }

                stairWalk[2]++;
                return stairWalk[2];
            }
            if (remainingsteps <= 45 && remainingsteps >= 36)
            {
                if (stairWalk[3] == 0)
                {
                    //Player wonders what the Imperial Government will do to assist the city
                    Console.ReadLine();
                    Console.WriteLine("'What will the government be doing, now that the city's ruined?'");
                    Console.WriteLine("\"One can only hope that they'll put the empire's resources towards helping the people affected.\"\n\"That would be the best thing the government could do for its people now.\"");
                    Console.ReadLine();
                }

                stairWalk[3]++;
                return stairWalk[3];
            }
            if (remainingsteps <= 35 && remainingsteps >= 26)
            {
                if (stairWalk[4] == 0)
                {
                    //Player wonders that happened to other patrons
                    //Guide suggests that many of them got out
                    Console.ReadLine();
                    Console.WriteLine("'What happened to the other people that were in the museum with me?'");
                    Console.WriteLine("\"I imagine that most of them got out. Since most of the things around are just rubble,\"\n\"there can't be many people around.\"");
                    Console.ReadLine();
                }

                stairWalk[4]++;
                return stairWalk[4];
            }
            if (remainingsteps <= 25 && remainingsteps >= 16)
            {
                if (stairWalk[5] == 0)
                {
                    //Player wonders what happened to patrons who couldn't escape
                    //Guide doesn't say much
                    Console.ReadLine();
                    Console.WriteLine("'What happened to the people who couldn't get out?'");
                    Console.WriteLine("\"The ones who couldn't get out? I'm sure they're fine.\"");
                    Console.WriteLine("'Really?'");
                    Console.WriteLine("\"...\"");
                    Console.ReadLine();
                }

                stairWalk[5]++;
                return stairWalk[5];
            }
            if (remainingsteps <= 15 && remainingsteps >= 6)
            {
                if (stairWalk[6] == 0)
                {
                    //Player hopes that once they're out, they'll be able to find help of some sort
                    //Guide is optimistic
                    Console.ReadLine();
                    Console.WriteLine("'I wonder who's out there. A guild of some sort must be scrambling to help people.'");
                    Console.WriteLine("\"Yeah, you're right! Get out of here, and everything will be alright! I'm sure of it!\"");
                    Console.ReadLine();
                }

                stairWalk[6]++;
                return stairWalk[6];
            }
            if (remainingsteps <= 5 && remainingsteps > 1)
            {
                if (stairWalk[7] == 0)
                {
                    //As the player nears the stairs, their guide mentions that and wishes the player the best
                    //on their quest to escape
                    Console.ReadLine();
                    Console.WriteLine("\"I see the stairs up ahead. You're one step closer to freedom.\"\n\"Best of luck " + SetUp.GetPlayerName + ".\"");
                    Console.ReadLine();
                }

                stairWalk[7]++;
                return stairWalk[7];
            }
            stairWalk[7]++;
            return stairWalk[7];
        }

        //At the end of the floor, the player needs to remove a broken pillar that is blocking the stairs, hence the name. 
        //The random object controls the success rate of the removal.
        public bool RemovePillar(string playername, int rubbleRemovalOutcome)
        {

            //finds the position of the first comma
            firstComma = (MY_COLORS.IndexOf(","));
            //finds the position of the first comma that occurs after the original comma that was found
            firstComma = MY_COLORS.IndexOf(",", firstComma + 1);
            //find the position of the first comma that occurs after the next comma that ws found, and so on.
            secondComma = MY_COLORS.IndexOf(",", firstComma + 1);
            // purpose stated above when variable was created
            thirdWord = secondComma - firstComma - 1;
            thirdColor = MY_COLORS.Substring(firstComma + 1, thirdWord);
            //Below code is what would be needed to single out the third word in the string.
            //Console.WriteLine(MY_COLORS.Substring(firstComma + 1, thirdWord));

            //MY_COLORS = Console.WriteLine(MY_COLORS.IndexOf("," + 1, 3));
            //Console.WriteLine("" + MY_COLORS + "");
            Console.WriteLine("As " + playername + " approached the stairs they see that it is covered in large portions of broken pillars. They were " + thirdColor + ".");
            Console.WriteLine("They must've been from an exhibit of some sort, given their color.");

            Console.ReadLine();

            Console.WriteLine("\"What's this? The stairs are being blocked by rubble! We have to try and remove it to get down.\"");
            Console.WriteLine("\"Be careful while moving the rubble, " + playername + ". We don't know what might happen.\"");

            //Runs the RemoveRubble method. If the result is less than four, a boolean is returned false, which will give the player the game over text
            tfConfig.RemoveRubble(playername);
            if (tfConfig.GetRubbleRemovalOutcome <= 4)
            {
                live = false;
                return live;
            }

            Console.WriteLine("\"Aha! You got rid of the rubble, " + playername + "! Now you can proceed!\"\n\"One step closer to getting out of this place!\"");
            live = true;
            return true;
        }
    }
}
