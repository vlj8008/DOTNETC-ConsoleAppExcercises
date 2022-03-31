using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            ///Instantiating Employee object using "new" keyword.

            Employee Employee = new Employee();

            //Initializing new Employee object. 

            Employee.FirstName = "Vicky";
            Employee.LastName = "Jones";

            Console.WriteLine(Employee.FirstName);
            Console.WriteLine(Employee.LastName);

            //Calling the Superclass method (from the Person class)

            Employee.SayName();

            Console.ReadLine();

        }







    }
}
