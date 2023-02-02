using System;
namespace ExceptionThrow
{
    class MainClass
    {
        static void M()
        {
            try
            {
                int i = 10;
                int j = 0;
                if (j == 0)
                {
                    throw new Exception("print it");
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                Console.WriteLine("finally block");
            }
            Console.WriteLine("Finally");
        }
        static void Main()
        {
            try
            {
                M();
            }
            catch (DllNotFoundException x)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("finally print");
            }
            Console.WriteLine("code at the end");
        }
    }
}

               


 