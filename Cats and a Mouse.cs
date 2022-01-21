using System;
using System.Collections.Generic;

namespace Hackerrank_Solutions
{
    class Bill_Division
    {
        static void Main(string[] args)
        {
            Console.WriteLine(catAndMouse(1,2,3));
            Console.Read();
        }
        static string catAndMouse(int x, int y, int z)
        {
            if (Math.Abs(x - z) == Math.Abs(y - z))
                return "Mouse C";
            if (Math.Abs(x - z) > Math.Abs(y - z))
                return "Cat B";
            else
                return "Cat A";
        }


    }
}
