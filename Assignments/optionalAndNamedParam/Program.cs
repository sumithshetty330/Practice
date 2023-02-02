using System;
using System.Collections;
namespace OptionalAndNamed
{
    class MainClass
    {
        public static void M(String name,bool b=false,ArrayList myList = null)
        {
            Console.WriteLine(name+" ");
            Console.WriteLine(b);
        }
        static void Main()
        {
            M("sumith");
            M("shetty", true);
            M("Deepak", true, new ArrayList());
            //process("Sumith',new ArrayList());//invalid

            M("Mahal", myList: new ArrayList());
            M("Ritz", myList: new ArrayList(),b:true);  //valid but silly
        }
    }
}