using System;
 public class Employee
{
    int Id, Basic, da, hra;
    String EmpName;
    public Employee(int id,int _basic,String empName,int _da,int _hra)
    {
        EmpName = empName;
        Id = id;
        Basic = _basic;
        da= _da;    
        hra = _hra;    
    }
     private int Salary
    {
        get
        {
            return Basic + da + hra;
        }
    }
    private void salarySlip()
    {
        Console.WriteLine("Emp id: {0}", this.Id);
        Console.WriteLine("Emp Name: {0}",this.EmpName);
        Console.WriteLine("Salary: {0}",this.Salary);

    }
    public void GenerateSalarySlip()
    {
        PrintingService.Print(salarySlip);
    }
}