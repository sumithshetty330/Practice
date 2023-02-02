using System;
namespace DisposPgm
{
    class Dispose : IDisposable
    {
        public void dispose()
        {
            Console.WriteLine("Run cleanup code here");
        }
        ~Dispose()
        {
            Console.WriteLine("Destructor for cleanup code");
        }
    }
    class MainClass
    {
        static void M()
        {
            Dispose[] a = new Dispose[10];
            for (int i = 0; i < 10; i++)
            {
                using (a[i] = new Dispose())
                {

                }
                System.Threading.Thread.Sleep(100);
            }
        }
        static void Main()
        {
            M();
            GC.Collect();
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("------------------");
        }
    }
}