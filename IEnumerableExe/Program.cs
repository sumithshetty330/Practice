using System;
using System.Collections.Generic;
using System.Collections;



class MainClass
{
    static void UsingHashTable()
    {
        Hashtable hash=new Hashtable();
        hash.Add(1, "sumith");
        hash.Add(3, "Naveen");
        hash.Add(4, "Pruthvi");
        hash.Add(2, "Ranjini");
        hash.Add(7, "Mukesh");
        hash.Add(5, "Abinaya");
        hash.Add(6, "hari");
    }

    static void Main()
    {
        int[] intArray = new int[6] { 1, 2, 3, 4, 5, 6, };
        foreach (int i in intArray)
        {
            Console.WriteLine(i + " ");
        }
        Console.WriteLine("\n*****************");



        IEnumerator e = intArray.GetEnumerator();
        while (e.MoveNext())
        {
            Console.WriteLine(e.Current + " ");
        }
        e.Reset();



        Console.WriteLine("***********************");




        IEnumerable en = intArray;//System.Array has implemented IEnuermable inteface
        foreach (int i in en)
        {
            Console.WriteLine(i + " ");



        }



        Console.WriteLine("***********************");



        e = en.GetEnumerator();
        while (e.MoveNext())
        {
            Console.WriteLine(e.Current + " ");
        }
        e.Reset();



        Console.WriteLine("\n ************************");
    }
}
