using System;

class Bike
{
    public void Bikes()
    {
        Console.WriteLine("My bike is Fz 150");
    }
    protected void Kanthara()
    {
        Console.WriteLine("ondu Danthakathe");
    }

}
class BikeModel : Bike
{
    public void Bikemodel()
    {
        base.Kantara();    
        Console.WriteLine("My bike model is Fz1502011");
    }
    

}
class mainClass
{
    static void Main()
    {


        BikeModel mod = new BikeModel();
        mod.Bikemodel();
        mod.Bikes();
    }
}