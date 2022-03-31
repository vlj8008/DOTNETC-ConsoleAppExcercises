using System;
using System.Collections.Generic;
using System.Linq;//provides classes and Interfaces that support queries that use LINQ
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestingConsoleApp
{
    class Program
    {
        static void Main()


        {

            //Practise using Linq:

            string[] students = new string[] { "Bob", "Kerry", "Jason", "Ben", "Emma", "Bill", "Paul" };//instantiating the array.

            //Define the query expression
            //IEnumerable is an Interface central to LINQ. It guarantees that the class is iterable. 
            //The query is stored in a variable and the results will be returned to that variable. 

            IEnumerable<string> studentQuery =
                from student in students
                where students.Length >= 6
                select student;

            //Execute the query

            foreach (string s in studentQuery)
            {
                Console.WriteLine(s + " ");
            }

            //Optional Parameter Practise:

            string companyName = "Walmart Inc";

            var openingHours = "9am to 5pm";

            Console.WriteLine("Welcome to {0}  . We are currently open {1}", companyName, openingHours);

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Note, this is optional, please enter your middle name");
            string midNameOptional = Console.ReadLine();


            if (midNameOptional == "")
            {
                Customer newCustomer1 = new Customer(firstName, lastName);
            }

            else
            {
                Customer newCustomer1 = new Customer(firstName, midNameOptional, lastName);
            }


            Console.WriteLine("Welcome ! Customer First Name: {0} \nCustomer Last Name:{1}\nCustomer Middle Name: {2}",
            firstName, lastName, midNameOptional);

            Console.ReadLine();

        }
    }
}

   
    







    





    




         

        

            

   























