using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class Fibonacci
    {
        public int fib(int n)
        {
            if(n == 0)
            {
                return 0;
            }

            if(n == 1)
            {
                return 1;
            }

            return fib(n-1) + fib(n-2);
        }

        public void displayFib(int n)
        {
            Console.WriteLine(fib(n));
        }

        public void fibSeq(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i + " : " + fib(i));
            }
            Console.WriteLine("");
        }
    }
}
