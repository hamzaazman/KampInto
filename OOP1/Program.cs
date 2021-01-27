using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Masa";
            product1.Id = 1;
            product1.CategoryId = 3;
            product1.UnitPrice = 60;
            product1.UnitInStock = 10;

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);




        }
    }
}
