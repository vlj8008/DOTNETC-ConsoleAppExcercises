using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console App Assigment (Step 185 C Sharp Course):

            //Console.WriteLine("Please enter any number");
            //string num1 = Console.ReadLine();
            //double number1 = Convert.ToDouble(num1); //casting from string to double. 
            //double answer1 = number1 * 50.0;
            //Console.WriteLine("Your number times 50 equals " + answer1);


            //Console.WriteLine("Please enter any number");
            //string num2 = Console.ReadLine();
            //double number2 = Convert.ToDouble(num2); //casting from string to double. 
            //double answer2 = number2 + 25.0;
            //Console.WriteLine("Your number plus 25 equals " + answer2);


            //Console.WriteLine("Please enter any number");
            //string num3 = Console.ReadLine();
            //double number3 = Convert.ToDouble(num3); //casting from string to double. 
            //double answer3 = number3 / 12.5;
            //Console.WriteLine("Your number divided by 12.5 equals " + answer3);


            //Console.WriteLine("Please enter any number");
            //string num4 = Console.ReadLine();
            //double number4 = Convert.ToDouble(num4); //casting from string to double. 
            //bool trueOrFalse = number4 > 50; //using comparison operator
            //Console.WriteLine("Your number greater than 50 ?" + trueOrFalse);


            //Console.WriteLine("Please enter any number");
            //string num5 = Console.ReadLine();
            //double number5 = Convert.ToDouble(num5); //casting from string to double. 
            //double answer5 = number5 % 7;//using the modulus operator to return the remainder.
            //Console.WriteLine("The remainder of your number divided by 7 is " + answer5);
            //Console.ReadLine();

            //Gathering data from User 1 and casting to correct data type. 

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: what is your hourly rate ?");
            string per1rate = Console.ReadLine();
            decimal pers1HrRate = Convert.ToDecimal(per1rate);

            
            Console.WriteLine("How many hours do you work per week?");
            string pers1hrs = Console.ReadLine();
            byte pers1Hours = Convert.ToByte(pers1hrs);


            //Gathering data from User 2 and casting to correct data type.
            
            Console.WriteLine("Person 2: what is your hourly rate ?");
            string per2rate = Console.ReadLine();
            decimal pers2HrRate = Convert.ToDecimal(per2rate);

            Console.WriteLine("How many hours do you work per week?");
            string pers2hrs = Console.ReadLine();
            byte pers2Hours = Convert.ToByte(pers2hrs);

            //Calculating annual salary

            decimal annSalPer1 = pers1HrRate * pers1Hours * 52;
            decimal annSalPer2 = pers2HrRate * pers2Hours * 52;

            //Printing annual salary of both users to the console.
            
            Console.WriteLine("Annual Salary of person 1 is " + annSalPer1);
            Console.WriteLine("Annual Salary of person 2 is " + annSalPer2);

            //Creating a boolean variable using comparison operator.
            
            bool trueOrFalse = annSalPer1 >= annSalPer2;

            //Casting the boolean data type to a string

            string moreIncome = Convert.ToString(trueOrFalse);

            //Concatenating strings and printing to console

            Console.WriteLine("Person 1 makes the same or more money than person 2 is " + moreIncome);

            Console.ReadLine();



        }
    }
}
