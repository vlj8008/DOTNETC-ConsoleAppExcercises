using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight?");
            string weight = Console.ReadLine(); //user input is a string.
            float fltweight = float.Parse(weight); //use Parse method to convert String to a Float 
            //(which seems like a good data type for holding a weight which may not always be a whole number.

            //Using a ternary operator to keep code concise.  
            string weightResult = fltweight > 50 ? "ERROR MESSAGE: Package too heavy to be shipped via Package Express. Have a good day" : "Please enter package width?";
            Console.WriteLine(weightResult);

            string width = Console.ReadLine();
            float fltwidth = float.Parse(width);
            

            Console.WriteLine("Please enter package height?");
            string height = Console.ReadLine();
            float fltheight = float.Parse(height);
            

            Console.WriteLine("Please enter package length?");
            string length = Console.ReadLine();
            float fltlength = float.Parse(length);

            //Making a variable which equals the total of width, height, length.
            float dimTot = fltwidth + fltheight + fltlength;

            if (dimTot > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express");
            }

            else
            {

                //Calculation of the quote amount.
                float quote = (fltwidth * fltheight * fltlength) * fltweight / 100;
                //Rounding (to two decimal points) the quote amount.
                float finalQuote = (float)Math.Round(quote, 2);

                //Printing quote amount to console. 
                Console.WriteLine("The quote to ship your package is : $" + finalQuote);

                
            }

            Console.ReadLine();




            //PRACTICE CODE:

            ////*IF/ElSE statements:

            //if (true) //The boolean value True will always evaluate True so the code in curly brackets WILL run. 
            //{
            //    Console.WriteLine("Hello!");

            //}
            //if (1==1)
            //{
            //    Console.WriteLine("1 equals 1!");
            //}
            //else //Below code never gets run as 1 is equal to 1. 
            //{
            //    Console.WriteLine("1 does not equal 1");

            //}

            //string name = "Erik";
            //if (name == "Jesse") //above name must match exactly with this line including capitalization. 
            //{
            //    Console.WriteLine("Your name is Jesse");
            //}
            //else if (name == "Brett")
            //{
            //    Console.WriteLine("Your name is not Jesse");
            //}
            //else if(name == "Adam")
            //{
            //    Console.WriteLine("Your name is Adam.");
            //}

            //int age = 19;

            //if (age < 20)
            //{
            //    Console.WriteLine("You are less than 20.");
            //}
            //else if (age > 20)
            //{
            //    Console.WriteLine("You are older than 20");
            //}
            //else
            //{
            //    Console.WriteLine("You are 20");
            //}

            ////* OPERATOR !=


            //if (1 !=2)
            //{
            //    Console.WriteLine("All is ok in the universe");
            //}
            //else
            //{
            //    Console.WriteLine("We live in a wierd world!");
            //}

            //int temp = 31;

            //if (temp != 30)
            //{
            //    Console.WriteLine("Please adjust the thermometer up or down");
            //}

            ////*GREATER THAN OPERATOR

            //int age2 = 20;

            //if (age2 > 21)
            //{
            //    Console.WriteLine("That will be $23.00.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not of legal age to buy alcohol");
            //}

            ////*LESSER THAN OR EQUAL TO OPERATOR

            //int weight = 22;

            //if(weight <= 23)
            //{
            //    Console.WriteLine("We can post your parcel.");
            //}
            //else
            //{
            //    Console.WriteLine("This parcel is too heavy to be posted");
            //}

            ////*AND OPERATOR

            //int num1 = 7;
            //if (true && true && true && true && num1==7)
            //{
            //    Console.WriteLine("Everything was true!");
            //}
            //else
            //{
            //    Console.WriteLine("There was a false somewhere");
            //}

            ////*OR OPERATOR

            //int num2 = 7;

            //if(num2<7 || num2 == 12)
            //{
            //    Console.WriteLine("At least one value is true");
            //}
            //if (num2==12||num2==18)
            //{
            //    Console.WriteLine("At least one value is true");
            //}
            //else
            //{
            //    Console.WriteLine("No values are true");
            //}

            //*TERNARY OPERATOR

            //int num10 = 2;
            //int num11 = 4;

            //string result = num10 > num11 ? "num10 is greater than num11" : "num11 is greater than num10";
            //Console.WriteLine(result);

            //*MORE BRANCHING PRACTICE

            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if(currentTemperature==roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature>roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemp>currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhh....something went wrong !");
            //}

            //*USING TERNARY OPERATOR

            //string comparisonResult = currentTemp > roomTemp ? "Current temperature is greater than room temperature" : "Current temperature is not greater than room temp";
            //Console.WriteLine(comparisonResult);

            //if(currentTemp==roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature. ");
            //}
            //else if (currentTemp>roomTemp)
            //{
            //    Console.WriteLine("The current temperature is warmer than room temperature. ");
            //}
            //else if (roomTemp>currentTemp)
            //{
            //    Console.WriteLine("Room temperature is warmer than the current temperature");
            //}

            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature. ");
            //}

            //Console.WriteLine("What is your favourite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "Your favourite number is 12 !" : "You do not have an awesome favourite number";
            //Console.WriteLine(result);

            //Console.ReadLine();
        }
    }
}
