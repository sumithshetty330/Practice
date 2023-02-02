using System;
namespace GarbageCollection
{
    class test : IDisposable
    {
        private bool isdisposed;
        private int id;
        public int salary
        {
         
        }
        
        public Employee(int d)
        {
            this.id = id;
            this.isdisposed= false;
            Console.WriteLine("object instantiated for id={0}",this.id);
        }
        ~Employee()
        {
            if (!isdisposed)
            {
                this.Dispose();
            }
            Console.WriteLine("object destroyed for id={0}",this.id);
        }
        public void WorkStatus()
        {
            if (this.isdisposed)
            {
                throw new ObjectDisposedException(this.id.ToString(),"Employee Has been terminated");
            }
            else
            {
                Console.WriteLine("id=" +this.id+ "is workign properly");
            }
        }
        public void IncrementSalary(int increament)
        {
            if (this.isdisposed)
            {
                throw new ObjectDisposedException(this.id.ToString(), "Employee has been terminated");
            }
            else
            {
                Console.WriteLine("Salary increament for employee is={0}",this.id);
                this.salary += increament;
            }
        }
        public void Dispose()
        {
            //Cleanup code
            Console.WriteLine(this.id+"is being disposed");
            GC.SuppressFinalize(this);
            this.isdisposed= true;  
        }
     
    }
}