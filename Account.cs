using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTask
{
    internal  abstract class Account
    {
        public double balance { get; set; }
        public int years { get; set; }

        public double intrest { get; set; }

        public abstract double CalculateInterest ();

        public void PrintIntrest ()
        {
            Console.WriteLine($" the intrest is  : {CalculateInterest()} ");

        }



    }
}
