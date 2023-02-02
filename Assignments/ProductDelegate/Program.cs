using System;
using PrintServiceDelegate;
class Product
{
    int prodID;
    string productName;
    public Product(int Prodid, string name)
    {
        this.prodID = Prodid;
        this.productName = name;
    }
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product id: {0}", this.prodID);
        Console.WriteLine("Product Name: {0}", this.productName);
    }
    public void UserService()
    {
        PrintService.Print(Display);
    }
}