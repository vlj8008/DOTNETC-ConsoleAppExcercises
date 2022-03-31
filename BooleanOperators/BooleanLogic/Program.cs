using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ////Boolean AND operator (&&)
            
            int packageWidth = 10;
            int packageHeight = 25;

            ////put in brackets the variables I am comparing.
            
            bool tooBig = (packageHeight > 25 && packageWidth > 25);
            Console.WriteLine(tooBig);


            //Boolean OR operator (||)


            ////put in brackets the variables I am comparing.
            
            bool tooBig1 = (packageHeight > 25 || packageWidth > 25);
            Console.WriteLine(tooBig1);


            //Multiple uses of AND operator. 

            string firstName = "Samuel";
            string lastName = "Farias";
            string socialSecurityNumber = "111-111-111";

            bool isAuthorized = (firstName == "Samuel" && lastName == "Farias" && socialSecurityNumber == "111-111-111");
            Console.WriteLine(isAuthorized);


            //Multiple uses of OR operator.

            int bankAccountBalance = 500;
            bool isOnMailingList = false;
            string cityOfBirth = "Perth";

            bool isAuthorized2 = (bankAccountBalance == 600 || isOnMailingList == false || cityOfBirth == "Fremantle");
            Console.WriteLine(isAuthorized);

            Console.ReadLine();
        }
    }
}
