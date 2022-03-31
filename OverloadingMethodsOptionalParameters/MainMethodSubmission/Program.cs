using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling overloaded methods. 

            Console.WriteLine("Please enter a number you would like to do an addition operation on ");
            int x = Convert.ToInt32(Console.ReadLine());

            MathOperations obj1 = new MathOperations(); //instantiating a new object from the MathOperations class.

            int result = obj1.AddMethod(x); //calling the AddMethod method.
            Console.WriteLine("Your number plus 100 equals: {0}" ,result);

            Console.WriteLine("Please now enter a decimal that you would like to subtract 20 from");
            decimal y = Convert.ToDecimal(Console.ReadLine()); //converting string to decimal so can pass in to AddMethod method below. 

            MathOperations obj2 = new MathOperations();//instantiating the new method with the different data type. 
            decimal result2 = obj2.AddMethod(y);
            Console.WriteLine("Your number minus 20 equals: {0}", result2);

            Console.WriteLine("Please type in another whole number");
            string z = Console.ReadLine();

            MathOperations obj3 = new MathOperations();
            int result3 = obj3.AddMethod(z);
            Console.WriteLine("Your number times 2 equals {0}", result3);

            //Using optional parameter

            OptionalParameter obj4 = new OptionalParameter(); //instantiating OptionalParameter class

            Console.WriteLine("Please enter your first number. ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to enter a second number ? Enter y or n");
            string ans = Console.ReadLine();

            if (ans == "y")
            {
                Console.WriteLine("OK, please enter your second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("I will now do the calculation.....");
                int result4 = obj4.OptIntMethod(num, num2);
                Console.WriteLine("The answer is " + result4);
            }

            else
            {
                Console.WriteLine("OK, I will now do the calculation.....");
                int result4 = obj4.OptIntMethod(num);
                Console.WriteLine("The answer is "+ result4);
            
            }

            // Using Void method. 

            Void obj10 = new Void();//instantiating a new object (obj1) of Void Class

            obj10.VoidMethod(num1:10, num2:1);//Calling the method and specifying 
            //the parameters by name. 

            obj10.VoidMethod(12, 3); //Calling the method by just passing in two numbers.  

            Console.ReadLine();


        }
    }
}
