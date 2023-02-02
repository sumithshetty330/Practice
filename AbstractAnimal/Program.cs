using System;
namespace BrandCars
{
    abstract class BrandCars
    {
        protected static int _order_Number = 1;
        protected double _price;
        protected string _carColor;
        protected bool _horsepower;
        protected int _orderNumber;
        protected double _gst;

        public abstract string OrderDetails();
        public BrandCars(string CarColor, double Price, bool Horsepower)
        {
            _carColor = CarColor;
            _price = Price;
            _horsepower = Horsepower;
            _orderNumber = _order_Number++;
        }
        protected double TotalPrice()
        {
            return _gst + _price;
        }



    }
    class Audi : BrandCars
    {
        public Audi(string CarColor, double Price, bool Horsepower) : base(CarColor, Price, Horsepower)
        {

        }

        public override string OrderDetails()
        {
            _gst = 11223.45;
            TotalPrice();
            return string.Format(" Order Number:{0}\n Color:{1}\n Horse power:{2}\n " +
                "Price(including GST): {3}\n", _orderNumber, _carColor, _horsepower, TotalPrice());
        }



    }
    class Volvo : BrandCars
    {
        public Volvo(string CarColor, double Price, bool Horsepower) : base(CarColor, Price, Horsepower)
        {

        }
        public override string OrderDetails()
        {
            _gst = 44554.98;
            TotalPrice();
            return string.Format(" Order Number:{0}\n Type:{1}\n Contains Sugar:{2}\n " +
                "Price(including GST): {3}\n", _orderNumber, _carColor, _horsepower, TotalPrice());
        }



    }
    class Bentley : BrandCars
    {
        public Bentley(string type, double Price, bool Horsepower) : base(type, Price, Horsepower)
        {

        }
        public override string OrderDetails()
        {
            _gst = 11526.65;
            TotalPrice();
            return string.Format(" Order Number:{0}\n Type:{1}\n Contains Sugar:{2}\n " +
                "Price(including GST): {3}\n", _orderNumber, _carColor, _horsepower, TotalPrice());
        }



    }
    class Jaguar : BrandCars
    {
        public Jaguar(string type, double Price, bool Horsepower) : base(type, Price, Horsepower)
        {

        }
        public override string OrderDetails()
        {
            _gst = 334526.34;

            return string.Format(" Order Number:{0}\n Type:{1}\n Contains Sugar:{2}\n " +
                "Price(including GST): {3}\n", _orderNumber, _carColor, _horsepower, TotalPrice());
        }



    }
    enum CarTypes : byte
    {
        Manual = 1,
        Automatic,
        TDI,
        VXI



    }
    class MainClass
    {
        static int n, counter;
        static BrandCars[] order = new BrandCars[10];
        static string CarColor;
        static float Price;
        static bool Horsepower;
        static void Input()
        {
            Console.WriteLine("Enter the car color:");
            CarColor = Console.ReadLine();
            Console.WriteLine("Its Horse power: ");
            Horsepower = bool.Parse(Console.ReadLine());
            Console.WriteLine("Price: ");
            Price = float.Parse(Console.ReadLine());
        }
        static void PrintAllOrderDetails()
        {
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(order[i].OrderDetails());
            }
        }
        static void Main()
        {

            char choice;

            do
            {
                Console.WriteLine("1. Car Order\n2. Print All OrderDetails\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("types\n 1.Coffee\n 2.Tea\n 3.Energy Drinks\n 4.FruitJuice\n");
                        int opt = int.Parse(Console.ReadLine());
                        switch ((CarTypes)opt)
                        {
                            case CarTypes.Manual:
                                Input();
                                order[counter++] = new Manual(CarColor, Price, Horsepower);
                                break;
                            case CarTypes.Automatic:
                                Input();
                                order[counter++] = new Automatic(CarColor, Price, Horsepower);
                                break;
                            case CarTypes.TDI:
                                Input();
                                order[counter++] = new TDI(CarColor, Price, Horsepower);
                                break;
                            case CarTypes.VXI:
                                Input();
                                order[counter++] = new VXI(CarColor, Price, Horsepower);
                                break;
                        }
                        break;
                    case 2:
                        PrintAllOrderDetails();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter a valid option");
                        break;
                }
                Console.Write("Do you want to continue(Y|N)");
                choice = Console.ReadLine()[0];
            } while (choice == 'Y' || choice == 'y');
        }


    }
}





