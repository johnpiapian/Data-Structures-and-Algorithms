using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class BaseConversion
    {
        private void convertBase(int n, int b)
        {
            if (n == 0)
            {
                return;
            }

            convertBase(n / b, b);

            int remainder = n % b;
            if (remainder < 10)
            {
                Console.Write(remainder);
            }
            else
            {
                Console.Write((char)(remainder - 10 + 'A'));
            }

        }

        public void toBinary(int n)
        {
            convertBase(n, 2);
        }

        public void toOctal(int n)
        {
            convertBase(n, 8);
        }

        public void toHexadecimal(int n)
        {
            convertBase(n, 16);
        }

    }
}
