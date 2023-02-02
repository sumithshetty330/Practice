using System;
using System.Collections.Generic;


namespace Collection_initializer
{
    class MainClass
    {
        static void Main()
        {
            List<Person> PersonList=new List<Person>();
            {
                new Person { Name = "sumith" };
                new Person() { Name = "smith", Age = 20 };
            }
            foreach(Person p in PersonList)
            {
                Console.WriteLine("Name={0} Age={1}",p.Name,p.Age);
            }
        }
    }
}
