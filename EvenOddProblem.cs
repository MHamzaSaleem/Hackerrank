using System;
using System.Collections.Generic;

namespace test
{
    class EvenOddProblem
    {
        static void Main(string[] args)
        {
            //if product of array is even then return sum of array else return 0
            int[] arr = { 1, 2, 3, 4 };
            int temp = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (i == 0)
                    temp = arr[i];
                else
                    temp *= arr[i];
            }
            if (temp % 2 == 0)
                Console.WriteLine(sum);
            else
                Console.WriteLine(0);
            Console.ReadKey();

        }
    }
}
