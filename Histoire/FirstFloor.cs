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
    //Histoire's analog to the basement that is lined out in the homework prequel
    public class FirstFloor
    {
        //The final floor, being underneath all of the others, will be the most ruined and dangerous of the floors that the player explores.
        //Nothing is known about what awaits the player on this final floor, other than the fact that it will be the most hazardous.

        //All gets and/or sets that are created exist since their accompanying variable is used outside of the class in which it was created.

        string ffRoomSelect;
        public string GetffRoomSelect
        {
            get
            {
                return ffRoomSelect;
            }
        }
        public string SetffRoomSelect
        {
            set
            {
                ffRoomSelect = value;
            }
        }

        int ffRoomSelectNum;
        public int GetffRoomSelectNum
        {
            get
            {
                return ffRoomSelectNum;
            }
        }


        //To save the player's choice as to how they want to approach the various exhibits, and what exhibit they chose.
        string approachWestExhibit;
        int approachWestExhibitNum;

        string approachEastExhibit;
        int approachEastExhibitNum;

        string approachNWExhibit;
        int approachNWExhibitNum;

        //To save whether or not the player wants to keep exploring the first floor
        string keepExploringFirst;
        bool exploreFirstBool;
        public bool GetExploreFirstBool
        {
            get
            {
                return exploreFirstBool;
            }
        }

        //To keep track of whether or not the player already passed the trial to get to a specific exhibit
        int scouring;
        int world;
        int gold;

        //To keep track of what griffin the game decides the player will encounter
        int griffinRoll;
        Griffin NubbyOrNeville;

        //To keep track of if the player chooses to touch the griffin.
        string touchGriffin;
        int touchGriffinNum;
        bool checkTouchGriffin;

        //For the creature eating methods while heading to the World War Exhibit
        string lunch;
        int lunchNum;
        bool verifyLunch;

        //public Wolf frenziedDog;

        //While the player cannot see signs for them, they can explore the first floor. On it are the following exhibits:
        //West: The largest exhibit int he museum, a Scouring Exhibit
        //East: An exhibit about the world war from the early 600s
        //Northwest: An exhibit about the Dracomorphi Golden Age

        //The player enters the first floor, and this method shows them what they can see from the stairs.
        //As it only explains what they see, it is void
        public void EnterFirstFloor(string playername)
        {
            Console.WriteLine("As " + SetUp.GetPlayerPersonal + " climbed the stairs down to the first floor, " + playername + " nearly bumped into a broken pillar.");
            Console.WriteLine("Looking around, "+ SetUp.GetPlayerPersonal + " saw that the first floor was in shambles.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " would barely be able to move without fear of impaling " + SetUp.GetPlayerPossess + " foot on a rock.");
            Console.WriteLine("There were some exhibits on the first floor was well, but it was too damaged to really tell what any of them were.");
            Console.WriteLine("It kind of looked like " + playername + " would be able to reach them if " + SetUp.GetPlayerPersonal + " tried hard enough.");
            Console.WriteLine("There were faint streaks of light ahead of " + SetUp.GetPlayerSubject + ". The exit.\n" + playername + " would have to cross this veritable No Man's Land to get there, but it was so close.");
        }

        //As the name suggests, this method exists solely to figure out which exhibit the player would like to head towards first
        public string FirstFloorRoomSelect(string playername)
        {
            Console.WriteLine("\"This place is like a labyrinth. I'm not sure how simple it will be to get over to the exit on the other side.\"");
            Console.WriteLine("\"All I can tell is that one exhibit it to your west, one to the east, and the final one to the northwest.\"\n\"We might as well get searching. Where do you want to go first?\"");
            Console.WriteLine("1. To the west\n2. To the east\n3. To the northwest.\n4. Quit");
            ffRoomSelect = Console.ReadLine().Trim();
            return ffRoomSelect;
        }

        //Converts the player's choice of an exhibit to head towards to an integer to be used in a switch statement
        public int FirstFloorRoomSelectConversion(string ffRoomSelect, string playername)
        {
            bool firstFloor = int.TryParse(ffRoomSelect, out ffRoomSelectNum);

            //Prompts the player to enter a 1 - 4 assuming their original input was invalid
            while (firstFloor == false || ffRoomSelectNum >= 5)
            {
                Console.WriteLine("Your entry was invalid. Please enter a 1, 2, 3 or 4. Where would you like to go?");
                Console.WriteLine("1. To the west\n2. To the east\n3. To the northwest.\n4. Quit");
                ffRoomSelect = Console.ReadLine().Trim();
                firstFloor = int.TryParse(ffRoomSelect, out ffRoomSelectNum);
            }
            return ffRoomSelectNum;
        }

        //Uses the integer returned from the conversion method to determine which exhibit the player approaches
        //And which trial they first have to overcome.
        public int ApproachExhibit(int ffRoomSelectNum, string playername)
        {
            /*frenziedDog = new Wolf();
            frenziedDog.health = 35;
            frenziedDog.eyes = 2;
            frenziedDog.eyeColor = "deep brown";
            frenziedDog.furColor = "brown";
            frenziedDog.legs = 4;
            frenziedDog.tails = 1;*/

            switch (ffRoomSelectNum)
            {
                case 1:
                    //West Scouring Exhibit
                    if (scouring == 0)
                    {
                        Console.WriteLine("The western exhibit was fairly close to the stairs. " + playername + " started towards it.");
                        Console.WriteLine("As " + SetUp.GetPlayerPersonal + " approached, " + SetUp.GetPlayerPersonal + " saw that there was some rubble blocking it. It didn't look too torturous.\nLike something that could easily be scaled or destroyed.");
                        Console.WriteLine(playername + " thought that " + SetUp.GetPlayerPersonal + " could hear something from the rubble. Almost like a faint whimper.");
                        Console.WriteLine("1. Climb over the rocks\n2. Blow them up");
                        approachWestExhibit = Console.ReadLine().Trim();
                        Console.ReadLine().Trim();

                        bool west = int.TryParse(approachWestExhibit, out approachWestExhibitNum);

                        //Prompts the player to enter a 1 - 4 assuming their original input was invalid
                        while (west == false || approachWestExhibitNum >= 3)
                        {
                            Console.WriteLine("Your entry was invalid. Please enter a 1, 2, 3 or 4. Where would you like to go?");
                            Console.WriteLine("1. Climb over the rocks\n2. Blow them up");
                            approachWestExhibit = Console.ReadLine().Trim();
                            west = int.TryParse(approachWestExhibit, out approachWestExhibitNum);
                        }

                        if (approachWestExhibitNum == 1)
                        {
                            //Climb, uncover frenzied dog, die
                            Console.WriteLine(playername + " started to climb the rubble. " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " were making good progress, and things seemed fine.");
                            Console.WriteLine("The sound that " + SetUp.GetPlayerPersonal + " heard earlier steadily grew louder, until one of the pieces of rubble started to shake.");
                            Console.WriteLine(playername + " placed " + SetUp.GetPlayerPossess + " hand on it, and it came loose. " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " went stumbling down to the ground, landing with a thud.");
                            Console.WriteLine("Sitting up, a dog was before " + SetUp.GetPlayerSubject + ", frantically looking around. One of its legs looked broken, and it's fur was dirty.");
                            Console.WriteLine(playername + " tried to reach for the dog, but it turned and started barking ferociously.\nThe frenzied creature let out a low growl, then lunged right at " + playername + ".");
                            Config.GameEnd(playername);
                        }
                        if (approachWestExhibitNum == 2)
                        {
                            //blow up rubble, kill dog
                            Console.WriteLine(playername + " backed up away a bit from the rubble and conjured an explosion to blast it away.");
                            Console.WriteLine("The whimpering " + SetUp.GetPlayerPersonal + " had heard earlier turned into yelp,\nAnd something flew out of the rubble only to land with on the ground with a smack.");
                            Console.WriteLine("\"What was that?!\"");
                            Console.WriteLine(playername + " ran over to see what it was. It was a dog, that now lay still.\nIt must've been caught under the rubble when the museum collapsed.");
                            Console.WriteLine("\"The poor thing. Perhaps we can come back and get it to give it a proper burial once you've escaped.\"\n\"For now, though, you have to keep moving.\"");
                        }
                    }
                    scouring++;
                    return scouring;
                case 2:
                    //East World War Exhibit
                    if (world == 0)
                    {
                        //Rolls for either Nubby the Great Plains Griffin or Neville, the Imperial High Griffin
                        griffinRoll = Config.RollDie(1, 3);

                        if(griffinRoll == 1)
                        {
                            //Great Plains Griffin Attack Scenario
                            NubbyOrNeville = new GreatPlainsGriffin();

                            Console.WriteLine("As " + SetUp.GetPlayerName + " walked towards the eastern exhibit, " + SetUp.GetPlayerPersonal+ " heard a sound of some sort.\n" + SetUp.GetPlayerPersonal + " stopped in " + SetUp.GetPlayerPossess + " tracks and looked around. Eventually, " + SetUp.GetPlayerPossess + " eyes fell upon a small Griffin pecking at the ground.");
                            Console.WriteLine("It was incredibly small, perhaps a baby even. There was something cute about the small griffin and its squeaky chirps.\n" + SetUp.GetPlayerName + " found themselves staring at the griffin lovingly.");
                            Console.WriteLine("\"Don't tell me you find the thing cute, " + SetUp.GetPlayerName + "! It's a wild animal!\"");
                            Console.WriteLine("1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                            touchGriffin = Console.ReadLine();

                            checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);

                            while (checkTouchGriffin == false || touchGriffinNum > 3)
                            {
                                Console.WriteLine("Your input was invalid. Please choose to:\n1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                                touchGriffin = Console.ReadLine();

                                checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);
                            }

                            switch(touchGriffinNum)
                            {
                                case 1:
                                    //Touch griffin
                                    Console.WriteLine("\nIgnoring their guide's warning, " + SetUp.GetPlayerName + " approached the griffin and reached out to pet it.");
                                    NubbyOrNeville.GriffinAttack();
                                    break;
                                case 2:
                                    //Avoid Griffin and immediately move on
                                    Console.WriteLine("\nResisting the tempation, " + SetUp.GetPlayerName + " ignored the griffin and kept on moving towards their destination.");
                                    break;
                                case 3:
                                    //quit game
                                    Config.QuitGame();
                                    break;
                                default:
                                    //quit game
                                    Config.QuitGame();
                                    break;
                            }
                        }
                        else
                        {
                            //Imperial High Griffin Attack Scenario
                            NubbyOrNeville = new ImperialHighGriffin();

                            Console.WriteLine("As " + SetUp.GetPlayerName + " walked towards the eastern exhibit, " + SetUp.GetPlayerSubject + " saw something. It was a griffin of some sort.\nIt wasn't an adult, but neither was it a baby. It was an adolescent griffin of some sort.");
                            Console.WriteLine("There was something majestic about the about the way that it stood, proud and tall.\n" + SetUp.GetPlayerName + " found themselves frozen, their breath taken away by the griffin.");
                            Console.WriteLine("\"Don't tell me you want to get closer, " + SetUp.GetPlayerName + "! It's a wild animal!\"");
                            Console.WriteLine("1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                            touchGriffin = Console.ReadLine();

                            checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);

                            while (checkTouchGriffin == false || touchGriffinNum > 3)
                            {
                                Console.WriteLine("Your input was invalid. Please choose to:\n1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                                touchGriffin = Console.ReadLine();

                                checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);
                            }

                            switch (touchGriffinNum)
                            {
                                case 1:
                                    //Touch griffin
                                    Console.WriteLine("Ignoring their guide's warning, " + SetUp.GetPlayerName + " approached the griffin and reached out to pet it.");
                                    NubbyOrNeville.GriffinAttack();
                                    break;
                                case 2:
                                    //Avoid Griffin and immediately move on
                                    Console.WriteLine("Resisting the tempation, " + SetUp.GetPlayerName + " ignored the griffin and kept on moving towards their destination.");
                                    break;
                                case 3:
                                    //quit game
                                    Config.QuitGame();
                                    break;
                                default:
                                    //quit game
                                    Config.QuitGame();
                                    break;
                            }
                        }

                        Console.WriteLine("The path to the east was clear. The only issue was the giant pillar that had fallen in front of the door.");
                        Console.WriteLine(playername + " approached it to try and get a better look; see what " + SetUp.GetPlayerPersonal + " could do.");
                        Console.WriteLine("After inspecting the pillar for a bit, they decide to:");
                        Console.WriteLine("1. Blow up the slab\n2. Force it aside with magic");
                        approachEastExhibit = Console.ReadLine().Trim();
                        Console.ReadLine();

                        bool east = int.TryParse(approachEastExhibit, out approachEastExhibitNum);

                        //Prompts the player to enter a 1 or 2 assuming their original input was invalid
                        while (east == false || approachEastExhibitNum >= 3)
                        {
                            Console.WriteLine("Your entry was invalid. Please enter a 1 or 2.");
                            Console.WriteLine("1. Blow up the slab\n2. Force it aside with magic");
                            approachEastExhibit = Console.ReadLine().Trim();
                            east = int.TryParse(approachEastExhibit, out approachEastExhibitNum);
                        }

                        if (approachEastExhibitNum == 1)
                        {
                            //Blow it up and succeed
                            //Perhaps include player health and have them injure themselves, reducing that health a bit.
                            Console.WriteLine("Moving back a bit, " + playername + " got ready to blow up the pillar.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " closed " + SetUp.GetPlayerPossess + " eyes and concentrated. " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " heard a loud boom and the clatter of stone against stone.");
                            Console.WriteLine("Opening " + SetUp.GetPlayerPossess + ", " + SetUp.GetPlayerPersonal + " saw that the way was now clear, and walked into the exhibit.");
                        }
                        if (approachEastExhibitNum == 2)
                        {
                            //Try to pull it, get overwhelmed by size, crush yourself
                            Console.WriteLine(playername + " took a deep breath and rubbed " + SetUp.GetPlayerPossess + " hands together. " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " began gesturing with " + SetUp.GetPlayerPossess + " hands at the pillar.");
                            Console.WriteLine("The pillar slowly sidled forwards out of the doorway.");
                            Console.WriteLine("It was incredibly difficult, trying to move something so large. Still, " + playername + " was managing.");
                            Console.WriteLine("The pillar was almost entirely out of the doorway. Excited, " + playername + " forgot about it for just a moment.\nIn that moment, the pillar was once again at the mercy of gravity. It fell towards " + playername + ".");
                            Console.WriteLine("In a matter of seconds, all " + SetUp.GetPlayerPersonal + " saw was the white of the pillar's marble.");
                            Config.GameEnd(playername);
                        }
                    }
                    world++;
                    return world;
                case 3:
                    //Northwest Dracomoprhi Exhibit
                    if (gold == 0)
                    {
                        Console.WriteLine("The Northwestern Exhibit is the furthest away. " + playername + " begins walking towards it.");
                        Console.WriteLine("As " + SetUp.GetPlayerPersonal + " walked towards it, the ground shook violently.\nSeveral pillars that had been shaken loose give way once the trembling stops.");
                        Console.WriteLine("What do you do?\n1. Blow them up so the small fragments don't hurt as badly\n2. Make a break for it");
                        approachNWExhibit = Console.ReadLine().Trim();
                        Console.ReadLine();

                        bool NW = int.TryParse(approachNWExhibit, out approachNWExhibitNum);

                        //Prompts the player to enter a 1 or 2 assuming their original input was invalid
                        while (NW == false || approachNWExhibitNum >= 5)
                        {
                            Console.WriteLine("Your entry was invalid. Please enter a 1 or 2.");
                            Console.WriteLine("What do you do?\n1. Blow them up so the small fragments don't hurt as badly\n2. Make a break for it");
                            approachNWExhibit = Console.ReadLine().Trim();
                            NW = int.TryParse(approachNWExhibit, out approachNWExhibitNum);
                        }

                        if (approachNWExhibitNum == 1)
                        {
                            //Blow up pillars; large chunk hits players in the head
                            Console.WriteLine("As the pillars came falling, " + playername + " blew them apart with all the force " + SetUp.GetPlayerPersonal + " could.");
                            Console.WriteLine("Small chunks of marble fell at " + SetUp.GetPlayerPossess + " feet. Some of the chunks hit " + SetUp.GetPlayerSubject + ", but they were so small it didn't matter.");
                            Console.WriteLine("\"Good work! It looks like you're in the-\"");
                            Console.WriteLine("A large chunk of marble comes flying right at " + playername + ". " + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " thought that any chunks would have\nBeen too small to be dangerous.");
                            Console.WriteLine("As that chunk grew closer, though, " + SetUp.GetPlayerPersonal + " knew " + SetUp.GetPlayerPersonal + " had made a mistake. The chunk hit " + SetUp.GetPlayerSubject + " hard,\nAnd " + SetUp.GetPlayerPersonal + " collapsed onto the ground.");
                            Config.GameEnd(playername);
                        }
                        if (approachNWExhibitNum == 2)
                        {
                            //Runs for it, narrowly makes it
                            Console.WriteLine("As the pillars fell, " + playername + " started sprinting in the direction of the exhibit's door.");
                            Console.WriteLine(SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " could hear the sound of the pillars falling behind " + SetUp.GetPlayerSubject + ", but didn't dare to look back.");
                            Console.WriteLine("When the door was close, " + playername + " took a chance and dove for it.\n" + SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " landed right past the doorway as another pillar crashed outside.");
                            Console.WriteLine(SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " waited a moment before getting up, relieved to have survived that ordeal.");
                        }
                    }
                    gold++;
                    return gold;
                case 4:
                    Config.QuitGame();
                    gold++;
                    return gold;
                default:
                    Config.QuitGame();
                    gold++;
                    return gold;
            }
        }

        //After the player passes the trials in the above exhibits, this method plays out.
        //It uses the same number from the conversion method that the approachExhibit method used.
        //It shows the player what is inside the exhibit that they decided to approach.
        public void FirstFloorExhibits(int ffRoomSelectNum, string playername)
        {
            switch (ffRoomSelectNum)
            {
                case 1:
                    //Scouring Exhibit
                    ScouringExhibit(playername);
                    break;
                case 2:
                    //World War Exhibit
                    WorldWarExhibit(playername);
                    break;
                case 3:
                    //Golden Age Exhibit
                    GoldenAgeExhibit(playername);
                    break;
                default:
                    //exit game Method
                    Config.QuitGame();
                    break;
            }
        }

        //Shows the Scouring exhibit if the player selected it when first prompted
        public void ScouringExhibit(string playername)
        {
            Console.WriteLine("Reluctantly, " + playername + " walked past the dog's corpse and into the room.");
            Console.WriteLine("This exhibit was by far the largest. Looking around of what was left of it, it wasn't very surprising.");
            Console.WriteLine("Like all Scouring exhibits in museums around the world,\nStatues of Einhart the Dragonslayer and Calmanus the Insurgent stared each other down in the center of the room.");
            Console.WriteLine("The Scouring always stood out as the first time an act as heinous as genocide plagued the world.");
            Console.WriteLine("The world at large had once hailed The Dragonslayer as a hero and The Insurgent a villain.\nCenturies later, the public view of them both had done a complete 180.");
            Console.WriteLine("After quickly sweeping the room, it didn't look like there was anywhere in the exhibit that might've led to the exit.");
            Console.WriteLine("With a sigh, " + playername + " turned back.");

        }

        //Shows the World War exhibit if the player selected it when first prompted
        public void WorldWarExhibit(string playername)
        {
            Console.WriteLine(playername + " stepped around the rubble that " + SetUp.GetPlayerPersonal + " had blown apart and walked into the room.");
            Console.WriteLine(SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " saw an immense map of the world on the back wall. Countries were either blue, red, or black.");
            Console.WriteLine("It appeared to be normal for there to be statues in the exhibits.\nThe centerpiece of this exhibit was King William Magis II and his personal bodyguards, the Hexguard.");
            Console.WriteLine("There were a lot of stories written about that group of seven and their exploits during the World War.");
            Console.WriteLine("A lot of people left off the 'Second' that war techincally deserves, since the Great War is in a league of it's own.");
            Console.WriteLine("Briefly walking around, " + playername + " finds diaries, notes, or newspapers from the time.");
            Console.WriteLine("Interesting as " + SetUp.GetPlayerPersonal + " were, " + SetUp.GetPlayerPersonal + " didn't give any insight as to how to get out.\nBefore leaving, " + playername + " contemplated tucking one of the books under their arm.");
            Console.WriteLine("Deciding against it, " + SetUp.GetPlayerPersonal + " left the exhibit to go and find another path to the exit.");
        }

        //Shows the Dracomorphi Golden Age exhibit if the player selected it when first prompted
        public void GoldenAgeExhibit(string playername)
        {
            Console.WriteLine("While the collapse of the museum had largely covered things in dust and made things dull looking,\nThere was a bit of brightness to this exhibit. Some parts had a faint golden shine.");
            Console.WriteLine("The statue in the room was fairly small, and showed a group of Dracomorphi men sitting around and talking.");
            Console.WriteLine("Other paintings or statuettes around the room were mostly of Dracomorphs, and " + playername + " couldn't read most of the text.");
            Console.WriteLine("This exhibit must've been about the Dracomorphi Golden Age.\nAfter the horror of the Scouirng, it was astonishing to see the oppressed people of Melstrain flourish.");
            Console.WriteLine("From what " + playername + " knew, Dracomorphs lived fairly decent lives in their homeland,\nbut no one denied the accomplishments of Dracomorphs during this time all the same.");
            Console.WriteLine("It would have been nice to see more about Dracomorphi achievements, but most of the exhibit was buried under debris.");
            Console.WriteLine("Seeing nothing that could be of use, " + playername + " turned back and walked back into the main area of the first floor.");
        }

        //Asks the player if they would like to continue exploring the first floor or not
        public Boolean ContinueExploringFirst()
        {
            Console.WriteLine("\"Do you want to continue exploring?\"\nY or N");
            keepExploringFirst = Console.ReadLine().Trim().ToUpper();

            //Prompts the player to Y or N assuming their original input was invalid
            while (String.IsNullOrEmpty(keepExploringFirst) || keepExploringFirst != "N" && keepExploringFirst != "Y")
            {
                Console.WriteLine("Your entry was invalid. Please enter a Y or N. Do you want to keep exploring?");
                keepExploringFirst = Console.ReadLine().Trim().ToUpper();
            }

            if (keepExploringFirst == "Y")
            {
                exploreFirstBool = true;
            }
            if (keepExploringFirst == "N")
            {
                exploreFirstBool = false;
            }

            return exploreFirstBool;
        }

        //Method where the player will approach the exit of the museum to get outside
        //The player will encounter whatever Griffin they did not encounter the first time
        public void ApproachMuseumExit()
        {
            //If the player encountered Nubby, the game will create Neville
            if(NubbyOrNeville is GreatPlainsGriffin)
            {
                NubbyOrNeville = new ImperialHighGriffin();


                Console.WriteLine("As " + SetUp.GetPlayerName + " got closer to the exit, " + SetUp.GetPlayerSubject + " saw something. It was another griffin.\nThis one wasn't an adult, but neither was it a baby. It was an adolescent.");
                Console.WriteLine("There was something majestic about the about the way that it stood, proud and tall.\n" + SetUp.GetPlayerName + " found themselves frozen, their breath taken away by the griffin.");
                Console.WriteLine("\"Don't tell me you want to get closer, " + SetUp.GetPlayerName + "! We're so close to the exit!\"");
                Console.WriteLine("1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                touchGriffin = Console.ReadLine();

                checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);

                while (checkTouchGriffin == false || touchGriffinNum > 3)
                {
                    Console.WriteLine("Your input was invalid. Please choose to:\n1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                    touchGriffin = Console.ReadLine();

                    checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);
                }

                switch (touchGriffinNum)
                {
                    case 1:
                        //Touch griffin
                        Console.WriteLine("Ignoring their guide's warning, " + SetUp.GetPlayerName + " approached the griffin and reached out to pet it.");
                        NubbyOrNeville.GriffinAttack();
                        break;
                    case 2:
                        //Avoid Griffin and immediately move on
                        Console.WriteLine("Resisting the tempation, " + SetUp.GetPlayerName + " ignored the griffin and kept on moving towards the exit.");
                        break;
                    case 3:
                        //quit game
                        Config.QuitGame();
                        break;
                    default:
                        //quit game
                        Config.QuitGame();
                        break;
                }
            }

            //If the player encountered Neville, the game will create Nubby
            if (NubbyOrNeville is ImperialHighGriffin)
            {
                NubbyOrNeville = new GreatPlainsGriffin();

                Console.WriteLine("As " + SetUp.GetPlayerName + " walked towards the exit, " + SetUp.GetPlayerPersonal + " heard a sound of some sort.\n" + SetUp.GetPlayerPersonal + " stopped in " + SetUp.GetPlayerPossess + " tracks and looked around. Eventually, " + SetUp.GetPlayerPossess + " eyes fell upon another Griffin. \nThis one was much smaller, and pecking around at the ground.");
                Console.WriteLine("It was incredibly small, perhaps a baby even. There was something cute about it and its squeaky chirps.\n" + SetUp.GetPlayerName + " found themselves staring at the griffin lovingly.");
                Console.WriteLine("\"Don't tell me you find the thing cute, " + SetUp.GetPlayerName + "! The exit is right in front of you!\"");
                Console.WriteLine("1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                touchGriffin = Console.ReadLine();

                checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);

                while (checkTouchGriffin == false || touchGriffinNum > 3)
                {
                    Console.WriteLine("Your input was invalid. Please choose to:\n1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                    touchGriffin = Console.ReadLine();

                    checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);
                }

                switch (touchGriffinNum)
                {
                    case 1:
                        //Touch griffin
                        Console.WriteLine("\nIgnoring their guide's warning, " + SetUp.GetPlayerName + " approached the griffin and reached out to pet it.");
                        NubbyOrNeville.GriffinAttack();
                        break;
                    case 2:
                        //Avoid Griffin and immediately move on
                        Console.WriteLine("\nResisting the tempation, " + SetUp.GetPlayerName + " ignored the griffin and kept on towards the exit.");
                        break;
                    case 3:
                        //quit game
                        Config.QuitGame();
                        break;
                    default:
                        //quit game
                        Config.QuitGame();
                        break;
                }
            }

            //If the player encountered neither, the game will roll to see what the player encounters
            else if (!(NubbyOrNeville is GreatPlainsGriffin) && !(NubbyOrNeville is ImperialHighGriffin))
            {
                //Rolls for either Nubby the Great Plains Griffin or Neville, the Imperial High Griffin
                griffinRoll = Config.RollDie(1, 3);

                if (griffinRoll == 1)
                {
                    //Great Plains Griffin Attack Scenario
                    NubbyOrNeville = new GreatPlainsGriffin();

                    Console.WriteLine("As " + SetUp.GetPlayerName + " walked towards the exit, " + SetUp.GetPlayerPersonal + " heard a sound of some sort.\n" + SetUp.GetPlayerPersonal + " stopped in " + SetUp.GetPlayerPossess + " tracks and looked around. Eventually, " + SetUp.GetPlayerPossess + " eyes fell upon another Griffin. \nThis one was much smaller, and pecking around at the ground.");
                    Console.WriteLine("It was incredibly small, perhaps a baby even. There was something cute about it and its squeaky chirps.\n" + SetUp.GetPlayerName + " found themselves staring at the griffin lovingly.");
                    Console.WriteLine("\"Don't tell me you find the thing cute, " + SetUp.GetPlayerName + "! The exit is right in front of you!\"");
                    Console.WriteLine("1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                    touchGriffin = Console.ReadLine();

                    checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);

                    while (checkTouchGriffin == false || touchGriffinNum > 3)
                    {
                        Console.WriteLine("Your input was invalid. Please choose to:\n1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                        touchGriffin = Console.ReadLine();

                        checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);
                    }

                    switch (touchGriffinNum)
                    {
                        case 1:
                            //Touch griffin
                            Console.WriteLine("\nIgnoring their guide's warning, " + SetUp.GetPlayerName + " approached the griffin and reached out to pet it.");
                            NubbyOrNeville.GriffinAttack();
                            break;
                        case 2:
                            //Avoid Griffin and immediately move on
                            Console.WriteLine("\nResisting the tempation, " + SetUp.GetPlayerName + " ignored the griffin and kept on moving towards their destination.");
                            break;
                        case 3:
                            //quit game
                            Config.QuitGame();
                            break;
                        default:
                            //quit game
                            Config.QuitGame();
                            break;
                    }
                }
                else
                {
                    //Imperial High Griffin Attack Scenario
                    NubbyOrNeville = new ImperialHighGriffin();

                    Console.WriteLine("As " + SetUp.GetPlayerName + " got closer to the exit, " + SetUp.GetPlayerSubject + " saw something. It was another griffin.\nThis one wasn't an adult, but neither was it a baby. It was an adolescent.");
                    Console.WriteLine("There was something majestic about the about the way that it stood, proud and tall.\n" + SetUp.GetPlayerName + " found themselves frozen, their breath taken away by the griffin.");
                    Console.WriteLine("\"Don't tell me you want to get closer, " + SetUp.GetPlayerName + "! We're so close to the exit!\"");
                    Console.WriteLine("1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                    touchGriffin = Console.ReadLine();

                    checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);

                    while (checkTouchGriffin == false || touchGriffinNum > 3)
                    {
                        Console.WriteLine("Your input was invalid. Please choose to:\n1. Touch the Griffin\n2. Avoid the Griffin\nOr\n3. Quit");
                        touchGriffin = Console.ReadLine();

                        checkTouchGriffin = int.TryParse(touchGriffin, out touchGriffinNum);
                    }

                    switch (touchGriffinNum)
                    {
                        case 1:
                            //Touch griffin
                            Console.WriteLine("Ignoring their guide's warning, " + SetUp.GetPlayerName + " approached the griffin and reached out to pet it.");
                            NubbyOrNeville.GriffinAttack();
                            break;
                        case 2:
                            //Avoid Griffin and immediately move on
                            Console.WriteLine("Resisting the tempation, " + SetUp.GetPlayerName + " ignored the griffin and kept on moving towards their destination.");
                            break;
                        case 3:
                            //quit game
                            Config.QuitGame();
                            break;
                        default:
                            //quit game
                            Config.QuitGame();
                            break;
                    }
                }
            }
        }

        //The game's ending method
        public void Endgame()
        {
            Console.WriteLine("After getting past the griffin, " + SetUp.GetPlayerName + " was finally at the exit.");
            Console.WriteLine("The last few hours of " + SetUp.GetPlayerPossess + " life had been a living hell, but it was finally about to come to an end.");
            Console.WriteLine(SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " prayed that whatever awaited " + SetUp.GetPlayerSubject + " on the other side was better than what was inside the museum.");
            Console.WriteLine("\"You've finally made it, " + SetUp.GetPlayerName + ". It's time to step out into the world.\"");
            Console.WriteLine(SetUp.GetPlayerName + " wasn't paying attention to " + SetUp.GetPlayerPossess + " guide. " + SetUp.GetPlayerPersonal +" slowly approached the doors to the museum.");
            Console.WriteLine("They were barely hanging on their hinges. "+ SetUp.GetPlayerName + " put " + SetUp.GetPlayerPossess + " hands on the door and pushed." );
            Console.WriteLine(SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " pushed as hard as " + SetUp.GetPlayerPersonal + " could, trying to force the doors open.");
            Console.WriteLine("It was no easy feat, but in time, the doors finally gave way, and began moving, scraping against the ground.");
            Console.WriteLine("When " + SetUp.GetPlayerName + " had enough space to get through, " + SetUp.GetPlayerPersonal +" stepped through.");

            Console.ReadLine();

            Console.WriteLine("It was morning when " + SetUp.GetPlayerPersonal + " had entered the museum, but now the moon hung high above in the clear night sky.");
            Console.WriteLine("The city had been ravaged. It looked like an earthquake of some sort. Debris everywhere. Buildings toppled. Cars abandoned in the streets.");
            Console.WriteLine("There wasn't another human in sight.");
            Console.WriteLine("\"I hate to say this, but I'll be leaving you. I was just here to guide you out of the museum.\"");
            Console.WriteLine("\"Now that you're here, I'm not longer needed. Be careful, " + SetUp.GetPlayerName + ".\"");
            Console.WriteLine(SetUp.GetPlayerName + " waited, listening for both " + SetUp.GetPlayerPossess + " guide's voice and some sign of life.");

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("Nothing.");

            Console.WriteLine(SetUp.GetPlayerName + " sat down in front of the museum, defeated. They were just a normal civilian.\nWhat would " + SetUp.GetPlayerPersonal + " do now, without anyone at all to help them?");
            Console.WriteLine("Perhaps... try to get out of the city, and go somewhere else.\nBut with the creatures inside the museum, Gods only knew what else would be out there.");
            Console.WriteLine("Would " + SetUp.GetPlayerPersonal + " even survive?");

            Console.ReadLine();

            Console.WriteLine("\"...re!\"");
            Console.WriteLine(SetUp.GetPlayerName + " perked up at the sound, and stood up.");
            Console.WriteLine("\"...ver here!\"");
            Console.WriteLine(SetUp.UppercaseFirst(SetUp.GetPlayerPersonal) + " started shouting in the direction of the voice, hoping to get someone's attention.");
            Console.WriteLine("Eventually, a group of people appeared. None of them were familiar, but they were a sight for sore eyes.");
            Console.WriteLine("\"Another survivor! That's great! Get over here!\"");

            Console.WriteLine(SetUp.GetPlayerName + " did as they were told. " + SetUp.GetPlayerPersonal + " didn't know what awaited " + SetUp.GetPlayerSubject + " in this ruined city of " + SetUp.GetPlayerPossess + ".");
            Console.WriteLine("All " + SetUp.GetPlayerPersonal + " did know that was whatever happened to " + SetUp.GetPlayerSubject + " next,\nWhether or not civilization still existed outside of the city limits,\nWas that " + SetUp.GetPlayerPersonal + " wouldn't have to face it alone.");
            
        }

    }
}
