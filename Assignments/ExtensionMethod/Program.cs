using System;
namespace ExtensionMethod
{
    public static class MyExtensions
    {
        public static int ToInt32(this string s)// Add new method in string class
        {
            return int.Parse(s);
        }
    }
    class MainClass
    {
        static void Main()
        {
            string str = "1234";
            int i=str.ToInt32();
            Console.WriteLine(i);
        }
    }
}