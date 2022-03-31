using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethodsSub
{
    public class Calculator
    {
        public int MyAddMethod(int num) //passing in num variable from Main program which is the 
            //user input. 

        {
            int x = 100;
            return num + x; //returning this value to the part of the program that called it. 
        }

        public int MyDivMethod(int num)
        {
            int result = num / 2;
            return result;
        }

        public int MySubtractMethod( int num)
        {
            int x = 1;
            return num - x;

        }

       


    }
}

