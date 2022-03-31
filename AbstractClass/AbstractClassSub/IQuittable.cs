using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSub
{
    interface IQuittable
    {

        //Method. (NB. an interface has NO implementation).
        //Parameters are the employee object from the Employee class. 

        void Quit(Employee employee); //no need to use public keyword or abstract as these are the defaults.  
        
    }
}
