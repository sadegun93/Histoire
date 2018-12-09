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
    public class Config
    {
        //All gets and/or sets that are created exist since their accompanying variable is used outside of the class in which it was created.

        //Two die who totals are added up to determine if the player successfully removes rubble. 
        //The results of these rolls are saved to two variables, then they are added and saved to the Outcome variable.
        //Random rubbleRemovaldice = new Random();
        //Random rubbleRemovaldice2 = new Random();
        int rubbleRemoval;
        int rubbleRemoval2;
        int rubbleRemovalOutcome;

        public int GetRubbleRemovalOutcome
        {
            get
            {
                return rubbleRemovalOutcome;
            }
        }
        public int SetRubbleRemovalOutcome
        {
            set
            {
                rubbleRemovalOutcome = rubbleRemoval + rubbleRemoval2;
            }
        }

        //For Activity 2 of HW05
        static int testRoll;

        //Is played at the end of the third floor to see if the player successfully gets down to the second floor or dies
        //Rolls to random dice to determine the result
        public int RemoveRubble(string playername)
        {

            Console.WriteLine("Two 6 sided dice will determine the outcome of " + playername + "'s attempts to move the rubble.\nIf their total is 4 or greater, " + SetUp.GetPlayerPersonal + "'ll suceed.\nThe die will now roll.");
            Console.ReadLine();
            rubbleRemoval = RollDie(6, 7);
            Console.WriteLine("The result of " + playername + "'s first roll was " + rubbleRemoval + ".");
            rubbleRemoval2 = RollDie(3, 1, 7);
            Console.WriteLine("The result of " + playername + "'s second roll was " + rubbleRemoval2 + ".");
            SetRubbleRemovalOutcome = GetRubbleRemovalOutcome;
            Console.WriteLine("The total of " + playername + "'s dice rolls was " + rubbleRemovalOutcome + ".");
            return rubbleRemovalOutcome;
        }

        //Dice method to remove one of the original random die for removing rubble. 
        //Accepts two inputs that act as it's upper and lower limits for rolling.
        public static int RollDie(int start, int end)
        {
            Random testDie = new Random();

            testRoll = testDie.Next(start, end);

            return testRoll;
        }

        //Dice method to remove one of the original random die for removing rubble. 
        //Accepts two inputs that act as it's upper and lower limits for rolling.
        //This version of the method also rolls multiple dice.
        public static int RollDie(int dieQuantity, int start, int end)
        {
            Random testDie = new Random();

            testRoll = testDie.Next(start, end);
            testRoll = testRoll * dieQuantity;
            testRoll = testRoll / dieQuantity;

            return testRoll;
        }

        //Is played whenever the player selects quit.
        //Plays a quick line of dialogue from the guide before exiting the game.
        public static void QuitGame()
        {
            Console.WriteLine("\"You want to quit? Erm... alright. I'm not sure why you would want to. Have a nice life, I guess?\"");
            //Console.Write("Press any key to continue . . .");
            //Console.Read();
            Environment.Exit(0);
        }

        //Is played whenever the player dies.
        //Is preceded by lines of text that personalize the game over.
        //However, each one ends with the generic game over text below of the guide screaming to the player
        public static void GameEnd(string playername)
        {
            //SetUp.SetPlayerName = playername;

            Console.WriteLine("The last thing that " + SetUp.GetPlayerName + " heard was their guide's voice.");
            Console.WriteLine("\"" + SetUp.GetPlayerName + "!\"");
            Console.WriteLine("\"" + SetUp.GetPlayerName + "!\"");
            Console.WriteLine("\"" + SetUp.GetPlayerName.ToUpper() + "!\"");
            //Console.Write("Press any key to continue . . .");
            //Console.Read();
            Environment.Exit(0);
        }
    }
}
