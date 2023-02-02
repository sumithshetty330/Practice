using System;
class AvgMarks
{
    public static void Main(String[] args)
    {
        int a, b, c;
        Console.WriteLine("ENTER THE MARKS FOR THE SUBJECT C#: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER THE MARKS FOR THE SUBJECT  ASP.NET: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER THE MARKS FOR THE SUBJECT SQL SERVER: ");
        c = int.Parse(Console.ReadLine());
        int Avg = a + b + c / 3;
        if (Avg < 50)
        {
            Console.WriteLine("STUDENT AS AN AVERAGE OF LESS THAN 50=FAIL ");

        }
        else
        {
            Console.WriteLine("STUDENT AS AN AVERAGE OF MORE THAN 50=PASS");
        }
    }
}
