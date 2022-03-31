using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class OptionalParameter
    {
        // Optional parameter means you don't have to have that parameter for the method 
        // to work. If you don't pass in the optional parameter the default value will be used
        // ie num will be 0.

        public int OptIntMethod(int num, int num2 = 0)
        {
            int ans3 = num + num2;
            return ans3;
        }
    }
}
