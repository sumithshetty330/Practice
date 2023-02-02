using System;
class OddorEven
{
    public static void Main(String[] args)
    {
        int a;
        Console.WriteLine("Enter a Number: ");
        a=int.Parse(Console.ReadLine());
        int b = a / 2;
        if(b == 0)
        {
            Console.WriteLine("The number" + a + "is Even");
        }
        else
        {
            Console.WriteLine("The number" + a + "is Odd");
        }
        

    }
}
