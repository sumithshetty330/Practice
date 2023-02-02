using System;
using System.Collections.Generic;


namespace GarbageCollection
{
    class MainClass1
    {
        static void Main()
        {
            using (Employee e1 = new Employee(1))
            {
                e1.IncrementSalary(2000);
                e1.WorkStatus();
                e1.Salary = 10000;

            }
        }
    }

