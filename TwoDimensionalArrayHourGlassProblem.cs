using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class TwoDimensionalArrayHourGlassProblem
    {
        public static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>()
            {
               new List<int> { 1, 1, 1, 0, 0, 0 },
               new List<int> { 0, 1, 0, 0, 0, 0 },
               new List<int> { 1, 1, 1, 0, 0, 0 },
               new List<int> { 0, 0, 2, 4, 4, 0 },
               new List<int> { 0, 0, 0, 2, 0, 0 },
               new List<int> { 0, 0, 1, 2, 4, 0 }
            }; 
            int largestCount = int.MinValue;
            if (arr.Count > 0)
            {
                for (int i = 0; i < arr.Count - 2; i++)
                {
                    for (int j = 0; j < arr[i].Count - 2; j++)
                    {
                        int temp = 0;
                        for (int k = i; k < i + 3; k++)
                        {
                            for (int l = j; l < j + 3; l++)
                            {
                                if ((k == i + 1) && (l == j || l == j + 2))
                                    temp += 0;
                                else
                                {
                                    temp += arr[k][l];
                                }
                            }
                        }
                        if (temp > largestCount)
                            largestCount = temp;
                    }
                }
            }
            Console.WriteLine(largestCount);
        }
    }
}
