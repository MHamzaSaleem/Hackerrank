using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    // Add your code here
    public Difference(int[] arr)
    {
        this.elements = arr;
    }

    public void computeDifference()
    {
        for (int i = 0; i < this.elements.Length; i++)
        {
            for (int j = i + 1; j < this.elements.Length; j++)
            {
                int temp = this.elements[i] - this.elements[j];
                if (Math.Abs(temp) > this.maximumDifference)
                    this.maximumDifference = Math.Abs(temp);
            }
        }
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}