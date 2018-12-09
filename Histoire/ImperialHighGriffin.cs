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
    public class ImperialHighGriffin:Griffin
    {
        //The strength of the Imperial High Griffin
        const int SKILL_LEVEL = 4;

        //Uses the constructor of the parent class to create an object of the Great Plains Griffin using its Skill Level
        public ImperialHighGriffin() : base(SKILL_LEVEL)
        {

        }

        public override void GriffinAttack()
        {
            //Statement about the creature attacking the player
            Console.WriteLine("The menacing beast eyed " + SetUp.GetPlayerName + " carefully. They were watching it carefully, trying to see what it was going to do.\nThen, the creature lunged, it's sharp beak rushing right at " + SetUp.GetPlayerPossess + " chest.");

            //Call Parent isAttackSuccessful
            IsAttackSuccessful(GetAttackSkill);

            //if statement depending on the result
            //Within the if, the attack misses or hits
            if (GetAccurateAttackCheck == true)
            {
                //Attack hits and player dies
                Console.WriteLine(SetUp.GetPlayerPersonal + " tried to get our of the way, but was too late. " + SetUp.GetPlayerName + " was knocked to the ground, a sharp pain in their chest.\nMore pain shot through them as the griffin dug its talons into them to free its beak.");
                Console.WriteLine(SetUp.GetPlayerPossess + " eyesight began to blur and the room around them darkening.");
                Config.GameEnd(SetUp.GetPlayerName);
            }
            if (GetAccurateAttackCheck == false)
            {
                //Attack misses
                Console.WriteLine(SetUp.GetPlayerPersonal + " just barely sidestepped it. " + SetUp.GetPlayerPersonal + " sent as high a voltage as they could muster through the griffin.\n" + SetUp.GetPlayerPersonal + " magic was never very strong, but it was enough to incapacitate the griffin.\nAs it was immobile, " + SetUp.GetPlayerPersonal + " turned and dash away from the griffin.");
            }
            Console.ReadLine();
        }

    }
}
