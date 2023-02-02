using System;
 class Employee
{
    private static int _id = 100;
    public readonly int _empId;
    public string _empName;
    public Employee(string empName)
    {
        this._empId = _id++;
        _empName = empName;
    }
    public override string ToString()
    {
        return String.Format("");
    }
}

