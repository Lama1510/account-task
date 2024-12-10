using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTask
{
    internal class FixedDepositAccount : Account
    {


        public override double CalculateInterest()
        {

            if (years <= 2)
            {
                intrest = balance * 0.6 * years;

            }
            else if (years >= 3) 
            {
                intrest = balance * 0.08 * years + (500 + years);
            }

            return intrest;

        }
    }
}
