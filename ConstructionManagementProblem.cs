using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class ConstructionManagementProblem
    {
        static void Main(String[] args)
        {
            int[,] arr = {
                //{ 1, 2, 2 },
                //{ 2, 3, 3 },
                //{ 3, 3, 1 }

                //{1, 2, 3 },
                //{1, 2, 3 },
                //{3, 3, 1 }

                {1, 2, 2 },
                {2, 2, 1 },
                {2, 1, 2 }
            };
            List<int> values = new List<int>();
            int prevIndex = int.MinValue;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int temp = int.MinValue;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            temp = j;
                            prevIndex = j;
                        }
                        else
                        {
                            if (temp > arr[i, j])
                            {
                                temp = arr[i, j];
                                prevIndex = j;
                            }
                        }
                    }
                    else if(prevIndex != j)
                    {
                        if(temp<0)
                        { 
                            temp = arr[i, j];
                            prevIndex = j;
                        }
                        else
                        {
                            if (temp > arr[i, j])
                            {
                                temp = arr[i, j];
                                prevIndex = j;
                            }
                        }
                    }
                }
                values.Add(arr[i, prevIndex]);
            }
            for (int i = 0; i < values.Count; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.Read();
        }
    }
}
