using System;
using System.Collections.Generic;

namespace Hackerrank_Solutions
{
    class CoutingValleys
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "UDDDUDUUDUD"));
            Console.Read();
        }
        public static int countingValleys(int steps, string path)
        {
            int currPosition = 0;
            int valley = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (currPosition == 0 && path[i] == 'D')
                    valley++;
                currPosition += (path[i] == 'D') ? -1 : 1;
            }
            return valley;
        }

    }
}