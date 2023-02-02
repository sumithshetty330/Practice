using System;
class MainClass
{
    public static void Main()
    {
        String name,name2; 
        Console.WriteLine("Enter the string: ");
        name = Console.ReadLine();
        name2 = Console.ReadLine();
        if (name == name2)
        {
            Console.WriteLine("The Words are same");
        }
        else
        {
            Console.WriteLine("Not same");
        }
    }
}