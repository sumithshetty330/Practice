using System;
interface InFace
{
    void draw();//Interface members are implicitly public
}
class  Circle : InFace
{
    public void draw()
    {
        Console.WriteLine("Circle");
    }
}
class Square : InFace
{
    public void draw()
    {
        Console.WriteLine("Square");
    }
}
class Rectangle : InFace
{
    public void draw()
    {
        Console.WriteLine("Rectangle");
    }
}
class MainClass
{
    static void Main()
    {
        InFace[] inter = new InFace[3];
        inter[0]=new Circle();
        inter[1]=new Square();  
        inter[2]=new Rectangle();   
        foreach (InFace face in inter)
        {
            face.draw();    
        }
    }
}