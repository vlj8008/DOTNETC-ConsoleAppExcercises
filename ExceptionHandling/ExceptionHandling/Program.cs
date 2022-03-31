using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)

        {
            List<int> numList = new List<int>() { 2, 4, 6, 8, 10};  
            bool active = true; //made a variable called "active" to be used in while loop
            while (active == true)
            {

                try
                {
                    
                    foreach (int num in numList)
                    {
                        Console.WriteLine(num); //this displays numbers to user.
                    }

                    Console.WriteLine("Please pick a number that you would like to divide the list by");
                    decimal divider = Convert.ToDecimal(Console.ReadLine());

                    foreach (int num in numList)
                    {

                        decimal ans = num / divider;
                        decimal finalAns = Math.Round(ans,2);
                        
                        Console.WriteLine("The number " + num + " divided by " + divider + " is equal to " + finalAns);//displays divided numbers.
                        active = false; //changes "active" to false to get out of while loop
                         
                    }

                }

                catch (FormatException ex)

                {
                    Console.WriteLine("Please enter a whole number");
                }

                catch (DivideByZeroException ex)

                {
                    Console.WriteLine("Please do not enter zero. Please enter a whole number");
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine();
                }

            }
            Console.WriteLine("Moving on with the program....");
            Console.ReadLine();
        }
        

        
    }
    
}
//More practice with try/catch/finally code

//try
//{


//    Console.WriteLine("Pick a number");
//    int numberOne = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine();
//    Console.WriteLine("Pick a second number");
//    int numberTwo = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Dividing the two numbers now.....");
//    int numberThree = numberOne / numberTwo;
//    Console.WriteLine(numberOne + " divided by " + numberTwo + " is equal to " + numberThree);
//    Console.ReadLine();

//}

//catch (FormatException ex)//  "ex" is data type formatException and is a variable

//{
//    Console.WriteLine("Please type a whole number");

//}

//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Please don't divide by zero");
//}

//catch (Exception ex) //this catches general exceptions.

//{
//    Console.WriteLine(ex.Message);
//}

//finally
//{
//    Console.ReadLine();
//} //this always runs. It is usually connected to a dB. For example if you are running a credit card, and get
//  ////an exception this will be recorded in the dB. 


