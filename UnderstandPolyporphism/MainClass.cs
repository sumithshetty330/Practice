
using System;
namespace Employee
{
    class Employee
    {
        private static int _id = 1001;
        public readonly int _empId;
        string _empName;
        float _basic, _da, _hra;
        public Employee(string empName, float basic, float da, float hra)
        {
            this._empId = _id++;
            this._empName = empName;
            this._basic = basic;
            this._da = da;
            this._hra = hra;
        }

        public virtual string PrintSalarySlip()
        {
            return string.Format(" Employee Id: {0}\n Employee Name:{1}\n Basic Pay:{2}\n " +
            "Dearness Allowance:{3}\n House Rent Allowance:{4}\n ", _empId, _empName, _basic, _da, _hra);
        }
        protected virtual float TotalSalary
        {
            get
            {
                return _basic + _da + _hra;
            }
        }
    }
    class HR : Employee
    {
        float hr_allowance;
        public HR(string name, float basic, float da, float hra, float hr_allowance) : base(name, basic, da, hra)
        {
            this.hr_allowance = hr_allowance;
        }
        protected override float TotalSalary
        {
            get
            {
                return base.TotalSalary + hr_allowance;
            }
        }
        public override string PrintSalarySlip()
        {
            return base.PrintSalarySlip() + string.Format("HR Allowance: {0}\n Total Salary:{1}\n", hr_allowance, TotalSalary);
        }
    }
    class Admin : Employee
    {
        float admin_allowance;
        public Admin(string name, float basic, float da, float hra, float admin_allowance) : base(name, basic, da, hra)
        {
            this.admin_allowance = admin_allowance;
        }
        protected override float TotalSalary
        {
            get
            {
                return base.TotalSalary + admin_allowance;
            }
        }
        public override string PrintSalarySlip()
        {
            return base.PrintSalarySlip() + string.Format("Admin Allowance: {0}\n Total Salary:{1}\n", admin_allowance, TotalSalary);
        }
    }


 class Software : Employee
    {
        float project_allowance;
        public Software(string name, float basic, float da, float hra, float project_allowance) : base(name, basic, da, hra)
        {
            this.project_allowance = project_allowance;
        }
        protected override float TotalSalary
        {
            get
            {
                return base.TotalSalary + project_allowance;
            }
        }
        public override string PrintSalarySlip()
        {
            return base.PrintSalarySlip() + string.Format("Project Allowance: {0}\n Total Salary:{1}\n", project_allowance, TotalSalary);
        }
    }
    enum Role : byte
    {
        HR = 1,
        Admin,
        Software
    }
    class MainClass
    {
        static int counter;
        static string name;
        static float basic, da, hra;
        static Employee[] companyemployees = new Employee[10];
        static void AddEmployee()
        {
            Console.Write("Enter Employee name: ");
            name = Console.ReadLine();
            Console.Write("Enter basic pay: ");
            basic = float.Parse(Console.ReadLine());
            Console.Write("Enter DA: ");
            da = float.Parse(Console.ReadLine());
            Console.Write("Enter HRA: ");
            hra = float.Parse(Console.ReadLine());
        }
        static void Main()
        {
            char ch;
            do
            {
                Console.WriteLine("1. Add Employee\n2. Print Existing Employee Details\n3. Print All Employee Details\n4.Exit");
                byte opt = byte.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter role\n1. HR\n2. Admin\n3. Software");
                        byte role = byte.Parse(Console.ReadLine());
                        switch ((Role)role)
                        {
                            case Role.HR:
                                AddEmployee();
                                Console.Write("Enter HR Allowance: ");
                                float hr_allowance = float.Parse(Console.ReadLine());
                                companyemployees[counter++] = new HR(name, basic, da, hra, hr_allowance);

                                break;
                            case Role.Admin:
                                AddEmployee();
                                Console.Write("Enter Admin Allowance: ");
                                float admin_allowance = float.Parse(Console.ReadLine());
                                companyemployees[counter++] = new Admin(name, basic, da, hra, admin_allowance);
                                break;
                            case Role.Software:
                                AddEmployee();
                                Console.Write("Enter Project Allowance: ");
                                float project_allowance = float.Parse(Console.ReadLine());
                                companyemployees[counter++] = new Software(name, basic, da, hra, project_allowance);
                                break;

                        }
                        break;
                    case 2:
                        Console.Write("Enter the employee id: ");
                        int emp_id = int.Parse(Console.ReadLine());
                        SearchEmployee(emp_id);
                        break;
                    case 3:
                        Print();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter valid option");
                        break;
                }
                Console.WriteLine("Do you want to continue? (Y|N)");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');
        }
        static void Print()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(companyemployees[i].PrintSalarySlip());
                Console.WriteLine("--------------------------------------------------------");
            }
        }
        static void SearchEmployee(int emp_id)
        {
            for (int i = 0; i < counter; i++)
            {
                if (companyemployees[i]._empId == emp_id)
                {
                    Console.WriteLine(companyemployees[i].PrintSalarySlip());

                }
            }
        }
    }
}

