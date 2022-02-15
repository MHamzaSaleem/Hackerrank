using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class NameCountProblem
    {
        static void Main(string[] args)
        {
            string[,] arr = { { "Hamza", "Taha", "Zeeshan" }, { "Ammar", "Zeeshan", "Zaid" }, { "Zeeshan", "Zaid", "Ammar" } };
            List<NameCount> res = new List<NameCount>();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (res.Count == 0)
                    {
                        res.Add(new NameCount { Name = arr[i, j], Count = 1 });
                    }
                    else
                    {
                        bool isExist = res.Exists(x => x.Name == arr[i, j]);
                        if (isExist)
                        {
                            for (int k = 0; k < res.Count; k++)
                            {
                                if (arr[i, j] == res[k].Name)
                                {
                                    res[k].Count += 1;
                                    break;
                                }
                            }
                        }
                        else
                            res.Add(new NameCount { Name = arr[i, j], Count = 1 });
                    }
                }
            }
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i].Name + ", " + res[i].Count);
            }
            Console.Read();
        }
        class NameCount
        {
            public string Name { get; set; }
            public int Count { get; set; }
        }
    }
}
