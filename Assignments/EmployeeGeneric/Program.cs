
using System;
using System.Collections;
using System.Collections.Generic;
class Employee
{
    public static int id = 0;
    public readonly int EmpID;
    public readonly string EmpName;

    public Employee(string name)
    {
        this.EmpID = id++;
        this.EmpName = name;
    }
    public override string ToString()
    {
        return $"{this.EmpID},{this.EmpName}";
    }
}
class MainClass
{

    static void UsingSortedList()
    {
        SortedList names = new SortedList();
        names.Add(9, new Employee("mukesh"));
        names.Add(8, new Employee("hari"));
        names.Add(5, new Employee("sumith"));
        names.Add(4, new Employee("abhinaya"));
        names.Add(1, new Employee("ranjini"));


        foreach (Employee e in names.Values)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("------------");
    }
    static void UsingHashTable()
    {
        Hashtable employees = new Hashtable();
        employees.Add(1, new Employee("mukesh"));
        employees.Add(2, new Employee("hari"));
        employees.Add(3, new Employee("ram"));
        employees.Add(4, new Employee("raz"));
        employees.Add(5, new Employee("sai"));

        foreach (Employee e in employees.Values)
        {
            Console.WriteLine(e);
        }
        Console.WriteLine("-------");
    }
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        {
            empList.Add(new Employee("MUKESH"));
            empList.Add(new Employee("RAJ"));
            empList.Add(new Employee("RAM"));
            empList.Add(new Employee("SUMITH"));
            empList.Add(new Employee("PRUTHVI"));

            foreach (Employee e in empList)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("------------------");


        };
        ArrayList arrayEmp = new ArrayList();
        arrayEmp.Add(new Employee("mukesh"));
        arrayEmp.Add(new Employee("RAJ"));
        arrayEmp.Add(new Employee("RAM"));
        arrayEmp.Add(new Employee("SUMITH"));
        arrayEmp.Add(new Employee("PRUTHVI"));


        foreach (Employee emp in arrayEmp)
        {
            Console.WriteLine(emp);
        }
        Console.WriteLine("---------------");
        UsingSortedList();
        UsingHashTable();
    }


}

