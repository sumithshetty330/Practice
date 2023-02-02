using System;
class MainClass
{
    public static void Main()
    {
        double Celsius;
        double fahrenheit = 100;
        Console.WriteLine("Fahrenheit is: " + fahrenheit);
        Celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine("Celsius is: " + Celsius);
    }
}