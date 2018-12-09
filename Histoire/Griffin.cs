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
    public abstract class Griffin
    {
        static int attackSkill = 0;

        //int to save the results of the attackCheck dice roll
        int accurateAttack;
        public static int GetAttackSkill
        {
            get
            {
                return attackSkill;
            }
        }

        Random attackCheck = new Random();

        //Boolean that checks if the Griffin attack connected or not
        static bool checkAccurateAttack;
        public bool GetAccurateAttackCheck
        {
            get
            {
                return checkAccurateAttack;
            }
        }

        //Abstract method for the Griffin's Attack Method
        public abstract void GriffinAttack();

        //Determines if the attack of the griffin hits or misses
        protected Boolean IsAttackSuccessful(int attackSkill)
        {
            accurateAttack = attackCheck.Next(1, 7);


            if (attackSkill >= accurateAttack)
            {
                //Attack is successful

                checkAccurateAttack = true;
                return checkAccurateAttack;
            }
            if (attackSkill < accurateAttack)
            {
                //Attack is not successful
                checkAccurateAttack = false;
                return checkAccurateAttack;
            }
            else
            {
                checkAccurateAttack = false;
                return checkAccurateAttack;
            }

        }

        //Constructor that requires a level of skill for a Griffin to be created
        public Griffin (int inputAttackskill)
        {
            attackSkill = inputAttackskill;
        }
    }
}
