using System;
namespace OutRef
{
    class class1
    {
        public int k;
    }
    class MainClass
    {
        public static void M(ref int a, out int b)
        {
            Console.WriteLine(a);
            a = 100;
            b = 200;



        }
        public static void N(ref class1 c2)
        {
            c2 = new class1();
            c2.k = 100;
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
            class1 c1 = new class1();



            M(ref a, out b);
            N(ref c1);
        }
    }
}
