using System;
using System.Collections.Generic;

namespace Hackerrank_Solutions
{
    class Bill_Division
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pageCount(8,3));
            Console.Read();
        }
        public static int pageCount(int n, int p)
        {
            int res = 0;
            if ((n / 2) < p)
            {
                for (int i = n; i > n / 2; i--)
                {
                    res += (i % 2 != 0 && i!=n) ? 1 : 0;
                    if (p == i)
                        break;
                }
            }
            else
            {
                for (int i = 0; i <= n / 2; i++)
                {
                    res += (i % 2 == 0 && i!=0) ? 1 : 0;
                    if (p == i)
                        break;
                }
            }
            return res;
        }

    }
}
