using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class Factorial
    {

        public long fac(int n)
        {
            if( n == 0)
            {
                return 1;
            }
            else
            {
                return n * fac(n - 1);
            }
        }

        public void facSeq(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0! : 1");
                return;
            }
            facSeq(n - 1);
            Console.WriteLine(n + "! : " + fac(n));
        }

        public void facSeqR(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0! : 1");
                return;
            }
            Console.WriteLine(n + "! : " + fac(n));
            facSeqR(n - 1);
        }

        /*
        public void facSeq(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                string result = String.Format("{0}! : {1}", i, fac(i));
                Console.WriteLine(result);
            }
        }
        */


    }
}
