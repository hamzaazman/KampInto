using System;
using System.Collections.Generic;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1, CategoryName= "Bilgisayar"},
                new Category{CategoryId = 2, CategoryName= "Telefon"},
            };
            List<Product> products = new List<Product>
            {
                new Product{ProductId = 1, CategoryId=1,ProductName ="Acer Laptop",QuantitiyPerUnit="32 GB Ram", UnitInStock=5,UnitPrice=10000},
                new Product{ProductId = 2, CategoryId=1,ProductName ="Lenova Laptop",QuantitiyPerUnit="16 GB Ram", UnitInStock=2,UnitPrice=8000},
                new Product{ProductId = 3, CategoryId=2,ProductName ="Samsung Telefon",QuantitiyPerUnit="4 GB Ram", UnitInStock=5,UnitPrice=3500}
            };
            Console.WriteLine("Linq------------");
           
        }
     
    }
}
