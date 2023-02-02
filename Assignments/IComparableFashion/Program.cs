using System;
namespace IComparableFashion
{
    class Fashion : IComparable
    {
        private int DressId;
        public Fashion(int dressId)
        {
            this.DressId = dressId;
        }
        public int CompareTo(object obj)
        {
            Fashion dress=(Fashion)obj; 
            return DressId.CompareTo(dress.DressId);
        }
        public override string ToString()
        {
            return this.DressId.ToString();
        }
    }
    class MainClass
    {
        static void Main()
        {
            int[] IArr = { 6, 7, 4, 2, 5, 7, 8, 1 };
            Array.Sort(IArr);
            foreach(int i in IArr)
            {
                Console.WriteLine(i);
                
            }
            Fashion[] fash = new Fashion[10];
            for(int i = 10; i > 0; i--)
            {
                fash[i - 1] = new Fashion(i);
            }
            Array.Reverse(fash);    
            //Array.Sort(fash);
            foreach(Fashion f in fash)
            {
                Console.WriteLine(f);
            } 
        }
    }
}