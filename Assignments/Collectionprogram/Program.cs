using System;

using System.Collections;
using System.Collections.Generic;
namespace generic
{
    class student
    {

    }
    class MainClass
    {
        static void UsingHashTable()
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "sumith");
            hash.Add(3, "Naveen");
            hash.Add(4, "Pruthvi");
            hash.Add(2, "Ranjini");
            hash.Add(7, "Mukesh");
            hash.Add(5, "Abinaya");
            hash.Add(6, "hari");

            foreach (object i in hash.Values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");
            foreach (int a in hash.Keys)
            {
                Console.WriteLine(hash[a]);
            }
        }
        static void UsingSortedList()
        {
            SortedList list = new SortedList();
            list.Add("a1", "sumith");
            list.Add("a3", new student());
            list.Add("a4", "naveen");
            list.Add("a2", "pruthvi");
            list.Add("a5", "Ranjini");
            list.Add("a7", "Hari");
            list.Add("a6", "Mukesh");
            ICollection t = list.Values;
            foreach(object i in list.Values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------");
            foreach(String i in list.Keys)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("\n{0} is at index 1",list.GetByIndex(1));
        }
        static void ArrayList()
        {
            ArrayList n1 = new ArrayList(3);
            n1.Add(23);
            n1.Add("sumith");
            n1.Add(new object());
            n1.Add("Rishith");
            n1.Add(17);
            n1.Add(new MainClass());
            n1.Add(new Queue());
            n1.RemoveAt(5);
            n1.Remove("sumith");
            n1.RemoveAt(2);
            foreach (object i in n1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nCapacities: " + n1.Capacity);
            Console.WriteLine("count: " + n1.Count);
        }
        
        static void UsingStack()
        {


            Stack stack = new Stack();


            stack.Push("sai");
            stack.Push("praksah");
            stack.Push("vidya");
            stack.Push("Ranjini");
            stack.Push(1234);
            stack.Push(656.37);


            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("*************************");
            stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
        static void UQueue()
        {


            Queue queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            queue.Enqueue("Truck");
            queue.Enqueue(1);
            queue.Enqueue(100);
            queue.Enqueue("Bike");
            queue.Enqueue(2.4);
            queue.Enqueue("Bus");


            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("*************************");

            queue.Dequeue();

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
        }


        static void ListExample()
        {
            List<int> a1 = new List<int>(3);
            a1.Add(1);
            a1.Add(2);
            a1.Add(3);
            a1.Add(4);
            a1.Remove(1);
            a1.Remove(3);
            foreach(object obj in a1)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("\nCapacity: "+a1.Capacity);
            Console.WriteLine("count: "+a1.Count);
        }
        static void Main()
        {
            ArrayList();
            ListExample();
            UsingHashTable();
            UsingSortedList();
        }
    }
}