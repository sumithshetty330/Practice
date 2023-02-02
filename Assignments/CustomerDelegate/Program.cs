using System;
using PrintServiceDelegate;
namespace CustomerDelegate {
     public class Customer
    {
        int custID;
        String custName;
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
            PrintDelegate d = new PrintDelegate(Display);
            Printingservice.print(d);
        }
    }
        
}