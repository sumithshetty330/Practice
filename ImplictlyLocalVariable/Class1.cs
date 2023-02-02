
using System;
namespace ImplicitlyLocalVariable
{
    struct Student
    {
        public int RollNo;
    }
    class MainClass
    {
        static void Main()
        {
            int k = 10;
            var intValue = k++;
            Console.WriteLine("IntValue={0}", ++intValue);
            /*Declarator must include initializer
             var i;
            i=10;*/

            /*the compile-time of the initalizer experssion cannot be the null type.
             var p=null;*/

            var StringValue1 = "Sumith";
            Console.WriteLine("String Value={0}", StringValue1);

            //var intArray={"1","2","3","4","5"};//Error collection initializer not permitted
            var intArray = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------");

            var objEmp = new Employee();
            objEmp.EmpID = 101;
            Console.WriteLine(objEmp.EmpID);
            Employee emp = new Employee();
            objEmp= emp;
            objEmp.EmpID = 102;
            Console.WriteLine(objEmp.EmpID);
            Console.WriteLine(emp.EmpID);

            Student s= new Student();
            var objStudent = s;
            objStudent.RollNo = 10;
            Console.WriteLine("Roll Number={0}",objStudent.RollNo);


        }
    }
}
