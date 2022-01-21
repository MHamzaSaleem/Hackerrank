using System;
using System.Collections.Generic;

namespace Hackerrank_Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 3, 10, 2, 9 };
            bonAppetit(list, 1, 7);
            Console.Read();
        }
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int total = 0;
            int annaTotal = 0;
            for (int i = 0; i < bill.Count; i++)
            {
                total += bill[i];
                annaTotal += (k != i) ? bill[i] : 0;
            }
            if ((annaTotal / 2) == b)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine((total / 2) - (annaTotal/2));
        }
    }
}
