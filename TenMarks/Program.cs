using System;
using System.Linq;
class MainClass
{
    public static void Main()
    {
        int[] num = new int[10] { 22, 43, 34, 54, 63, 22, 13, 53, 56, 43 };
        int sum = 22 + 43 + 34 + 54 + 63 + 22 + 13 + 53 + 56 + 43;
        Console.WriteLine("Total sum is: " + sum);
        int AVG = sum / 10;
        Console.WriteLine("AVG is: " + AVG);
        int m = num.Min();
        Console.WriteLine("the min value is: " + m);
        int n = num.Max();
        Console.WriteLine("the max value is: " + n);
        Array.Sort(num);
        Console.WriteLine("ascending order");
        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");

        }
        Array.Reverse(num);
        Console.WriteLine("descending order");
        for(int i = 0; i > num.Length; i--)
        {
            Console.WriteLine(num[i] + " ");
        }
    }
}