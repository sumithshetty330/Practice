using CustomerDelegate;
using System;
namespace DelegateUnderstanding
{
    class MainClass
    {
        static void Main()
        {
            Customer cust = new Customer(101, "Sumith");
            Product prod = new Product(121, "smith");
            Employee emo = new Employee(1232, "mith", 29109, 22001, 19000);
            cust.AvailService();
            Console.WriteLine("---------------");
            prod.UseService();
            Console.WriteLine("-----------------");
            emp.GenerateSalarySlip();
        }
    }

}

