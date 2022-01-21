using System;
using System.Collections.Generic;

namespace Hackerrank_Solutions
{
    class Bill_Division
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getMoneySpent(new int[] { 3, 1 }, new int[] { 5, 2, 8}, 10));
            Console.Read();
        }
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            int temp = -1;
            for (int i = 0; i < keyboards.Length; i++)
            {
                for (int j = 0; j < drives.Length; j++)
                {
                    if (b >= (keyboards[i] + drives[j]) && temp < (keyboards[i] + drives[j]))
                        temp = keyboards[i] + drives[j];
                }
            }
            return temp;
        }

    }
}
