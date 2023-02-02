using System;



abstract class Student
{
    public string name;
    public string cls;



    public abstract float GetPercentage();
    public abstract int GetNumberOfStudent();

    public Student(string Name, string Classes)
    {
        this.name = Name;
        this.cls = Classes;
    }
}



class ScienceStudent : Student
{
    int physicsMarks;
    int chemistryMarks;
    int mathsMarks;
    static int numberOfStudent;



    public ScienceStudent(string name, string cls, int physics, int chemistry, int maths) : base(name, cls)
    {
        this.physicsMarks = physics;
        this.chemistryMarks = chemistry;
        this.mathsMarks = maths;
        numberOfStudent++;
    }



    public override float GetPercentage()
    {
        return ((this.physicsMarks + this.chemistryMarks + this.mathsMarks) / 300f) * 100;
    }



    public override int GetNumberOfStudent()
    {
        return numberOfStudent;
    }
}



class HistoryStudent : Student
{
    int historysMarks;
    int civicsMarks;

    static int numberOfStudent;



    public HistoryStudent(string name, string cls, int history, int civics) : base(name, cls)
    {
        this.historysMarks = history;
        this.civicsMarks = civics;
        numberOfStudent++;
    }



    public override float GetPercentage()
    {
        return ((this.civicsMarks + this.historysMarks) / 200f) * 100;
    }



    public override int GetNumberOfStudent()
    {
        return numberOfStudent;
    }




}






class MainClass
{
    static void Main()
    {
        ScienceStudent scienceStudent = new ScienceStudent("Pruthvi", "FirstPuc", 60, 35, 75);
        ScienceStudent scienceStudent1 = new ScienceStudent("Nikhil", "FirstPuc", 50, 45, 85);
        HistoryStudent historyStudent = new HistoryStudent("Karthik", "SecondPuc", 70, 45);
        Console.WriteLine("1.Name Of Science Student: {0}\n 2.Class: {1}\n 3.Number Of ScienceStudent: {2}\n 4.Percentage Got in Science Stream {3}", scienceStudent.name,
            scienceStudent.cls, scienceStudent.GetNumberOfStudent(), scienceStudent.GetPercentage());



        Console.WriteLine("*************************************************");



        Console.WriteLine("1.Name Of History Student: {0}\n 2 Class: {1}\n 3.Number Of HistoryStudent: {2}\n 4.Percentage Got in History Stream {3}", historyStudent.name,
            historyStudent.cls, historyStudent.GetNumberOfStudent(), historyStudent.GetPercentage());



        Console.WriteLine("*************************************************");



        Console.WriteLine("1.Name Of Science Student: {0}\n 2.Class: {1}\n 3.Number Of ScienceStudent: {2}\n 4.Percentage Got in Science Stream {3}", scienceStudent1.name,
            scienceStudent1.cls, scienceStudent1.GetNumberOfStudent(), scienceStudent1.GetPercentage());



    }
}