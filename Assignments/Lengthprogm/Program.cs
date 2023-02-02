using System;
namespace LengthPrgm
{
    class MainClass
    {
        public static void Main()
        {
            String name;

            Console.WriteLine("Enter the Word: ");
            name = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }

            
}