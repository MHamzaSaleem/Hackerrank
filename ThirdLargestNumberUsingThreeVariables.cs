using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ThirdLargestNumberUsingThreeVariables
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 2, 3, 5, 1, 10, 300, 56 };
            int a = int.MinValue;
            int b = int.MinValue;
            int c = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > a)
                {
                    c = b;
                    b = a;
                    a = arr[i];
                }
                else if (arr[i] > b)
                {
                    c = b;
                    b = arr[i];
                }
                else if (arr[i] > c)
                    c = arr[i];

            }
            Console.WriteLine("A: {0}, B: {1}, C: {2}", a, b, c);
            Console.Read();
        }
    }
}
