using System;
using System.Collections.Generic;


namespace Object_initializers
{
     class MainClass
    {
        static void Main()
        {
            Person p = new Person { Age = 23, Name = "Sumith", City = "Mangalore" };
            p.Age = 23; p.Name = "smith";
            Console.WriteLine("Age={0},Name={1},City={2}",p.Age,p.Name,p.City);
        }
    }
}
