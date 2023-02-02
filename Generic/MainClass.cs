using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        int x = 20, y = 30;
        String name = "sumith";
        String name1 = "naveen";
        Console.WriteLine("Before swap:");
        Console.WriteLine("x = " + x + " and y = " + y);
        x = x + y;
        y = x - y;
        x = x - y;
        Console.WriteLine("After swap:");
        Console.WriteLine("x = " + x + " and y = " + y);
        Console.WriteLine("-------------------------");
        Console.WriteLine("Before Swapping");
        Console.WriteLine("name= "+name+  " name1= "+name1);
        Console.WriteLine("After Swapping");
        String T = name;
        name = name1;
        name1 = T;
        Console.WriteLine("name= " + name + " name1= " + name1);


    }
}
