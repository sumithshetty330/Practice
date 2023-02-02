using System;

class Bike
{
    public void Bikes()
    {
        Console.WriteLine("My bike is Fz 150");
    }
        
}
class BikeModel:Bike
{
    public void Bikemodel()
    {
        Console.WriteLine("My bike model is Fz1502011");
    }

}
class mainClass
{
    static void Main()
    {
         
       
        BikeModel mod=new BikeModel();
        mod.Bikemodel();
        mod.Bikes();            
    }
}