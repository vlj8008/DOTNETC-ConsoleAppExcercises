using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            //Instantiating a new Employee object.

            Employee employee = new Employee();

            //Initializing Employee object.

            employee.firstName = "Sample";
            employee.lastName = "Student";

            // Calling SayName method.

            employee.SayName();
           
            //Instantiating another Employee object.

            Employee employee1 = new Employee();
            
            //Initializing employee1.

            employee1.firstName = "Jo";
            employee1.lastName = "Blow";


            employee1.Quit(employee);

            //Using Polymorphism and making employee 2 of type IQuittable.

            IQuittable employee2 = new Employee();

            //employee 2 has access to quit method of interface IQuittable (but nothing else ie name, ID etc). 

            employee2.Quit(employee);

            // Overloading "==" operator.
            // 
            // Assigning ID value to employee object and employee1 object

            employee.ID = 001;
            employee1.ID = 001;

            Console.WriteLine("Before we go on. I am now going to ensure your Employee ID has been assigned correctly");

            bool answer = employee.ID == employee1.ID; //using the overloaded operator to evaluate if employee ID
            //is same as employee1 ID and assigning boolean to variable "answer".
                                                     

            if (answer == true)
            {
                Console.WriteLine("Woops... there has been a mistake with assigning the ID");
            }

            else
            {
                Console.WriteLine("Your ID has been assigned correctly .");
            }


            Console.ReadLine();

        }
    }
}
