using System;
namespace ExceptionHandling
{
    class MainClass
    {
        static void M()
        {
            try
            {
                Console.WriteLine("Enter the number: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the sec number");
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine(i / j);

            }
            catch (DllNotFoundException x)
            {
                Console.WriteLine("sorry dll is missing");
            }
            finally
            {
                Console.WriteLine("finally closing m");
            }
            Console.WriteLine("After finally in m");
        }
        static void Main()
        {
            Repeat:

            try
            {
                M();
            }
            catch(DivideByZeroException q)
            {
                Console.WriteLine("second argument is zero: ");
                goto Repeat;
            }
            catch(Exception s)
            {
                Console.WriteLine(s.Message);
            }
            finally
            {
                Console.WriteLine("finally in main");
            }
            Console.WriteLine("---------------------");
        }
    }
}
            
            
        
        
            
        
        
