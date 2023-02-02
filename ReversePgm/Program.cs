using System;
namespace ReversePgm
{
    class MainClass
    {
        public static void Main()
        {
            String word;
            Console.WriteLine("Enter the string: ");
            word=Console.ReadLine();
            String Reverse=String.Empty;
            for(int i = word.Length-1; i>=0; i--)
            {
                Reverse += word[i];
            }
            Console.WriteLine("Reversed String is: "+Reverse);


        }
    }
}