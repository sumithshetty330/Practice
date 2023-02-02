
using System;
namespace Anonymous_Types
{
    class MainClass
    {
        static void Main()
        {
            var animal = new { Name = "Sumith", Age = 20 };//Anonymous Type is created
            //animal.Name = "Karthik";//Not Allowed Because anonymous Types create read only property
            Console.WriteLine("Name :{0}, Age {1}", animal.Name, animal.Age);

            var a = animal;//Anonymous Type are reference types that derive directly from object.
            Console.WriteLine("Name :{0}, Age {1}", a.Name, a.Age);

            var ani = new { Name = "Sumith", Age = 20 };

            if (a.Equals(ani))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }/*Because the equals and getHashCode methods on anonymous types are defined in terms of the
                equals and gethashcode of the properties,two instances of the same anonymous type are equal
                only if all their properties are equal.*/
            if (object.ReferenceEquals(a, ani))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("Different");
            }
        }
    }
}

