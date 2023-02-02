﻿using EFDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppApi.Models;

namespace WebAppApi.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;
        public ProductRepository()
        {
            Add(new Product { Name = "tomato soup", Category = "Groceries", Price = 1.39M });
            Add(new Product { Name = "yo yo", Category = "Toys", Price = 3.75M });
            Add(new Product { Name = "Hammer", Category = "Hardware", Price = 16.99M });
        }



        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            products.Add(item);
            return item;
        }



        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);
        }



        public IEnumerable<Product> GetAll()
        {
            return products;
        }



        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }



        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentException("item");
            }
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);
            return true;
        }
    }
}