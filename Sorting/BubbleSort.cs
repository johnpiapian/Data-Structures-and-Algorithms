using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class BubbleSort
    {

        public int[] Sort(int[] arr)
        {
            int temp;

            for (int x = arr.Length - 2; x >= 0; x--)
            {
                for (int j = 0; j <= x; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
