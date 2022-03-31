using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    class Customer
    {

        public Customer(string firstName, string lastName) : this(firstName, lastName, "NotGiven")
        {

        }
        public Customer(string firstName, string lastName, string midNameOptional)
        {
            FName = firstName;
            LName = lastName;
            MName = midNameOptional;

        } 

        
        public string FName { get; set; }
        public string LName { get; set; }
        public string MName{ get; set; }
    }
}
