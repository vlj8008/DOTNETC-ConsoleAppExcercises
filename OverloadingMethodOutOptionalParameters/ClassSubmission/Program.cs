using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations obj1 = new Operations();//instantiating the Operations class. 

            Console.WriteLine("Enter a number that you would like divided by two");
            int num1 = Convert.ToInt32(Console.ReadLine()); //capturing user input as "num1"
            obj1.outputInt(num1); //calling the outputInt method and passing in the user input. 



            //*Calling method with "output" parameters. 


            var myList = new List<int>() { 2, 4, 6, 8, 10 };

            Operations.MyListMethod(myList,out int count);
            

            //*Calling another method with "output" parameters.

            int length = 10;
            int width = 20;
            int area = 0; //can be made the value of 0 or be unintialized. 
            int perimeter;

            obj1.rectangle(length: 10, width: 20, out area, out perimeter);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);

            //* Overloading a method:

            Console.WriteLine("Please enter a number that you would like to do an addition operation on ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = obj1.MathOps(num2);
            Console.WriteLine("Ten added to your number is " + result);

            //*Overloading the method using and out parameter

            int result2 = obj1.MathOps(num2, out int pi);

            Console.WriteLine("Pi is " + pi);
            Console.WriteLine("10 minus your number equals " + result2);

            
            //*Overloading a method using and optional parameter
            Console.WriteLine("Would you like to add another number to do the addition operation on ? y or n ?");
            string input = Console.ReadLine();


            if (input == "y")
            {
                Console.WriteLine("Ok, what is your second number?");
                int num3 = Convert.ToInt32(Console.ReadLine());
                int result3 = obj1.MathOps(num2, num3);
                Console.WriteLine("10 added to your 2 numbers equals " + result3);
            }

            else
            {
                Console.WriteLine("OK, bye.");
               
            }

            //* Using the static class (don't need to instantiate it).

            int num5 = 10;
            
            StaticClass.myAddMethod( num5);
            //Console.WriteLine(output);



            Console.ReadLine();


        }    
    }
}
