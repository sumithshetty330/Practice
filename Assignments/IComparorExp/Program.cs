using System;
using System.Collections;
using System.Collections.Generic;



class Student
{

    public int Age;
    public Student(int age)
    {
        // this.Name = name;
        this.Age = age;
    }


    public override string ToString()
    {
        return this.Age.ToString();
    }
}
public class StudentComaprer : IComparer
{
    public int Compare(object obj1, object obj2)
    {
        Student x = (Student)obj1;
        Student y = (Student)obj2;
        return x.Age.CompareTo(y.Age);
    }



}




class MainClass
{
    static void Main()
    {
        Student[] student1 = new Student[5];



        student1[0] = new Student(20);
        student1[1] = new Student(23);
        student1[2] = new Student(22);
        student1[3] = new Student(21);
        student1[4] = new Student(19);



        //list before compared items
        Console.WriteLine("Before Sort");
        foreach (Student student in student1)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("\n************************");
        Array.Sort(student1, new StudentComaprer());
        //Console.WriteLine(Compare());
        foreach (Student j in student1)
        {
            Console.WriteLine(j);
        }



    }
}
