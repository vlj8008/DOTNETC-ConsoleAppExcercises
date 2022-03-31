using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iterating through List:

            List<string> numList = new List<string>() { "one", "two", "one", "three", "four", "five", "four" };
            Console.WriteLine("Please enter the number you would like to search for to see if it is on the list?");
            string name1 = Console.ReadLine();

            foreach (string num in numList)
            {
                if (!numList.Contains(name1))
                {
                    Console.WriteLine(name1 + " is NOT on the list");
                }

                else
                {
                    Console.WriteLine("Your number has been found in the list");
                }

                int x = 0; //creating a variable (x) to be used in our while loop

                //Using while(condition). The condition is while number is not equal (!=) to -1 do the code
                //in the curly brackets. 
                
                while ((x = numList.IndexOf(name1, x)) != -1)

                //IndexOf method takes in two parameters. First is the string we are searching for (user input),
                //second parameter is the start index we want to search from in our list. We set x to 0 so the
                //method will start searching at the first string in our list. 

                {
                    Console.WriteLine("index: " + x);
                    x++;
                }
                break; //breaks from loop when gets to end of list. 
            }

            Console.WriteLine("Moving on with the program");

            List<string> colors = new List<string>() { "black", "purple", "black", "green", "purple", "yellow", "blue"};
            List<string> colorsList2 = new List<string>();
            Console.WriteLine("Please enter the color you would like to add to the list?");
            string userColor = Console.ReadLine();


            foreach (string color in colors) //for each of the colors in the list above do the following:
            {

               if (colors.Contains(userColor))
                {
                    Console.WriteLine(" Your color " + userColor + " is already on the list");
                    Console.WriteLine("Would you still like to add it to the list Answer y or n");
                    string ans = Console.ReadLine();

                    if(ans == "n")
                    {
                        Console.WriteLine("I will not add it to the list");
                        Console.ReadLine();
                        break;
                    }

                    if (ans == "y")
                    {

                        colorsList2.Add(userColor);
                        foreach (var item in colorsList2)
                        {
                            Console.WriteLine(item);
                        }
                        
                        
                        break;
                      
                    }
                }

            }

            Console.WriteLine("Moving on with the program...");

            Console.ReadLine();
        }
    }
}
    
