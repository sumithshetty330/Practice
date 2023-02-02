using System;
namespace interface_abstractClass
{
    interface Interface1
    {
        void M();void N();
    }
    abstract class Class : Interface1
    {
        void Interface1.M()
        {
            Console.WriteLine("Interface");
        }
    public abstract void N();}
}
class class2: