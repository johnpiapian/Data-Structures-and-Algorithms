using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class Selection
    {
        public Selection()
        {
            int[] arr = new int[] { 12, 23, 23, 7, 45, 29 };

            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0, minVal = arr[i];

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < minVal)
                    {
                        temp = minVal;
                        minVal = arr[j];
                        arr[j] = temp;
                    }
                }

                arr[i] = minVal;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
