using System;

namespace Recursion
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            BaseConversion baseConversion = new BaseConversion();
            GCD gcd = new GCD();
            Fibonacci fibonacci = new Fibonacci();
            TowerofHanoi towerofHanoi = new TowerofHanoi();

            int operationCode = -1;

            do
            {
                Console.Clear();
                operationCode = DisplayMenu();
                Console.Clear();

                switch (operationCode)
                {
                    case 1: // factorial
                        if(getNumber("1)Single 2)Sequence: ") == 1)
                        {
                            int n = getNumber("\nEnter nth factorial: ");
                            string result = String.Format("Factorial of nth term {0} is {1}.", n, factorial.fac(n));
                            output(result);
                        }
                        else
                        {
                            int n = getNumber("\nEnter nth factorial: ");
                            factorial.facSeq(n);
                        }

                        continuation();
                        break;
                    case 2: // base conversion
                        int opcode = getNumber("1)Binary 2)Octal 3)Hexadecimal: ");
                        if (opcode == 1)
                        {
                            baseConversion.toBinary(getNumber("Enter a number: "));
                        }else if(opcode == 2)
                        {
                            baseConversion.toOctal(getNumber("Enter a number: "));
                        }
                        else
                        {
                            baseConversion.toHexadecimal(getNumber("Enter a number: "));
                        }

                        continuation();
                        break;
                    case 3: // gcd
                        int gcd_num1 = getNumber("Enter first number: ");
                        int gcd_num2 = getNumber("Enter second number: ");
                        int gcd_ans = gcd.getGCD(gcd_num1, gcd_num2);

                        output(String.Format("\nThe Greatest Common Denominator of {0} and {1} is {2}.\n", gcd_num1, gcd_num2, gcd_ans));

                        continuation();
                        break;
                    case 4: // fib
                        fibonacci.fibSeq(getNumber("Enter number of terms: "));

                        continuation();
                        break;
                    case 5: // hanoi
                        int disk = getNumber("Number of disks: ");
                        char source = getChar("\nEnter a letter for source rod: ");
                        char target = getChar("\nEnter a letter for destination rod: ");
                        char temp = getChar("\nEnter a letter for auxiliary rod: ");

                        output("\n");
                        towerofHanoi.Hanoi(disk, source, target, temp);

                        continuation();
                        break;
                    default:
                        Console.WriteLine("Action unsucessful: Invalid code!");
                        break;
                }

            } while (operationCode != 0);
        }

        static int DisplayMenu()
        {
            Console.WriteLine("Operations:- ");
            Console.WriteLine("1)  Factorial");
            Console.WriteLine("2)  Base Conversion");
            Console.WriteLine("3)  Greatest Common Denominator");
            Console.WriteLine("4)  Fibonacci Sequence");
            Console.WriteLine("5)  Tower of Hanoi");
            Console.WriteLine("0)  Exit");
            Console.WriteLine();

            string s;
            int result;

            do
            {
                Console.Write("Operation code: ");
                s = Console.ReadLine();
            } while (!Int32.TryParse(s, out result));

            return result;
        }

        static int getNumber(string message)
        {
            Console.Write(message);

            int result = 0;
            string c = Console.ReadLine();

            while (!Int32.TryParse(c, out result))
            {
                Console.Write("Check your input: ");
                c = Console.ReadLine();
            }

            return result;
        }

        static char getChar(string message)
        {
            Console.Write(message);

            char c = Console.ReadKey().KeyChar;

            while (!Char.IsLetter(c))
            {
                Console.Write("\nInput must be a char: ");
                c = Console.ReadKey().KeyChar;
            }

            return c;
        }

        static void continuation()
        {
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }

        static void output(string s)
        {
            Console.WriteLine(s);
        }
    }
}
