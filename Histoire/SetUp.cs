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
    static class SetUp
    {
        //All gets and/or sets that are created exist since their accompanying variable is used outside of the class in which it was created.

        static string playername;

        //Creates a get to return the player's name
        public static string GetPlayerName
        {
            get
            {
                return playername;
            }
        }

        public static string SetPlayerName
        {
            set
            {
                playername = value;
            }
        }

        static string fullname;

        //Creates a get to return the player's name
        public static string GetFullName
        {
            get
            {
                return fullname;
            }
        }

        public static string SetFullName
        {
            set
            {
                fullname = value;
            }
        }

        //Gets the player's gender to the game knows what set of pronouns to use
        static string playerGender;
        static int playergenderNum;
        public static int GetPlayerGenderNum
        {
            get
            {
                return playergenderNum;
            }
        }
        //personal pronouns: he, she, they
        static string playerPersonal;
        public static string GetPlayerPersonal
        {
            get
            {
                return playerPersonal;
            }
        }
        //subjective pronouns: him, her, them
        static string playerSubject;
        public static string GetPlayerSubject
        {
            get
            {
                return playerSubject;
            }
        }
        //possessive pronouns: his, hers, their
        static string playerPossess;
        public static string GetPlayerPossess
        {
            get
            {
                return playerPossess;
            }
        }
        //reflexive pronouns: himself, herself, themself
        static string playerReflex;
        public static string GetPlayerReflex
        {
            get
            {
                return playerReflex;
            }
        }

        //Create a 10 space array of numbers that the player sets
        static int[] playerNumbers = new int[10];

        public static  int[] GetPlayerNumbers
        {
            get
            {
                return playerNumbers;
            }
            set
            {
                playerNumbers = value;
            }
        }

        //Creates a list for food that the player likes.
        static List<string> UserFood = new List<string>();

        public static List<string> GetUserFood
        {
            get
            {
                return UserFood;
            }
            set
            {
                UserFood = value;
            }
        }

        //Creates a boolean to verify whether or not the player entered a number.
        static Boolean personalNumbers;

        //For use with the UserFoodInput Method
        static string addFood;
        static int addFoodTest;
        static bool checkFood;
        static string moreFood;

        public static string getMoreFood
        {
            get
            {
                return moreFood;
            }
        }

        //Explains to the player how Histoire works
        public static void Rules()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("In Histoire, you are trying to exit a ruined museum.\nYou navigate the museum by moving a certain number of steps periodically.");
            Console.WriteLine("At times you will be prompted to input information to interact with the world around you.");
            Console.WriteLine("There are line breaks to help break up the larger blocks of text.");
            Console.WriteLine("Unless you are specifically prompted to input information,\nthere is no need to press anything aside from enter to proceed.");
            Console.WriteLine("----------------------------------------------------");
        }

        //Is used to get the player's gender, which will set the pronouns the game refers to their character by.
        public static int GetGender()
        {
            Console.WriteLine("Before beginning play, select your gender. This is simply so the game knows which pronoun to use.");
            Console.WriteLine("1. Male\n2. Female\n3. Other");
            playerGender = Console.ReadLine().Trim();
            Console.WriteLine("----------------------------------------------------");

            bool gender = int.TryParse(playerGender, out playergenderNum);

            //Prompts the player to enter a 1 - 3 assuming their original input was invalid
            while (gender == false || playergenderNum >= 5)
            {
                Console.WriteLine("Your entry was invalid. Please enter a 1, 2, or 3.");
                Console.WriteLine("1. Male\n2. Female\n3. Other");
                playerGender = Console.ReadLine().Trim();
                gender = int.TryParse(playerGender, out playergenderNum);
            }

            return playergenderNum;
        }

        //Set the player's personal pronouns using the number converted from their choice
        public static string SetPersonal(int playergenderNum)
        {
            switch (playergenderNum)
            {
                case 1:
                    playerPersonal = "he";
                    return playerPersonal;
                case 2:
                    playerPersonal = "she";
                    return playerPersonal;
                case 3:
                    playerPersonal = "they";
                    return playerPersonal;
                default:
                    playerPersonal = "they";
                    return playerPersonal;
            }
        }

        //Set the player's subjective pronouns using the number converted from their choice
        public static string SetSubjective(int playergenderNum)
        {
            switch (playergenderNum)
            {
                case 1:
                    playerSubject = "him";
                    return playerSubject;
                case 2:
                    playerSubject = "her";
                    return playerSubject;
                case 3:
                    playerSubject = "them";
                    return playerSubject;
                default:
                    playerSubject = "them";
                    return playerSubject;
            }
        }

        //Set the player's possessive pronouns using the number converted from their choice
        public static string SetPossessive(int playergenderNum)
        {
            switch (playergenderNum)
            {
                case 1:
                    playerPossess = "his";
                    return playerPossess;
                case 2:
                    playerPossess = "hers";
                    return playerPossess;
                case 3:
                    playerPossess = "their";
                    return playerPossess;
                default:
                    playerPossess = "their";
                    return playerPossess;
            }
        }

        //Set the player's reflexive pronouns using the number converted from their choice
        public static string SetReflexive(int playergenderNum)
        {
            switch (playergenderNum)
            {
                case 1:
                    playerReflex = "himself";
                    return playerReflex;
                case 2:
                    playerReflex = "herself";
                    return playerReflex;
                case 3:
                    playerReflex = "themself";
                    return playerReflex;
                default:
                    playerReflex = "themself";
                    return playerReflex;
            }
        }

        //In the event that the player's pronoun is at the start of a sentence, this will make the first letter capital.
        public static string UppercaseFirst(string pronoun)
        {
            // Return char and concat substring.
            return char.ToUpper(pronoun[0]) + pronoun.Substring(1);
        }

        //Briefly introduces the player to their roll in the game.
        public static void Introduction()
        {
            Console.WriteLine("You are a normal citizen of the Magianan Empire.\nYou were simply enjoying a trip to a local museum, when you heard some deafening noise.\nThen everything went black.");

            Console.ReadLine();

            Console.Write("Things are just now coming into view again.\n----------------------------------------------------");            
        }

        //Asks the player to input 10 different numbers to personalize gameplay for them
        public static void /*int[]*/ PersonalizedNumbers()
        {
            int[] array;
            int addToArray;

            array = GetPlayerNumbers;

            Console.WriteLine("\nBefore the game begins, you need to input a bit of information so tha game can be tailored to you.\n----------------------------------------------------");
            Console.WriteLine("You must enter 10 numbers, all of them between 10 and 100.");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Please enter number " + (i + 1) + " of " + array.GetLength(0) + ".");
                personalNumbers = int.TryParse(Console.ReadLine(), out addToArray);
                GetPlayerNumbers[i] = addToArray;

                while (personalNumbers == false || addToArray < 10 || addToArray > 100)
                {
                    Console.WriteLine("Your entry was invalid. Please enter number " + (i + 1) + " of " + array.GetLength(0) + ".");
                    personalNumbers = int.TryParse(Console.ReadLine(), out addToArray);
                }

            }

            Console.WriteLine("Now, your numbers will be displayed to you one final time before the game continues.");

            foreach (int i in GetPlayerNumbers)
            {
                //Console.WriteLine("For number " + (int x + 1) + " of " + PlayerNumbers.GetLength(0) + ", you entered " + i + ".");
                Console.WriteLine(i);
            }

            Console.WriteLine("\n----------------------------------------------------");
        }

        public static void UserFoodInput()
        {
            Console.WriteLine("Please enter a food that you enjoy.");
            addFood = Console.ReadLine();

            checkFood = int.TryParse(addFood, out addFoodTest);
            if(checkFood == true)
            {
                Console.WriteLine("It appears that you entered a number. That isn't food. Please enter something edible.");

                addFood = Console.ReadLine();

                checkFood = int.TryParse(addFood, out addFoodTest);
            }

            while (String.IsNullOrEmpty(addFood))
            {
                Console.WriteLine("You didn't enter a food. Please enter something edible.");
                addFood = Console.ReadLine();
            }

            SetUp.GetUserFood.Add(addFood);

            Console.WriteLine("Would you like to enter more foods? Y or N");
            moreFood = Console.ReadLine().Trim().ToUpper().Substring(0);

            while (String.IsNullOrEmpty(moreFood) || moreFood != "N" && moreFood != "Y")
            {
                Console.WriteLine("Your input was invalid. Please enter Y or N.");
                moreFood = Console.ReadLine().Trim().ToUpper().Substring(0);
            }

            if(moreFood == "N")
            {
                Console.WriteLine("Here is all of the different foods that you entered.");

                for (int i = 0; i < SetUp.GetUserFood.Count; i++)
                {
                    Console.WriteLine(UppercaseFirst(SetUp.GetUserFood[i]));
                }
            }
        }

        //Serves as the method that saves the player's name for future use.
        public static string Welcome(int playergenderNum)
        {
            string value;

            Console.WriteLine("\"Are you alright? That explosion was awful sudden.\"");
            Console.WriteLine("\"You've been unconscious for hours. I would say you're lucky to be alive.\"");

            Console.ReadLine();

            Console.WriteLine("'Who are you?'");

            Console.ReadLine();

            Console.Write("\"Who am I? Put simply, a guardian of sorts. But that isn't important.\"\n\"Do you remember your name?\" ");
            value = Console.ReadLine().Trim();

            while (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("\"Are you alright? You didn't tell me your name.\"\n\"I can't exactly help someone whose name I don't know, can I? Tell me, what's your name?\"");
                value = Console.ReadLine().Trim();
            }

            SetPlayerName = UppercaseFirst(value);

            return playername;
        }

        //Determines whether the player is ready to play. If anything other than yes, the game ends and closes.
        public static void Ready(string playername)
        {
            //player answer to being prepared for game. Converted from string to character of Y or N
            string ready;
            char readychar;

            Console.WriteLine("\"Alright. So your brain still works, at least. That's good.\"\n\"Now, we need to get out of here.\"");
            Console.WriteLine("\"You're on the fourth floor now.\"\n\"You need to find the stairs and head down.\"");

            Console.ReadLine();

            Console.WriteLine("\"I'll be guiding you through the museum from time to time.\"\n\"We'll be working together to get you out of here safely.\"");
            Console.WriteLine("\"You just have to respond when I speak to you. Simple enough, yeah?\"");
            Console.Write("\"Alright. Are you ready to get going?\"\nY/N ");

            ready = Console.ReadLine().Trim().ToUpper();

            //Prompts the player to Y or N assuming their original input was invalid
            while (String.IsNullOrEmpty(ready) || ready != "N" && ready != "Y")
            {
                Console.WriteLine("Your entry was invalid. Please enter a Y or N. Are you ready?");
                ready = Console.ReadLine().Trim().ToUpper();
            }

            readychar = ready[0];

            if (readychar == 'N')
            {
                Console.WriteLine("\"You aren't ready, you say? Well, while it's against my better judgement to leave you like this,\nI suppose I can't force you. Come back when you are ready.\"");
                Environment.Exit(0);
            }

            Console.ReadLine();

            Console.WriteLine("\"Good luck, " + playername + "! You'll need it.\"");
        }
    }
}
