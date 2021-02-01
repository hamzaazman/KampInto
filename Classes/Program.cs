using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Classlarla operasyonlarımızı grupluyoruz.*/
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Hamza";
            customer.LastName = "Azman";
            customer.City = "Kdz Ereğli";
            customer.Id = 1;

            Customer customer2 = new Customer 
            {
                Id = 2, City = "Ankara", FirstName = "Lorem", LastName = "Ipsum"
            };

            Console.WriteLine(customer2.FirstName);

        }
    }

}
