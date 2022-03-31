using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class MathOperations //created a class called "Math Operations"
    {
        public int AddMethod(int x) //created a method which takes user input as an integer and returns an integer. 
        {
            int ans1 = x + 100; //performed math operatation on user input.
            return ans1; //returned "ans1" to main program. 
        }

        public decimal AddMethod(decimal y) //created a method with the same name as above method. This is called Method Overloading. Method is 
            //slightly different as it takes in a decimal parameter and returns a decimal after doing a math operation. 
        {
            decimal ans1 = y -20;
            return ans1;
        }

        public int AddMethod(string z)//created a method that takes in user input as a string and returns an integer after doing
             //a math operation 
        {
            int ans1 = Convert.ToInt32(z);//converting the user input of string to an integer and assigning it to variable ans1
            int ans2 = ans1 * 2; //multiplying by 2
            return ans2; //returning the answer to the main program. 

        }

       

    }
}
