
 abstract class shapes
{
    public abstract void draw();
}
class Circle : shapes
{
    public override void draw()
    {
        Console.WriteLine("Circle");
    }
}
class Square : shapes
{
    public override void draw()
    {
        Console.WriteLine("Square");
    }
}
class Rectangle : shapes
{
    public override void draw()
    {
        Console.WriteLine("Rectangle");
    }
}
class MainClass
{
    static void Main()
    {
        shapes[] shape = new shapes[3];
        shape[0]=new Circle();
        shape[1]=new Square();
        shape[2]=new Rectangle(); 
        foreach (shapes s in shape)
        {
            s.draw();
        }
    }
   
}
