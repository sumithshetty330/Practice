using System;
using System.Collections;
namespace Object_initializers
{
    class Person
    {
        //Auto Implemented Properties
        public int Age { get; set; }
        public string Name { get; set; }
        public String City;
        public Person()
        {
            Console.WriteLine("Default");
        }
    }
}