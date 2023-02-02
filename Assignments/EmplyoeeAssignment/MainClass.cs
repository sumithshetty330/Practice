using System;
namespace System
{
    class Employee
    {
        
        String _EmpName;
        decimal _basic, _da, _hra;
        decimal _EmpSalary, _totalSalary;
        public readonly int _empId;
         
        public  int id;
        public Employee(String Name, decimal BasicSalary, decimal Da, decimal Hra)
        {
            this._EmpName = Name;
            this._basic = BasicSalary;
            this._da = Da;
            this._hra = Hra;

        }
        public String printsalaryslip()
        {
            _totalSalary = _basic + _da + _hra;
            return String.Format("Emp Id:{0}\n,Emp Name:{1}\n,Basic Sal:{2}\n,Dearness allowance:{3}\n,House rent allowance:{4}\n,Emp Sal:{5}\n,Total sal:{6}", _empId, _EmpName, _basic, _da, _hra, _EmpSalary, _totalSalary);

        }
    }
    public class MainClass
    {
        static void Main()
        {
            Employee[] Emp = new Employee[10];
            int count = 0; char ch;
            int Empid;
            int index;
            do
            {
                Console.WriteLine("Enter the Requirment");
                Console.WriteLine("1.Joining new employee \n2.print salary slip of an employee \n3.print salary slip of all employee \n4.Exit");
                int p = int.Parse(Console.ReadLine());
                switch (p)
                {
                    case 1:
                        Console.WriteLine("Enter employee name");
                        String name = Console.ReadLine();
                        Console.WriteLine("Enyter Basic sal");
                        decimal BasicSalary = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter dearness allowance");
                        decimal da = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("enter hra");
                        decimal Hra = decimal.Parse(Console.ReadLine());
                        Emp[count++] = new Employee(name, BasicSalary, da, Hra);
                        break;
                    case 2:
                        Console.WriteLine("Enter the employee id of an employee");
                        Empid = int.Parse(Console.ReadLine());
                        for(index=0;index<count;index++)
                        {
                            if (Emp[index]._empId == Empid)
                            {
                                Console.WriteLine(Emp[index].printsalaryslip());
                            }
                            else
                            {
                                Console.WriteLine("Employee Doesn't exist");

                            }

                        }
                        
                        break;
                    case 3:

                        break;
                    case 4: Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
                Console.WriteLine("Do you want to continue(Y|N)");
                ch = char.Parse(Console.ReadLine());
            } while (ch == 'Y' || ch == 'y');
           
        }
        
    }
}