using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using WebAppApi.Models;

namespace ProductStoreClient
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50990/");
            var gizmo = new Product() { Name = "Gizmo", Price = 100, Category = "widget" };
            Uri gizmoUri = null;
            HttpResponseMessage response = client.PostAsJsonAsync("api/product", gizmo).Result;
            if (response.IsSuccessStatusCode)
            {
                gizmoUri = response.Headers.Location;
                Console.WriteLine(gizmoUri);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("-----------------------------");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            response = client.GetAsync("api/products/2").Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<Product>().Result;
                Console.WriteLine("{0}\t{1};\t{2}", product.Name, product.Price, product.Category);



            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("---------------------------------");
            response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                foreach (var p in products)
                {
                    Console.WriteLine("{0}\t{1}l\t{2}", p.Name, p.Price, p.Category);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("--------------------------------");
            gizmo.Price = 99.9m;
            response = client.PutAsJsonAsync(gizmoUri.PathAndQuery, gizmo).Result;
            Console.WriteLine("{0} {1}", (int)response.StatusCode, response.ReasonPhrase);
            Console.WriteLine("----------------------------------");
            Console.Write("Enter Product ID to Updtae: ");
            int id = int.Parse(Console.ReadLine());
            response = client.GetAsync("api/products/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var product = response.Content.ReadAsAsync<Product>().Result;
                product.Price = 110;
                response = client.PutAsJsonAsync("api/products/" + id, product).Result;
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            Console.WriteLine("---------------------------------------");
            response = client.DeleteAsync("api/products/6").Result;
            Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            Console.WriteLine("***************************************************");
            response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                var products = response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
                foreach (var p in products)
                {
                    Console.WriteLine("{0}\t{1};\t{2}", p.Name, p.Price, p.Category);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }



    }
}