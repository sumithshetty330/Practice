using System;
using System.Threading;
namespace Threading
{
    class MainClass
    {
        public static void M()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("thread M:{0}", i + 1);

            }
        }
        public static void N()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("thread Another:{0}", i + 1);
            }
        }
        public static void p(object s)
        {
            Console.WriteLine("hello"+(string)s);
        }
        static void Main()
        {
            Thread t1 = new Thread(M);
            Thread t2 = new Thread(N);
            t1.Start();
            t2.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Main:{0}", i);
            }
            Console.WriteLine("Hello Back in Main");
            Thread t3=new Thread(new ParameterizedThreadStart(p));  
            t3.Start("Dwyane Johnson");
            Console.WriteLine("----------------");
        }
    }
}
