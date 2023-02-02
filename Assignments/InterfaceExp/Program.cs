
using System;
 
interface IOne
{
    public void MethodOne();
}

interface ITwo
{
    public void MethodTwo();
}

interface IThree
{
    public void MethodThree();
}

interface IFour
{
    public void MethodFour();
}

abstract class ClassOne : IThree,IOne,ITwo
{
    public void MethodOne()
    {
        throw new NotImplementedException();
    }

    public void MethodThree()
    {
        Console.WriteLine("Interface MethodThree Calling");
    }

    public void MethodTwo()
    {
        throw new NotImplementedException();
    }
}

class ClassTwo : ClassOne, IFour
{
    public void MethodFour()
    {
        Console.WriteLine("Interface MethodFour Calling");
    }
}

class MainClass
{
    static void Main()
    {
        ClassTwo classTwo = new ClassTwo();
        classTwo.MethodThree();
        classTwo.MethodFour();

    }
}

