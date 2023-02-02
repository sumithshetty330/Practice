using System;
class MaxMin
{
    public static void MaxMinValue()
    {
        int[] m = new int[5] { 22, 54, 66, 43, 67 };
        int max = m.Max();  
        Console.WriteLine("The largest Value is: "+max);
        Console.WriteLine("-----------------------------");
        int Min = m.Min();
        Console.WriteLine("The Smallest Value is: "+Min);
        

    

    }
    static void Main()
    {
        MaxMinValue();
    }
}