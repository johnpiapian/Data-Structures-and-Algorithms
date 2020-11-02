using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class GCD
    {
        public int getGCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return getGCD(b, a % b);
        }

        public void displayGCD(int a, int b)
        {
            Console.WriteLine(getGCD(a, b));
        }
    }
}
