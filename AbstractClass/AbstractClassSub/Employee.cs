using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub
{
    public class Employee : Person, IQuittable  // Inheriting the interface IQuittable

    {
        //Properties:
        
        public int ID { get; set; }

        //Implementing the SayName method (inherited from the Person class).

        public override void SayName()
        {

            Console.WriteLine(" Welcome employee: {0}{1}", firstName, lastName);

        }

        public void Quit(Employee employee)// must be same method signature as Interface.
        {

            //Implementing the Quit() method:

            Console.WriteLine("You can quit your job at any time. Answer y or n");
            string answer = Console.ReadLine();

            if (answer == "y")
            {
                Console.WriteLine("Ok, I am sorry to hear this. Please fill out the form below to start the process. ");
            }

            else
            {
                Console.WriteLine("Great ! We are glad you don't want to leave your job !");
            }
        }

        //*Overloading the == operator:

        public static bool operator ==  (Employee employee, Employee employee1) //inside parentheses are operands.
        {
            return employee.ID == employee1.ID; //returns a boolean value to the main program ie True or False, if employee ID 
            //is equal to employee1 ID.
    
        }

        public static bool operator != (Employee employee, Employee employee1)
        {
            return employee.ID != employee1.ID; //returns a boolean value to the main program ie True or False, if employee ID 
            //is NOT equal to employee1 ID.
        }

    }
}
