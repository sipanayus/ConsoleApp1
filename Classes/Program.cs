using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();


            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "kaan";
            customer.LastName = "gül";
            customer.City = "istanbul";
            customer.Id = 1;


            Customer customer2 = new Customer   // bu da alternatif bir kayıt oluşturma şeklidir.
            {
                Id = 2, City = "ankara", FirstName ="sipan",  LastName = "ayus"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }
    
    

  
}
