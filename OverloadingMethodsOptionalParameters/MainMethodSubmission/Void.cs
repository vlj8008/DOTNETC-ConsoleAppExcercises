using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Void
    {
        //Void method performs a task but does not return a value.

        public void VoidMethod(int num1, int num2)
        {
            int result = num1 + 100; //math operation on first parameter. 
            Console.WriteLine("The result of adding 100 to the first number is " + result);
            Console.WriteLine("The second number is " + num2);//displaying the second parameter. 
        }


    }
}
