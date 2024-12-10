using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTask
{
    internal class SavingsAccount :Account
    {





        public  override double CalculateInterest ()
        {
            if (years <= 3)
            {
                intrest = balance * 0.3 * years;

            }
            else {
                intrest = balance * 0.4 * years;

            }

            return intrest;

        }
    }
}
