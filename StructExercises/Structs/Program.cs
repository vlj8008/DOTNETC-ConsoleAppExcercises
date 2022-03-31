using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Struct Exercise
            

            //*Instantiating the Number struct and giving it variable obj1.
            
            Number obj1 = new Number();

            //Assigning values to the new object.

            obj1.Amount = 1.5m;
            obj1.FName = "Vicky";
            obj1.LName = "Jones";

            Console.WriteLine($"Your name is {obj1.FName} {obj1.LName}, and your amount is {obj1.Amount}");

            //Instantiating instance of struct below

            Employee emp1;

            emp1.empID = 1000;
            emp1.firstName = "Joe";
            emp1.lastName = "Blow";
            emp1.ssn = "555 222 3521";

            Console.WriteLine($"Your name is {emp1.firstName} {emp1.lastName}, and your ssn is {emp1.ssn}");
            Console.ReadLine();
        }

           
            struct Employee
             {
            public int empID;
            public string firstName;
            public string lastName;
            public string ssn;

             }

        
    }
}
