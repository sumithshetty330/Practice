using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class MainClass
    {
        static void Main()
        {
            Employee obj;
            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine("------------------------");
                    GC.Collect();
                }
                obj = new Employee(i + 1);
            }
            Console.WriteLine("**********************************");
        }
    }
}
