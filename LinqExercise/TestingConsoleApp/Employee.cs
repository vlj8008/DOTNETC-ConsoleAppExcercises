using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApp
{
    class Employee <T> : Person // "T" indicates this class takes generic data type parameter. 
    {
        public override void SayName()
        {
            Console.WriteLine("Welcome employee: {0} {1}", firstName,lastName);
        }

        //Property (data type is generic [not specified here])

        public List<T> Things { get; set; }
        

    }

    
}
