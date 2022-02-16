using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class BinarySearchProblem
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string binary = Convert.ToString(n, 2);
        //Console.WriteLine(binary);
        int conCount = 0;
        int oldCount = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                if (i > 0 && binary[i - 1] == '1')
                    conCount++;
                else
                    conCount = 1;
            }
            else
            {
                if (conCount > oldCount)
                    oldCount = conCount;
                conCount = 0;
            }
        }

        Console.WriteLine(conCount > oldCount ? conCount : oldCount);
        Console.ReadLine();
    }
}
