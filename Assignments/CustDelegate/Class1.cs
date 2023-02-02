using System;
namespace customer
{
    class Customer
    {
        int custID;
        String custName;

        public object PrintingService { get; private set; }

        public Customer(int id, String name)
        {
            custID = id;
            custName = name;
        }
        private void Display()
        {
            Console.WriteLine("Cust ID: {0}", this.custID);
            Console.WriteLine("Cust name: {0}", this.custName);

        }
        public void AvailService()
        {
            PrintingService.Print(Display);
        }
    }
}
