using System;


class Bike
{
     public  virtual void Bikes()
    {
        Console.WriteLine("My bike is Fz 150");
    }

    public virtual void Bikemodel()
    {
        Console.WriteLine("My bike model is Fz1502011");
    }

}
class BikeModel : Bike
{
    public new void Bikes()
    {
        Console.WriteLine("My bike is Fz 150");
    }
    public override void Bikemodel()
    {

        Console.WriteLine("My bike model is Fz1502011");
    }
}

    class mainClass
    {
        static void Main()
        {
        Bike model = new BikeModel(); 
        model.Bikes();
        model.Bikemodel();
                   
        }
    }
    




