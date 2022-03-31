using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub
{
    public abstract class Person //created abstract class using abstract keyword.

    {
        //Abstract Method:
        //can only be in an abstract class. Contains NO implementation.
        //Any class inheriting from Person MUST have this play method. 


        public abstract void SayName();
        
        
        //Properties:
        public string firstName { get; set; }
        public string lastName { get; set; }




    }
}
