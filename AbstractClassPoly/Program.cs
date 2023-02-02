
using System;
 
abstract class Employee
{
    public abstract void Duties();
    public abstract int TotalSalaryM();
    public string _empName;
    public int _basic, _da, _hra, Totalsalary;


    public int TotalSalary
    {
        get
        {
            return this.Totalsalary;
        }
    }



    public Employee(string name, int basic, int da, int hra)
    {

        this._empName = name;
        this._basic = basic;
        this._da = da;
        this._hra = hra;

        this.Totalsalary = basic + da + hra;
    }





}
class DailyWorker : Employee
{
    public int _DWAllowance;

    public DailyWorker(string name, int basic, int da, int hra, int allowance) : base(name, basic, da, hra)
    {
        this._DWAllowance = allowance;
    }


    public override void Duties()
    {
        Console.WriteLine("Physical work");
    }
    public override int TotalSalaryM()
    {
        return base.TotalSalary + this._DWAllowance;
    }


}
class SoftwareEngineer : Employee
{


    private int _SEAllowance;

    public SoftwareEngineer(string name, int basic, int da, int hra, int allowance) : base(name, basic, da, hra)
    {
        this._SEAllowance = allowance;
    }

    public override void Duties()
    {
        Console.WriteLine("Mental Work");
    }

    public override int TotalSalaryM()
    {
        return base.TotalSalary + this._SEAllowance;
    }
}


class MainClass
{
    public static void Main(string[] args)
    {
        Employee[] emps = new Employee[2];
        emps[0] = new DailyWorker("Ranjini", 8267, 987, 872, 826);
        emps[1] = new SoftwareEngineer("Abcsg", 826, 927, 982, 876);

        foreach (Employee e in emps)
        {
            e.Duties();
            e.TotalSalaryM();
        }
    }
}


