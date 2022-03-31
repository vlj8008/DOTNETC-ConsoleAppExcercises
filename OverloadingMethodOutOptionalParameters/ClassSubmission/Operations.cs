using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Operations //created a class called "Operations"
    {

        public void outputInt(int num1) //method that divides user input by 2, and outputs results to screen.
        {
            int ans = num1 / 2;
            Console.WriteLine("Your number divided by 2 equals : " + ans);

        }

        //* Output parameter method one. 

        public  void rectangle(int length, int width, out int area, out int perimeter)
        {
            area = length * width;
            perimeter = 2 * (length + width);


        }

        //* Output parameter method two. (I did an extra one for extra practice).

        public static void MyListMethod(List<int> myList, out int count)
        {
            count = myList.Count;

           

            for (int i = 0; i < myList.Count; i++)
                 {

                        Console.WriteLine(myList[i]);
                 }

            Console.WriteLine("The number of items in the list is " + count);
        }

        //* Overloading a method.

        public int MathOps(int num2)
        {
            int x = 10;
            int result = x + num2;
            return result;
        }

        //* Overloading the method using an output parameter
        public int MathOps(int num2, out int pi)
        {
            pi = 3+6;
            int x = 10;
            int result2 = x - num2;
            return result2;
        }
        //*Overloading the method using an optional parameter. 

        public int MathOps(int num2, int num3=0)
        {
            int x = 10;
            int result3 = x + num2 + num3;
            return result3;


        }

    }

}

