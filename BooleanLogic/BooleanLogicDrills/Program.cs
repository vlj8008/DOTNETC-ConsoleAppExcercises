using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicDrills
{
    class Program
    {
        static void Main(string[] args)
        {
            ////AND Operator (Returns TRUE if both operands are True.)

            //Console.WriteLine(true && false); //evaluates False
            //Console.WriteLine(true && true);//evaluates True
            //Console.WriteLine(false && false); //evaluates False

            ////OR Operator (Returns True if either or both operands are True.)

            //Console.WriteLine(true || true); //evaluates True
            //Console.WriteLine(true || false);//evaluates True
            //Console.WriteLine(false || false);//evaluates False

            ////EQUALS Operator (Returns True if both operands have same value)

            //Console.WriteLine(true == true);//evaluates True
            //Console.WriteLine(true == false);//evaluates False
            //Console.WriteLine(false == false);//evaluates True

            ////NOT EQUALS Operator (Returns True if operand is not equal to other operand)

            //Console.WriteLine(true != true);//evaluates False
            //Console.WriteLine(true != false);//evaluates True
            //Console.WriteLine(false != false);//evaluates False

            //// XOR Operator (Returns True if one operand is true but not both)

            //Console.WriteLine(true ^ true);//evaluates to False  
            //Console.WriteLine(true ^ false);//evaluates to True
            //Console.WriteLine(false ^ false);//evaluates to False

            //Getting user input for age and casting from String to Integer

            Console.WriteLine("What is your age?");
            String age = Console.ReadLine();
            int intAge = Convert.ToInt32(age);

            //Getting user input, a boolean, for answer to question: Have you ever had a DUI?

            Console.WriteLine("Have you ever had a DUI. True or False ?");
            string ans = Console.ReadLine();
            bool ansDui = Convert.ToBoolean(ans);

            //Getting user input for number or speeding tickets and casting String to Integer

            Console.WriteLine("How many speeding tickets do you have ?");
            string ticket = Console.ReadLine();
            int speedTicket = Convert.ToInt32(ticket);

            //Made a variable called qualsForIns and used the ADD operator to apply the business rules. 
            bool qualsForIns = ((intAge > 15) && (ansDui == false)&& (speedTicket <4));

            Console.WriteLine("Qualified for insurance  " + qualsForIns);







            Console.ReadLine();
        }
    }
}
