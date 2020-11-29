using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            BubbleSort bs = new BubbleSort();
            QuickSort qs = new QuickSort();

            int[] arr = new int[] { 12, 23, 23, 7, 45, 29 };

            print(arr, "Array(unsorted)");
            print(bs.Sort(arr), "BubbleSort");
            print(qs.Sort(arr), "QuickSort");

            Console.ReadKey();
        }

        static void print(int[] arr, string msg)
        {
            Console.Write($"{msg}: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
