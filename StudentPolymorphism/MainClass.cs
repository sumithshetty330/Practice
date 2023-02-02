using System;
class Student
{
    static int id = 1001;
    public readonly int studentId;
    string studentname;
    public int englishmarks, generalmarks, socialmarks, environmentmarks, sciencemarks, commercemarks;
    public Student(string name, int english, int general, int social, int environment)
    {
        this.studentname = name;
        this.englishmarks = english;
        this.generalmarks = general;
        this.socialmarks = social;
        this.environmentmarks = environment;
        studentId = id++;



    }
    public virtual string PrintMarkSheet()
    {



        return string.Format(" Id of an Student\t\t: {0}\n Name of a student is\t\t: {1}\n Marks in English\t\t: {2}\n Marks in General Studies\t: {3}\n Marks in Social Studies\t: {4}\n Marks in Environmental Studies\t: {5}", studentId, studentname, englishmarks, generalmarks, socialmarks, environmentmarks);
    }
}
class ScienceStudent : Student
{
    int sciencemarks;
    public ScienceStudent(string name, int english, int general, int social, int environment, int sciencemarks) : base(name, english, general, social, environment)
    {
        this.sciencemarks = sciencemarks;

    }
    public override string PrintMarkSheet()
    {
        return base.PrintMarkSheet() + "\n Science Marks:{0}" + sciencemarks;
    }
}
class CommerceStudent : Student
{
    int commercemarks;
    public CommerceStudent(string name, int english, int general, int social, int environment, int commercemarks) : base(name, english, general, social, environment)
    {
        this.commercemarks = commercemarks;
    }
    public override string PrintMarkSheet()
    {
        return base.PrintMarkSheet() + "\n Commerce Marks:{0}" + commercemarks;
    }
}
class MainClass
{



    static int option, counter, index, counter1, streamoption;
    static char choice;
    static string studentname;
    static int englishmarks, generalstudies, socialmarks, environmentalstudies, sciencemarks, commercemarks;
    static Student[] sciencearr = new Student[10];
    static Student[] commercearr = new Student[10];
    static void Main()
    {
        do
        {
            Console.WriteLine("The Options Are:");
            Console.WriteLine(" 1.Add an Student \n 2.Display the complete Students data\n 3.Exit ");
            Console.Write("Choose an option to continue:");
            option = Convert.ToInt32(Console.ReadLine());
            Stream(option);
            Console.WriteLine(" Do you want to continue (Y/N)");
            choice = Console.ReadLine()[0];
        } while (choice == 'y' || choice == 'Y');
    }
    static void Stream(int number)
    {
        switch (option)
        {
            case 1:
                Console.Write(" 1.Science Stream\n 2.Commerce Stream\n Enter stream to continue:");
                streamoption = Convert.ToInt32(Console.ReadLine());
                StreamSwitch(streamoption);
                break;
            case 2:
                Console.WriteLine("-------------THE DETAILS ARE---------------");
                AllStudents();
                break;
            /*case 3:
                ParticularStudent();
                break; */
            case 3:
                Console.WriteLine("Program is now Exicited");
                Environment.Exit(0);
                break;



        }
        static void StreamSwitch(int num)
        {
            switch (streamoption)
            {
                case 1:
                    AddStudent();
                    Console.Write("Enter Science Subject Marks");
                    sciencemarks = Convert.ToInt32(Console.ReadLine());
                    sciencearr[counter++] = new ScienceStudent(studentname, englishmarks, generalstudies, socialmarks, environmentalstudies, sciencemarks);
                    break;
                case 2:
                    AddStudent();
                    Console.Write("Enter Commerce Subject Marks:");
                    commercemarks = Convert.ToInt32(Console.ReadLine());
                    commercearr[counter1++] = new CommerceStudent(studentname, englishmarks, generalstudies, socialmarks, environmentalstudies, commercemarks);
                    break;
            }
        }
    }
    static void AddStudent()
    {
        Console.Write("Enter Name of a Student:");
        studentname = Console.ReadLine();
        Console.Write("Enter English Marks of a Student:");
        englishmarks = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter General Studies Marks of a Student:");
        generalstudies = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Social Marks of a Student:");
        socialmarks = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Environmental Studies Marks of a Student:");
        environmentalstudies = Convert.ToInt32(Console.ReadLine());



    }
    static void AllStudents()
    {
        for (index = 0; index < counter; index++)
        {



            Console.WriteLine(sciencearr[index].PrintMarkSheet());
            Console.WriteLine("-------------------------------------------");
        }
        for (index = 0; index < counter1; index++)
        {
            Console.WriteLine(commercearr[index].PrintMarkSheet());
            Console.WriteLine("-------------------------------------------");
        }
    }
    /*
    static void ParticularStudent()
    {
        Console.Write("Enter the Id of an Particular Student:");
        studentkey = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n-------------THE DETAILS ARE---------------");
        for (index = 0; index < counter; index++)
        {
            if (studentarr[index].studentId == studentkey)
            {
                Console.WriteLine(studentarr[index].PrintMarkSheet());
                Console.WriteLine("-------------------------------------------");
            }
        }
    }*/
}