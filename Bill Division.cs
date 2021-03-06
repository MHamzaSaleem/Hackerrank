
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PalandromeIndex
{
    class Program
    {
        static int palandrome(string s)
        {
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length / 2; i++)
                {
                    for (int j = s.Length - (i + 1); j >= s.Length / 2; j--)
                    {
                        if (s[i] != s[j])
                        {
                            if (s[i] != s[j - 1])
                                return i;
                            else if (s[i + 1] != s[j])
                                return j;
                            else
                            {
                                var temp = s.Substring(i, (j - i));
                                if (temp.Length > 3)
                                {
                                    if (palandrome(s.Substring(i, (j - i))) == -1)
                                    {
                                        return j;
                                    }
                                    else if (palandrome(s.Substring(i - 1, (j - i) + 1)) == -1)
                                    {
                                        return i;
                                    }
                                }
                                return i;
                            }
                        }
                        else
                            break;
                    }
                }
            }
            return -1;
        }


        static void Main(string[] args)
        {
            string[] temp = new string[4] { "hgygsvlfcwnswtuhmyaljkqlqjjqlqkjlaymhutwsnwcwflvsgygh", "aaab", "baaa", "aaa" };
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(palandrome(temp[i]));
            }
            Console.Read();
        }
    }
}