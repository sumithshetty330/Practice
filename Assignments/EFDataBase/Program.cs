using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFDataBase
{
    class MainClass
    {
        static NorthwindEntities1 NWEntities=new NorthwindEntities1();
        static IEnumerable<Product> beverages;
        static void SelectProducts()
        {
            beverages=from p in NWEntities.Products
                      where p.Category.CategoryName=="Beverages"
                      orderby p.ProductName
                      select p;
            foreach(Product p in beverages)
            {
                Console.WriteLine(p.ProductName);
            }
            Console.WriteLine("Total No of Products: "+ beverages.Count());
            Console.WriteLine("******************************************");
        }
        static void SelectOrder_Details()
        {
            var pro = from od in NWEntities.Order_Details
                      where od.Product.ProductID == 11
                      select od;
            foreach(Order_Detail o in pro)
            {
                Console.WriteLine(o.OrderID);
            }
            Console.WriteLine("Total Number: "+pro.Count());
            Console.WriteLine("******************************************");
        }
        static void AddProduct()
        {
            Product newproduct = new Product { ProductName = "new test product" };
            NWEntities.Products.Add(newproduct);
            NWEntities.SaveChanges();
            Console.WriteLine("Added a new product with name 'new test product'");
        }
        static void UpdateProduct()
        {
            //update a product
            Product bev1=beverages.ElementAtOrDefault(10);
            Console.WriteLine(bev1.ProductName);
            if (bev1 != null)
            {
                decimal newPrice = (decimal)bev1.UnitPrice + 10.00m;
                Console.WriteLine("the price of {0} is {1}. Update to {2}",bev1.ProductName,bev1.UnitPrice,newPrice);
                bev1.UnitPrice = newPrice;
                //submit the change to database
                NWEntities.SaveChanges();
            }
        }
        static void DeleteProduct()
        {
         
            IQueryable<Product> ProductsToDelete = from p in NWEntities.Products
                                                  
                                                   where p.ProductName == "new test product"
                                                       select p;

            if (ProductsToDelete.Count() > 0)
            {
                foreach (var p in ProductsToDelete)
                {
                    NWEntities.Entry(p).State = System.Data.Entity.EntityState.Deleted;
                    Console.WriteLine("Delete Product {0}", p.ProductID);
                }
                NWEntities.SaveChanges();






            }
        }
        static void JoiningTwoTable()
        {
            var CategoryProducts = from c in NWEntities.Categories
                                   join p in NWEntities.Products
                                 on c.CategoryID equals p.CategoryID
                                 into productsByCategory
                                   select new
                                   {
                                       c.CategoryName,
                                       productCount = productsByCategory.Count()
                                   };
            foreach (var cp in CategoryProducts)
            {
                Console.WriteLine("there are {0} products in category {1}", cp.productCount, cp.CategoryName);
            }
            Console.WriteLine("**********************************");
            var currentProducts = from p in NWEntities.Products
                                  select p;
            foreach (var p in currentProducts)
            {
                Console.WriteLine("Product ID: {0} Product Name: {1}", p.ProductID, p.ProductName);
            }
        }
        static void Main()
        {
            SelectProducts();
            SelectOrder_Details();
            AddProduct();
            UpdateProduct();
            DeleteProduct();
            JoiningTwoTable();
        }

    }
}
