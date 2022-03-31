using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Emp1 = new Employee();
            Emp1.empID = 001;
            Emp1.FName = "Joe";
            Emp1.LName = "Blow";

            Employee Emp2 = new Employee();
            Emp2.empID = 002;
            Emp2.FName = "Vicky";
            Emp2.LName = "Jones";

            Employee Emp3 = new Employee();
            Emp3.empID = 003;
            Emp3.FName = "Wendy";
            Emp3.LName = "Smith";

            Employee Emp4 = new Employee();
            Emp4.empID = 004;
            Emp4.FName = "Joe";
            Emp4.LName = "Brown";

            Employee Emp5 = new Employee();
            Emp5.empID = 005;
            Emp5.FName = "Samuel";
            Emp5.LName = "Farias";

            Employee Emp6 = new Employee();
            Emp6.empID = 006;
            Emp6.FName = "Tristan";
            Emp6.LName = "Farias";

            Employee Emp7 = new Employee();
            Emp7.empID = 007;
            Emp7.FName = "John";
            Emp7.LName = "Jones";

            Employee Emp8 = new Employee();
            Emp8.empID = 008;
            Emp8.FName = "Jill";
            Emp8.LName = "Smithonian";

            Employee Emp9 = new Employee();
            Emp9.empID = 009;
            Emp9.FName = "Jesse";
            Emp9.LName = "Owen";

            Employee Emp10 = new Employee();
            Emp10.empID = 010;
            Emp10.FName = "Tara";
            Emp10.LName = "Brown";

            //Instantiating and initializing the Employee List. 

            List<Employee> EmployeeList = new List<Employee>() { Emp1, Emp2, Emp3, Emp4, Emp5, Emp6, Emp7, Emp8, Emp9, Emp10 };

            //Instantiating a new list called joeList so we can add any Joes to this list 

            List<Employee> joeList = new List<Employee>();


            // Creating the joeList

            foreach(Employee person in EmployeeList)

            {

                if (person.FName == "Joe")
                {
                    joeList.Add(person);
                }
            }

            //Printing the joeList

             foreach(Employee i in joeList)

             {
                Console.WriteLine(i.FName + " " + i.LName);
                
             }

            

            //Using Lambda expression to create the list of Joes

            List<Employee> lambdaJoeList = EmployeeList.Where(j => j.FName == "Joe").ToList();

            //Printing the lambdaJoeList

            foreach (Employee j in lambdaJoeList)
            {
                Console.WriteLine(j.FName + " " + j.LName);
            }

            //Using Lambda expression to create a list of employees with ID number greater than 5

            List<Employee> EmpGreaterFive = EmployeeList.Where(x => x.empID > 5).ToList();

             //Printing employees with ID greater than 5 to console


            Console.WriteLine("The employees with IDs greater than five are: ");

            foreach(Employee item in EmpGreaterFive)
            {
                Console.WriteLine($"{item.FName} {item.LName}");
            }

            Console.ReadLine();


        }

        struct Employee //using Struct data type as it holds different data types. 
        {
            public int empID;
            public string FName;
            public string LName;
        }
    }
}
