using System;
public class Program
{
    public static void Main()
    {
        int[] myArr = new int[5] { 5, 6, 7, 8, 9 };
      
        int len = myArr.Length;
        int sum = 0;
        int average = 0;
        for (int i = 0; i < len; i++)
        {
            sum += myArr[i];
        }
        average = sum / len;
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average Of integer elements = " + average);
        int a = myArr.Max();
        Console.WriteLine("The Largest array value is: "+a);
        int b= myArr.Min();
        Console.WriteLine("The Smallest array value is: " + b);
    }   

}