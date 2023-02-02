using System;
namespace Destructor
{
    class Employee
    {
        public int ID;
        public Employee(int iD)
        {
            ID = iD;
            Console.WriteLine("Constructor for ID {0}",this.ID);
        }
        ~Employee()
        {
            Console.WriteLine("Destructor for employee {0}", this.ID);
        }
    }
}