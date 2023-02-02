using System;
namespace IComparableTeacher
{
    struct Teacher : IComparable
    {
        public int Subject;
        public int CompareTo(object obj)
        {
            Teacher t = (Teacher)obj;
            return this.Subject.CompareTo(t.Subject);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }


    class MainClass
    {
        static void Main()
        {
            int i = 10, j = 30;
            Console.WriteLine(i.CompareTo(j));
            Teacher a, b; a.Subject = 10; b.Subject = 20;
            Console.WriteLine(a.CompareTo(b));
            Console.WriteLine("---------------");
            int[] ints = new int[5] { 10, 40, 50, 30, 20 };
            Array.Sort(ints);
            foreach (int l in ints)
            {
                Console.WriteLine(l + " ");
            }
            Console.WriteLine("\n-----------------------");
            Teacher[] Sub = new Teacher[5];
            Sub[0].Subject = 50;
            Sub[1].Subject = 30;
            Sub[2].Subject = 20;
            Sub[3].Subject = 40;
            Sub[4].Subject = 10;
            Array.Sort(Sub);
            foreach (Teacher N in Sub)
            {
                Console.WriteLine(N.Subject + " ");
            }
            IComparable[] Arr = new IComparable[5];
            Arr[0] = Sub[0];
            Arr[1] = Sub[1];
            Arr[2] = Sub[2];
            Arr[3] = Sub[3];
            Arr[4] = Sub[4];
            Array.Sort(Arr);
            foreach (Teacher N in Arr)
            {
                Console.WriteLine(N + " ");
            }
        }
    }
}

                
      



