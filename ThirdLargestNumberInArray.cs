using System;
using System.Collections.Generic;

namespace test
{
    class ThirdLargestNumberInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 5, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                sortArray(ref arr, arr.Length-i, 0);
            }
            Console.WriteLine(arr[arr.Length - 3]);
            Console.ReadKey();
        }

        private static void sortArray(ref int[] arr, int noOfSortItems, int i)
        {
            if (noOfSortItems-1 == i)
                return;
            else
            {
                var temp = arr[i];
                if(arr[i]>arr[i+1])
                {
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
                i++;
                sortArray(ref arr, noOfSortItems, i);
            }

        }
    }
}
