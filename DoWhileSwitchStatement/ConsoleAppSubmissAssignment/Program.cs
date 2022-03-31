using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

        //Boolean comparison using DO WHILE statement.      


            Console.WriteLine("What is the correct thing to do if someone is choking?");
            Console.WriteLine("1 hit them on the head");
            Console.WriteLine("2. pat them hard on the back");
            Console.WriteLine("3. Give them CPR");

            int number = Convert.ToInt32(Console.ReadLine());
            int chances1 = 3; //This variable keeps track of the chances that the person has had to answer correctly
            bool correct = false; //setting value to false so we can continually loop through the switch statement. 

            do
            {
                

                switch (number)
                {
                    case 1:
                        chances1--; //decrementing variable by 1. 
                        Console.WriteLine("Incorrect ! Try again");
                        Console.WriteLine("You have " + chances1 + " remaining chances.");
                        Console.WriteLine("What is the correct thing to do if someone is choking?");
                        Console.WriteLine("1.Hit them on the head?");
                        Console.WriteLine("2. pat them hard on the back");
                        Console.WriteLine("3. Give them CPR");
                        
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        chances1--;
                        
                        Console.WriteLine("This is incorrect! Try again");
                        Console.WriteLine("You have " + chances1 + " remaining.");
                        Console.WriteLine("What is the correct thing to do if someone is choking?");
                        Console.WriteLine("1.Hit them on the head?");
                        Console.WriteLine("2. pat them hard on the back");
                        Console.WriteLine("3. Give them CPR");
                        
                        number = Convert.ToInt32(Console.ReadLine());
                        break;


                    case 2:
                        Console.WriteLine("You are correct ! Well done");
                        correct = true;
                        break;

                    default:

                        
                        Console.WriteLine("You have entered an invalid number. Please enter from 1 - 3");
                        Console.WriteLine("What is the correct thing to do if someone is choking?");
                        Console.WriteLine("1.Hit them on the head?");
                        Console.WriteLine("2. pat them hard on the back");
                        Console.WriteLine("3. Give them CPR");
                        number = Convert.ToInt32(Console.ReadLine());
                        
                        break; 

                }

            } while (!correct );

            
            Console.ReadLine();

        }
    }
}
                 
            

               





                //BRANCHING USING SWITCH STATEMENTS:

                //Used for checking wide variety of inputs and handling each one differently. More concise than if/else statements.
                //int day = 3;
                //switch(day) //inside parenthesis is what we want to check.

                //{
                //    case 1:
                //        Console.WriteLine("Monday");
                //        break; // breaks out of code block
                //    case 2:
                //        Console.WriteLine("Tuesday");
                //        break;
                //    case 3:
                //        Console.WriteLine("Wednesday");
                //        break;
                //    case 4:
                //        Console.WriteLine("Thursday");
                //        break;
                //    case 5:
                //        Console.WriteLine("Friday");
                //        break;
                //    case 6:
                //        Console.WriteLine("Saturday");
                //        break;
                //    case 7:
                //        Console.WriteLine("Sunday");
                //        break;

                //    case 8:
                //        Console.WriteLine("Please enter 1 to 7");
                //        break;

            
            
        
    

