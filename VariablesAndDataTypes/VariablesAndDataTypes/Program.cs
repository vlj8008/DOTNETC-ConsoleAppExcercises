using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Daily Report Form");
            Console.WriteLine("What is your name ?");
            string name = Console.ReadLine(); //used string keyword to store variable called "name"
            Console.WriteLine("Hello " + name);
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string page = Console.ReadLine();
            int pageNum = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            string helpAns = Console.ReadLine(); // had to use string variable otherwise "ReadLine()" wouldn't work
            bool helpAnsBool = Convert.ToBoolean(helpAns); //used casting and changed string to boolean value. 
            //Console.WriteLine(helpAnsBool);
            Console.WriteLine("Were there any positive experiences you would like to share. Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide. Please be specific");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int hrsStudied = Convert.ToByte(hoursStudied); //used byte as hours studied would be less than 255 and using byte takes up less memory. 
            //Although the summary was not in the assignment I wanted to use it to make sure my variables were being stored correctly. 
            Console.WriteLine("Summary: You are on the course {0}, up to page {1}, and did {2} hours of study today.",course,page,hrsStudied);
            Console.WriteLine("Thankyou for your answers. An Instructor will respond to this shortly. Have a great day! ");
            Console.ReadLine(); //this keeps the console app on the page. 

        }
    }
}
