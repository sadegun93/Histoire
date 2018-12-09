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
    public class SecondFloor
    {
        //Upon descending the stairs to the second floor, the player sees a signs for a number of exhibits, including:
        //1. Library - Contains primary sources from various points in history
        //2. Great War Pt. 3 - A large exhibit covering the final century of the Great War
        //3. Reconstruction - A companion exhibit to the above, focusing on the period of time immediately following the Great War
        //4. Operation Elysium - An exhibit about the plan Former Overseer Enlightment Division Director Xavier Phelp tried to be put into action, to be foiled by Prince Phillip Magis
        //5. Oslein and her People - Exhibit about Elven history and culture

        //All gets and/or sets that are created exist since their accompanying variable is used outside of the class in which it was created.

        //To keep track of the room the player chooses to explore, and if their unput was even a number or not.
        string sfRoomSelect;
        public string GetsfRoomSelect
        {
            get
            {
                return sfRoomSelect;
            }
        }
        public string SetsfRoomSelect
        {
            set
            {
                sfRoomSelect = value;
            }
        }

        int sfRoomSelectNum;
        public int GetsfRoomSelectNum
        {
            get
            {
                return sfRoomSelectNum;
            }
        }
        public int SetsfRoomSelectNum
        {
            set
            {
                sfRoomSelectNum = value;
            }
        }

        bool secondfloor;

        //Creates the two wargs that encounter the player
        Wolf Warg;
        public Wolf GetWarg
        {
            get
            {
                return Warg;
            }
        }

        Wolf lesserWarg;
        public Wolf GetLesserWarg
        {
            get
            {
                return lesserWarg;
            }
        }

        FirstFloor ffObject;

        //To keep track of what the player wants to do at the stairs leading down to the first floor
        string secondFloorStairs;
        int secondFloorStairsNum;

        //To save whether or not the player wants to keep exploring the second floor
        string keepExploringSecond;
        bool exploreSecondBool;
        public bool GetExploreSecondBool
        {
            get
            {
                return exploreSecondBool;
            }
        }

        //To roll for what values will be attributed to the wargs from the arrays in the Wolf Class
        int wargAttributes;
        public int GetWargAttributes
        {
            get
            {
                return wargAttributes;
            }
        }

        //The player enters the second floor, and this method shows them what exhibits they can see from the stairs.
        //As it only explains what they see, it is void
        public void EnteringSecondFloor(string playername, string thirdColor)
        {
            //While in the Main, the wargs work and can be met. Should try to see if it's possible to make it work when the wargs are created in a different class.
            Warg = new Wolf();
            lesserWarg = new Wolf();

            wargAttributes = Config.RollDie(0, 10);
            //Console.WriteLine(wargAttributes);

            Warg.SetHealth = 50;
            //Make a loop to increment lesserWarg Eyes
            for (int i = 0; i <= 9; i++)
            {
                Warg.GetEyes[i] = i + 1;
            }
            Warg.SetEyeColor = "blood red";

            Warg.GetTails[0] = 4;
            Warg.GetTails[1] = 10;
            Warg.GetTails[2] = 1;
            Warg.GetTails[3] = 7;
            Warg.GetTails[4] = 8;
            Warg.GetTails[5] = 3;
            Warg.GetTails[6] = 6;
            Warg.GetTails[7] = 2;
            Warg.GetTails[8] = 5;
            Warg.GetTails[9] = 9;

            Warg.SetLegs = 4;

            Warg.GetFurColor[0] = "gray";
            Warg.GetFurColor[1] = "black";
            Warg.GetFurColor[2] = "navy blue";
            Warg.GetFurColor[3] = "white";
            Warg.GetFurColor[4] = "brown";
            Warg.GetFurColor[5] = "mahogony";
            Warg.GetFurColor[6] = "pewter";
            Warg.GetFurColor[7] = "auburn";
            Warg.GetFurColor[8] = "beige";
            Warg.GetFurColor[9] = "blue";

            lesserWarg.SetHealth = 30;

            lesserWarg.GetEyes[0] = 8;
            lesserWarg.GetEyes[1] = 10;
            lesserWarg.GetEyes[2] = 3;
            lesserWarg.GetEyes[3] = 9;
            lesserWarg.GetEyes[4] = 1;
            lesserWarg.GetEyes[5] = 2;
            lesserWarg.GetEyes[6] = 4;
            lesserWarg.GetEyes[7] = 5;
            lesserWarg.GetEyes[8] = 6;
            lesserWarg.GetEyes[9] = 7;

            lesserWarg.SetEyeColor = "blue";
            //Make a loop to increment lesserWarg Tails
            for (int i = 0; i <= 9; i++)
            {
                lesserWarg.GetTails[i] = i + 1;
            }
            lesserWarg.SetLegs = 3;

            lesserWarg.GetFurColor[0] = "black";
            lesserWarg.GetFurColor[1] = "white";
            lesserWarg.GetFurColor[2] = "mahogony";
            lesserWarg.GetFurColor[3] = "auburn";
            lesserWarg.GetFurColor[4] = "blue";
            lesserWarg.GetFurColor[5] = "gray";
            lesserWarg.GetFurColor[6] = "navy blue";
            lesserWarg.GetFurColor[7] = "brown";
            lesserWarg.GetFurColor[8] = "pewter";
            lesserWarg.GetFurColor[9] = "beige";

            Console.WriteLine(playername + " descended the stairs now that the " + thirdColor + " rubble was gone.");
            Console.WriteLine("\n\"We're one step closer to getting ot of here! Now that you're on the second floor, what can you see?\"");
            Console.WriteLine("\nAt the prompt, you begin to look around.\nThere are a few signs that you can see from where you stand at the bottom of the stairs.");
            Console.WriteLine("A number of them " + playername + " recognizes from when " + SetUp.GetPlayerPersonal + " passed by the second floor earlier.");

            Console.ReadLine();

            Console.WriteLine("The first sign simply read 'Library'. " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " didn't go inside " + SetUp.GetPlayerReflex + ",\nBut overheard a tour guide say that it was filled with copies of notebooks, diaries,\nAnd other documents from throughout the centuries. Both official and civilian.");
            Console.ReadLine();
            Console.WriteLine("The next sign that " + playername + " saw read 'The Great War - The Final Days'. That one " + SetUp.GetPlayerPersonal + " did go into briefly.\nDespite being called the Final Days, it actually covered the last century of the Great War.\nIt was a really long period of time, but the name wasn't a complete lie.");
            Console.ReadLine();
            Console.WriteLine("Right next to the Great War exhibit was something called 'The Reconstruction'.\nAfter the Great War ended, the world entered a period dedicated to piecing things together\nSo the different cultures making up the Empire could coexist.");
            Console.ReadLine();
            Console.WriteLine("The fourth sign " + playername + " saw read 'Operation Elysium'. " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " had heard of it back in school.\nTo this day, some still argue whether or not the goal of Operation Elysium was just or not.");
            Console.ReadLine();
            Console.WriteLine("The last exhibit had a statue next to the sign: 'Oslein and her People'. The statue was of an Elven scholar.\nThat exhibit was a brief look into the history of the Elven People and their native homeland of Oslein.");
            Console.ReadLine();
            Console.WriteLine("While it wasn't an exhibit, there was also a concessions stand that appears to have gone mostly unscathed.");
        }


        //When players are given the option to explore, do the following:
        //Prompt them to select what room to enter
        //Save the choice and Parse it. Then pass that parsed int into a switch statement
        //In the switch statement, put in if in all of the cases. If (room int = 1), tell the player that they already entered the room. The else will just run the method as usual.
        //For each room method that will correspond to the parsed int, return a value that will save that the player entered that room. 
        //When the player returns to explore other rooms, they cannot enter the same room twice.
        //After exploring, ask the player if they would like to continue exploring. If yes:
        //Repeat the sequence of switch statements four times for the four remaining rooms that the player could explore.
        //For any time that the player might say "no" to continued exploration, guide them to the stairs down to the second floor.

        //As the name suggests, this method exists solely to figure out which exhibit the player would like to head towards first
        public string SecondFloorRoomSelect(string playername)
        {
            Console.WriteLine("\"Where do you want to go?\"");
            Console.WriteLine("1. Library\n2. The Great War - The Final Days\n3. The Reconstruction\n4. Operation Elysium\n5. Oslein and her People\n6. The Concession Stand");
            sfRoomSelect = Console.ReadLine().Trim();
            return sfRoomSelect;
        }

        //Converts what exhibit the player selects into an int.
        public int SecondFloorRoomSelectConversion(string sfRoomSelect, string playername)
        {
            secondfloor = int.TryParse(sfRoomSelect, out sfRoomSelectNum);

            //Prompts the player to enter a 1 - 5 assuming their original input was invalid
            while (secondfloor == false || sfRoomSelectNum > 6)
            {
                Console.WriteLine("Your entry was invalid. Please enter a 1, 2, 3, 4, 5 or 6. Where would you like to go?");
                Console.WriteLine("1. Library\n2. The Great War - The Final Days\n3. The Reconstruction\n4. Operation Elysium\n5. Oslein and her People\n6. The Concession Stand");
                sfRoomSelect = Console.ReadLine().Trim();
                secondfloor = int.TryParse(sfRoomSelect, out sfRoomSelectNum);
            }

            return sfRoomSelectNum;
        }

        //Shows the Library if the player selected it when first prompted
        public void Library(string playername)
        {
            //Player looks into the libary
            Console.WriteLine(playername + " peeked into the room and looked around Like the name would suggest, it was a normal library.");
            Console.WriteLine("There were rows upon rows of bookshelves. Some had fallen over in the impact that ruined the museum.\nQuite a few were still intact and standing, surprisingly.");
            Console.WriteLine("As much as " + playername + " would have wanted to stay and look, " + SetUp.GetPlayerPersonal + " had to keep moving.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " backed out of the library door.");
        }

        //Shows the Great War exhibit if the player selected it when first prompted
        public void GreatWarExhibit(string playername)
        {
            //Player looks into the Great War Exhibit
            Console.WriteLine("Looking into the Great War exhibit, " + playername + " was first draw to a large mural on the back wall.");
            Console.WriteLine("It was mostly untouched by the destruction of the library.\nIt depicted King Henry Magis II in the last battle of the Great War.");
            Console.WriteLine("The next thing " + playername + " noticed were two statues, of that very man and his some, Henry III.");
            Console.WriteLine(playername + " wanted to keep looking, but didn't want to risk anything. " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " turned from the exhibit.");
        }

        //Shows the Reconstruction exhibit if the player selected it when first prompted
        public void ReconstructionExhibit(string playername)
        {
            //Player looks into the Reconstruction Exhibit
            Console.WriteLine("As " + playername + " looked into the Reconstruction Exhibit, they were met by three statues.");
            Console.WriteLine("In the center was the largest statue, of King Henry Magis III, the Rebuilder.");
            Console.WriteLine("On either side of him were the other two who helped to piece the empire together after the Great War -\nHis son Henry IV, and his grandson Henry V." + playername + " had been curious about them.");
            Console.WriteLine("If only they weren't in danger, " + SetUp.GetPlayerPersonal + "'d be inside reading more about those men's exploits. Reluctantly, " + SetUp.GetPlayerPersonal + " turned back.");
        }

        //Shows the Operation Elysium exhibit if the player selected it when first prompted
        public void ElysiumExhibit(string playername)
        {
            //Player looks into the Operation Elysium Exhibit
            Console.WriteLine("In Operation Elysium exhibit was the most modern, which made sense.\nOf everything on the floor, Operation Elysium was the most recent.");
            Console.WriteLine("The picture at the back of the exhibit depicted part of the aftermath of the event.\nHis Majesty Phillip Magis had held an award ceremoney for this allies that fought alongside him.");
            Console.WriteLine(playername + " had seen it before. While it happened quite some time ago, there are still videos of it online.");
            Console.WriteLine(SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " turn back and move on. You knew quite a bit about it, so the exhibit wasn't as interesting as the others.");
        }

        //Shows the Oslein exhibit if the player selected it when first prompted
        public void OsleinExhibit(string playername)
        {
            //Player looks into the libary
            Console.WriteLine("The Oslein exhibit's most prominent feature was the statue in the center. It was of a beautiful elven woman.\nShe was the Elven Goddess Nyrella. Nearly all museum exhibits that have to do with elves feature her.");
            Console.WriteLine("From the statue, your eyes drifted to a fascinating painting of two elves fighting,\nOne with knives, and the other with his natural magical talent.");
            Console.WriteLine("Until fairly recently, elves not pursuing knowledge and magical expertise was taboo.");
            Console.WriteLine("The painting was trying to show that, it seems. With no time to spare, " + playername + " backed out of the exhibit.");
        }

        //Shows the Concession stand using their foods if the player selected it when first prompted
        public void ConcessionStand(string playername)
        {
            //Random object to choose a food from the UserFood list and int to go along with it
            Random concession = new Random();
            int snack = concession.Next(0, (SetUp.GetUserFood.Count + 1));
            
            //Player visits the concessions stand
            Console.WriteLine(playername + " approached the concessions stand. It was surprising to see it in one piece,\nconsidering how bad the rest of the museum looked.");
            Console.WriteLine("Looking around, " + SetUp.GetPlayerPersonal + " saw " + SetUp.GetUserFood[snack] + " among the food at the stand.\nAfter quickly looking to make sure the coast was clear, " + SetUp.GetPlayerPersonal + " took the food with them and walked away,\nhaving some as " + SetUp.GetPlayerPersonal + " walked.");
            
        }

        //Asks the player if they would like to continue exploring the second floor or not
        public Boolean ContinueExploringSecond()
        {
            Console.WriteLine("\"Do you want to continue exploring?\"\nY or N");
            keepExploringSecond = Console.ReadLine().Trim().ToUpper();

            //Prompts the player to Y or N assuming their original input was invalid
            while (String.IsNullOrEmpty(keepExploringSecond) || keepExploringSecond != "N" && keepExploringSecond != "Y")
            {
                Console.WriteLine("Your entry was invalid. Please enter a Y or N. Do you want to keep exploring?");
                keepExploringSecond = Console.ReadLine().Trim().ToUpper();
            }

            if (keepExploringSecond == "Y")
            {
                exploreSecondBool = true;
            }
            if (keepExploringSecond == "N")
            {
                exploreSecondBool = false;
            }

            return exploreSecondBool;
        }

        //Uses the player's choice of an exhibit to show them one of the exhibit methods from above.
        public void SecondFloorExhibits(int sfRoomSelectNum, string playername)
        {
            switch (sfRoomSelectNum)
            {
                case 1:
                    //Library Method
                    //Looking into Libary
                    Library(playername);
                    break;
                case 2:
                    //Great War Method
                    //Looking into Great War Exhibit
                    GreatWarExhibit(playername);
                    break;
                case 3:
                    //Reconstruction Method
                    //Looking into Reconstruction Exhibit
                    ReconstructionExhibit(playername);
                    break;
                case 4:
                    //Operation Elysium Method
                    //Looking into Operation Elysium Exhibit
                    ElysiumExhibit(playername);
                    break;
                case 5:
                    //Oslein Method
                    //Looking into Libary
                    OsleinExhibit(playername);
                    break;
                case 6:
                    //Concessions Stand Method
                    //Checking out the Concessions Stand
                    ConcessionStand(playername);
                    break;
                default:
                    //exit game Method
                    Config.QuitGame();
                    break;
            }
        }

        //When the player selects "n" for continueExploringSecond, this method players out to bring them to the stairs
        //They have a number of choices on how to proceed that either result in victory or death
        public void ExitSecondFloor(string playername)
        {
            ffObject = new FirstFloor();

            Console.WriteLine("\"That appears to have been everything on the floor. Let's get moving.\nThe stairs are this way.\"");
            Console.ReadLine();
            Console.WriteLine(playername + " followed the instructions that they were given to the stairs.\nWhere the stairs should have been was a disaster; much worse than the rubble blocking the last stairs they came across.");
            Console.WriteLine("There was so much rubble and debris that " + playername + " wondered if moving it would even be possible.");
            Console.ReadLine();
            Console.WriteLine("\"Thinking about this, it seems like there are a few things that you can do.\"");
            Console.WriteLine("\n\"You can always try to move it aside, though that would take quite a long time.\"");
            Console.WriteLine("\n\"Blasting it apart and trying to run through before that other Warg catches up could work.\"");
            Console.WriteLine("\n\"Or if you're worried, you can try and erect a wall of sorts to slow down the warg and blast it apart.\"");
            Console.WriteLine("\n\"What do you want to do?\"");
            Console.WriteLine("1. Take your time and move the debris and rubble\n2. Blast it apart and hope for the best\n3. Erect a wall to keep out the Warg\n4. Quit");
            secondFloorStairs = Console.ReadLine();

            bool secondStairs = int.TryParse(secondFloorStairs, out secondFloorStairsNum);

            //Prompts the player to enter a 1 - 4 assuming their original input was invalid
            while (secondStairs == false || secondFloorStairsNum > 5)
            {
                Console.WriteLine("Your entry was invalid. Please enter a 1, 2, 3 or 4. What would you like to do?");
                Console.WriteLine("1. Take your time and move the debris and rubble\n2. Blast it apart and hope for the best\n3. Erect a wall to keep out the Warg\n4. Quit");
                secondFloorStairs = Console.ReadLine().Trim();
                secondStairs = int.TryParse(secondFloorStairs, out secondFloorStairsNum);
            }

            Console.ReadLine();

            switch (secondFloorStairsNum)
            {
                  case 1:
                    //Move it aside
                    Console.WriteLine(playername + " gets to work moving the rubble and debris aside, bit by bit. It takes forever to do.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " move quietly, to avoid detection from the other Warg. In time, " + SetUp.GetPlayerPossess + " effort pays off.");
                    Console.WriteLine("Panting and covered in sweat, " + playername + " moves aside the last piece of rubble.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " look back one final time. The coast is clear.\nFeeling both hopeful and fearful, they descend to the final floor.");

                    Console.ReadLine();

                    ffObject.EnterFirstFloor(playername);
                    break;
                case 2:
                    //Blow up and run = death
                    //Text leading up to "THe last thing playername heard was"
                    Console.WriteLine("\"With a strong enough blast, the rubble should be gone and you should be able to make it! Give it a shot!\"");
                    Console.WriteLine(playername + " does as they are told. The sound of the blast reverberates throughout the floor.");
                    Console.WriteLine("As soon as the way is cleared, they make a break for it. Unfortunately, they weren't alone.\nThe Warg's heavy breaths are right on " + playername + "'s tail. It grunted, and then " + playername + " hit the ground hard.");
                    Config.GameEnd(playername);
                    break;
                case 3:
                    //wall
                    Console.WriteLine(playername + " built a small wall. It didn't reach up to the ceiling, but it should've been enough to stop a Warg.");
                    Console.WriteLine("With that extra bit of protection, " + SetUp.GetPlayerPersonal + " turned towards the rubble and blasted it apart.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " recoiled as some of it came flying at " + SetUp.GetPlayerSubject + ".");
                    Console.WriteLine("Behind the wall, " + playername + " heard the growling and scratching of the Warg.");
                    Console.WriteLine("\"Looks like that wall made all the difference. Come, you're almost out.\nOnwards, to the first and final floor.\"");

                    Console.ReadLine();

                    ffObject.EnterFirstFloor(playername);
                    break;
                case 4:
                    Config.QuitGame();
                    break;
                default:
                    Config.QuitGame();
                    break;
            }
              
        }

        /*When the player selects "n" for continueExploringSecond, this method players out to bring them to the stairs
        //They have a number of choices on how to proceed that either result in victory or death
        public void ExitSecondFloor(string playername)
        {
            ffObject = new FirstFloor();

            Console.WriteLine("\"That appears to have been everything on the floor. Let's get moving.\nThe stairs are this way.\"");
            Console.ReadLine();
            Console.WriteLine(playername + " followed the instructions that they were given to the stairs.\nWhere the stairs should have been was a disaster; much worse than the rubble blocking the last stairs they came across.");
            Console.WriteLine("There was so much rubble and debris that " + playername + " wondered if moving it would even be possible.");
            Console.ReadLine();
            Console.WriteLine("\"Thinking about this, it seems like there are a few things that you can do.\"");
            Console.WriteLine("\n\"You can always try to move it aside, though that would take quite a long time.\"");
            Console.WriteLine("\n\"Blasting it apart and trying to run through before that other Warg catches up could work.\"");
            Console.WriteLine("\n\"Or if you're worried, you can try and erect a wall of sorts to slow down the warg and blast it apart.\"");
            Console.WriteLine("\n\"What do you want to do?\"");
            Console.WriteLine("1. Take your time and move the debris and rubble\n2. Blast it apart and hope for the best\n3. Erect a wall to keep out the Warg\n4. Quit");
            secondFloorStairs = Console.ReadLine();

            bool secondStairs = int.TryParse(secondFloorStairs, out secondFloorStairsNum);

            //Prompts the player to enter a 1 - 4 assuming their original input was invalid
            while (secondStairs == false || secondFloorStairsNum >= 5)
            {
                Console.WriteLine("Your entry was invalid. Please enter a 1, 2, 3 or 4. What would you like to do?");
                Console.WriteLine("1. Take your time and move the debris and rubble\n2. Blast it apart and hope for the best\n3. Erect a wall to keep out the Warg\n4. Quit");
                secondFloorStairs = Console.ReadLine().Trim();
                secondStairs = int.TryParse(secondFloorStairs, out secondFloorStairsNum);
            }

            Console.ReadLine();

            switch (secondFloorStairsNum)
            {
                case 1:
                    //Move it aside
                    Console.WriteLine(playername + " gets to work moving the rubble and debris aside, bit by bit. It takes forever to do.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " move quietly, to avoid detection from the other Warg. In time, " + SetUp.GetPlayerPossess + " effort pays off.");
                    Console.WriteLine("Panting and covered in sweat, " + playername + " moves aside the last piece of rubble.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " look back one final time. The coast is clear.\nFeeling both hopeful and fearful, they descend to the final floor.");

                    Console.ReadLine();

                    ffObject.EnterFirstFloor(playername);
                    break;
                case 2:
                    //Blow up and run = death
                    //Text leading up to "THe last thing playername heard was"
                    Console.WriteLine("\"With a strong enough blast, the rubble should be gone and you should be able to make it! Give it a shot!\"");
                    Console.WriteLine(playername + " does as they are told. The sound of the blast reverberates throughout the floor.");
                    Console.WriteLine("As soon as the way is cleared, they make a break for it. Unfortunately, they weren't alone.\nThe Warg's heavy breaths are right on " + playername + "'s tail. It grunted, and then " + playername + " hit the ground hard.");
                    Config.GameEnd(playername);
                    break;
                case 3:
                    //wall
                    Console.WriteLine(playername + " built a small wall. It didn't reach up to the ceiling, but it should've been enough to stop a Warg.");
                    Console.WriteLine("With that extra bit of protection, " + SetUp.GetPlayerPersonal + " turned towards the rubble and blasted it apart.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " recoiled as some of it came flying at " + SetUp.GetPlayerSubject + ".");
                    Console.WriteLine("Behind the wall, " + playername + " heard the growling and scratching of the Warg.");
                    Console.WriteLine("\"Looks like that wall made all the difference. Come, you're almost out.\nOnwards, to the first and final floor.\"");

                    Console.ReadLine();

                    ffObject.EnterFirstFloor(playername);
                    break;
                case 4:
                    Config.QuitGame();
                    break;
                default:
                    Config.QuitGame();
                    break;
            }

        }*/
    }
}
