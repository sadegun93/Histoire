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
    class Program
    {
        static void Main(string[] args)
        {
            //User awakes in a newly destroyed museum; Patron Diety asks if they are alright and if they remember their name
            //Blurb regarding some disaster that destroyed a city and set monsters loose everywhere
            //User asks for an intial direction from the cardinal four; west and north blocked by rubble
            //While traversing the floor, the player can come across bits and pieces of various exhibits
            //After finding the stairs, players can descend to another level of the museum on their journey to the exit
            //Once on the final floor, likely the most damaged of them all, the player can exit continue on with their life.

            //There are beasts within the museum, and should the player have a stroke of bad luck, they might perish before finding the exit. This would result in a game over.

            //Stores the name that is obtained from the Welcome Method

            //In the event that more Config classes are needed in the future
            //Their format will be: tfConfig, sfConfig, ffConfig
            Config tfConfig = new Config();

            /*When a warg is chosen for the player to interact with, the choice is saved to this int so it can be used in main.
            int WargChoice;
            //So lesserWargChoice from the ApproachlesserWarg Method can be used in the main method
            string lwc;
            //so normalWargChoice from the ApproachingnormalWarg Method can be used in the main method
            string nwc;

            //To save the player's choice of a room to enter on the second floor. Stands for the name of the method it's working with
            string sfrs;
            //To save the parsed value of the player's choice of a room
            int sfrsc;*/

            //Since the third floor is not static, an object of it needs to be made for it to function, hence the name.
            ThirdFloor tfObject = new ThirdFloor();
            //Since the second floor is not static, an object of it needs to be made for it to function, hence the name.
            SecondFloor sfObject = new SecondFloor();
            //Since the first floor is not static, an object of it needs to be made for it to function, hence the name.
            FirstFloor ffObject = new FirstFloor();

            //Sets console color to something other than the default white on black.
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Welcome to Histoire. You simply wanted to learn more about the world, but you've met with a terrible fate.");

            Console.ReadLine();

            SetUp.Rules();

            SetUp.GetGender();
            SetUp.SetPersonal(SetUp.GetPlayerGenderNum);
            SetUp.SetSubjective(SetUp.GetPlayerGenderNum);
            SetUp.SetPossessive(SetUp.GetPlayerGenderNum);
            SetUp.SetReflexive(SetUp.GetPlayerGenderNum);

            Console.ReadLine();

            SetUp.Introduction();

            SetUp.PersonalizedNumbers();

            Console.WriteLine("The game will be collecting a few more bits of information from you.");
            do
            {
                SetUp.UserFoodInput();
                Console.ReadLine();
            }
            while (SetUp.getMoreFood == "Y");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Now, the game will begin.");
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine();

            SetUp.Welcome(SetUp.GetPlayerGenderNum);

            Console.ReadLine();

            SetUp.Ready(SetUp.GetPlayerName);

            Console.ReadLine();

            tfObject.ExploringThirdFloor(tfObject.GetStepsString, tfObject.GetSteps, tfObject.LocalName, tfObject.LastName, ThirdFloor.GetDownToFloorTwo, tfObject.GetFirstComma, tfObject.GetSecondComma, ThirdFloor.GetMyColors, tfObject.GetThirdWord);

            Console.ReadLine();

            tfObject.RemovePillar(SetUp.GetPlayerName, tfConfig.GetRubbleRemovalOutcome);

            if (tfObject.GetLive == false)
            {
                Console.ReadLine();
                Console.WriteLine("As " + SetUp.GetPlayerName + " was moving the rubble, " + SetUp.GetPlayerPersonal + " heard a yelp.\nTurning around, " + SetUp.GetPlayerPersonal + " noticed that " + SetUp.GetPlayerPersonal + " had stepped on a warg's tail.");
                Console.WriteLine("The beast let out a low snarl, its red eyes piercing " + SetUp.GetPlayerName + "'s very being.");
                Console.WriteLine("Then, the warg lunged.");
                Config.GameEnd(SetUp.GetPlayerName);
            }

            Console.ReadLine();

            sfObject.EnteringSecondFloor(SetUp.GetPlayerName, tfObject.GetThirdColor);

            Console.ReadLine();

            sfObject.GetWarg.MeetWarg(sfObject.GetLesserWarg, sfObject.GetWarg, SetUp.GetPlayerName, sfObject.GetWargAttributes);

            Console.ReadLine();

            //Before giving players the option to explore rooms give them a few options to get around the Wargs
            //Before giving them an option, have the the two parameter Die Roll method from Config roll to determine if it is the Lesser Warg or Warg that the player has to get around.
            sfObject.GetWarg.SetWargRoll = sfObject.GetWarg.ApproachWargs(SetUp.GetPlayerName);

            if (sfObject.GetWarg.GetWargRoll == 1)
            {
                //lesserWarg
                //Write method(s) (if statements included) in the Wolf class and call them.
                //Include option to quit among choices
                sfObject.GetWarg.SetLesserWargChoice = sfObject.GetWarg.ApproachlesserWarg();
                Console.ReadLine();
                sfObject.GetWarg.EncounterlesserWarg(sfObject.GetWarg.GetLesserWargChoice, SetUp.GetPlayerName);
            }

            if (sfObject.GetWarg.GetWargRoll == 2)
            {
                //Warg
                //Write method(s) (if statements included) in the Wolf class and call them.
                //Include option to quit among choices
                sfObject.GetWarg.SetNormalWargChoice = sfObject.GetWarg.ApproachNormalWarg(sfObject.GetWarg);
                Console.ReadLine();
                sfObject.GetWarg.EncounternormalWarg(sfObject.GetWarg.GetNormalWargChoice, SetUp.GetPlayerName);
            }

            Console.ReadLine();

            //Exploration of the exhibits on the second floor
            Console.WriteLine("\"Now that you're past the Wargs, " + SetUp.GetPlayerName + ", we can try to explore the floor a bit.\"");

            do
            {
                sfObject.SetsfRoomSelect = sfObject.SecondFloorRoomSelect(SetUp.GetPlayerName);
                sfObject.SetsfRoomSelectNum = sfObject.SecondFloorRoomSelectConversion(sfObject.GetsfRoomSelect, SetUp.GetPlayerName);
                Console.ReadLine();
                sfObject.SecondFloorExhibits(sfObject.GetsfRoomSelectNum, SetUp.GetPlayerName);
                sfObject.ContinueExploringSecond();
            }
            while (sfObject.GetExploreSecondBool == true);

            Console.ReadLine();

            sfObject.ExitSecondFloor(SetUp.GetPlayerName);

            Console.ReadLine();

            ffObject.FirstFloorRoomSelect(SetUp.GetPlayerName);

            ffObject.FirstFloorRoomSelectConversion(ffObject.GetffRoomSelect, SetUp.GetPlayerName);

            Console.ReadLine();

            //In FirstFloor, FirstFloorRoomSelect will determine which exhibit players go to. 
            //Depending, it plays one of three scenarios in the above, with choices that determine if the player lives or dies
            //In the below, only the exhibits themselves, which will be void, will play out after the fact.

            do
            {
                if (ffObject.GetExploreFirstBool == true)
                {
                    Console.WriteLine("\"Where would you like to go?\"\n1. To the west\n2. To the east\n3. To the northwest.\n4. Quit");
                    ffObject.SetffRoomSelect = Console.ReadLine().Trim();
                    ffObject.FirstFloorRoomSelectConversion(ffObject.GetffRoomSelect, SetUp.GetPlayerName);
                }

                ffObject.ApproachExhibit(ffObject.GetffRoomSelectNum, SetUp.GetPlayerName);
                Console.ReadLine();
                ffObject.FirstFloorExhibits(ffObject.GetffRoomSelectNum, SetUp.GetPlayerName);
                ffObject.ContinueExploringFirst();
            }
            while (ffObject.GetExploreFirstBool == true);

            Console.ReadLine();

            ffObject.ApproachMuseumExit();

            Console.ReadLine();

            ffObject.Endgame();

            Console.WriteLine("Test");

            /*switch (ffObject.ffRoomSelectNum)
            {
                case 1:
                    ffObject.ScouringExhibit(playername);
                    break;
                case 2:
                    ffObject.WorldWarExhibit(playername);
                    break;
                case 3:
                    ffObject.GoldenAgeExhibit(playername);
                    break;
                default:
                    tfConfig.QuitGame();
                    break;
            }*/
            //ffObject.EnterFirstFloor(playername);

            //Console.Write("Press any key to continue . . .");
            //Console.Read();
        }
    }
}