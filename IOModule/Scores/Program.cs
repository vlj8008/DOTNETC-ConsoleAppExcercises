using System; // giving access to System library, which contains useful classes and functions like
// Console class and writeline function.
using System.IO;


namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");

            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}."; // $ is used for string interpolation. 
            
            Console.WriteLine(msg);

           

            string path = @"C:\Users\vicky\OneDrive\Documents\GitHub\Basic_C#_Programs\Scores\Scores\studentScores.txt";

            string [] lines = File.ReadAllLines(path); // square brackets make an array with variable name "lines".

            double totScore = 0; // double data type used to work with decimals (up to 15 decimal digits). 

            Console.WriteLine("\nStudent Scores: \n");
           
            foreach(string line in lines)
            {
                Console.Write("\n"+ line);
                double score = Convert.ToDouble(line);
                totScore += score;

            }

            double average = totScore / lines.Length;
            Console.WriteLine($"\nThe average score is {average} ");

            Console.WriteLine("\nPress any key to continue");


            Console.ReadKey();

            
            
        }
    }
}
