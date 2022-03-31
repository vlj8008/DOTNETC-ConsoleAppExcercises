using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethodsSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to do the math operations on?");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I will now add 100 to your number");

            Calculator obj1 = new Calculator();//creates object of calculator class and names it "obj1"

            int result = obj1.MyAddMethod(num); //now can access class methods.

            Console.WriteLine(result);

            Console.WriteLine("I will now divide your number by 2.");
            int result2 = obj1.MyDivMethod(num);
            Console.WriteLine(result2);


            Console.WriteLine("I will now subtract one from your number");
            int result3 = obj1.MySubtractMethod(num);
            Console.WriteLine(result3);


            Console.ReadLine();


        }
    }
}
