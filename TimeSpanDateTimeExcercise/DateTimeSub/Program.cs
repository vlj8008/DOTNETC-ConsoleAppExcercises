using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSub
{
    class Program
    {
        static void Main(string[] args)
        {

            //Print current date to console:

            Console.WriteLine("The date right now is " + DateTime.Now);

            //Create datetime objects:

            DateTime timeOfBirth = new DateTime(2000, 3, 25);

            DateTime timeOfGraduation = new DateTime(2016, 5, 29);

            //Use TimeSpan class to get difference between two datetime objects:

            TimeSpan ageAtGraduation = timeOfGraduation - timeOfBirth; //TimeSpan class returns days.

            //Print to console the exact time (in days) from Birthday to graduation.

            Console.WriteLine("There were " + ageAtGraduation.Days + " days between when you were born and when you graduated");

            Console.ReadLine();
        }

        

        

        
    }
}

