using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;



namespace Linqtoobject
{
    public struct Student
    {
        public string FirstName;
        public string LastName;
        public int[] Scores;
    }

    class Program
    {
        static void Main()
        {
            ArrayList studentlist = new ArrayList
            {
            new Student
            {
                FirstName="naveen",
                LastName="kumar",
                Scores=new int[] {95,99,98,87}
            },
             new Student
             {
                 FirstName = "hari",
                 LastName = "krishna",
                 Scores = new int[] { 99, 87, 78, 87 }
             },
              new Student
              {
                  FirstName = "prithvi",
                  LastName = "raj",
                  Scores = new int[] { 75,89,99,90 }
              },
               new Student
               {
                   FirstName = "sumit",
                   LastName = "shetty",
                   Scores = new int[] { 96,89,78,98 }
               }
               };
            var query = from Student s in studentlist
                        where s.Scores[0] > 95
                        select s;
            foreach (Student stud in query)
            {
                Console.WriteLine(stud.LastName + ": " + stud.Scores[0]);
            }

        }
    }
}