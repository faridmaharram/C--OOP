using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        //Bir sınıf,içerisinde o sınıfile ilgili metotları barındırır
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            customerManager.Delete();


            // 1. şelikde değer atama
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Farid";
            customer.Surname = "Maharramov";


            // 2. şekilde değer atama
            Customer customer2 = new Customer()
            {
                Id = 2,
                Name = "Hummat",
                Surname = "Maharramov"
            };

            Console.WriteLine(customer.Name+" ve "+customer2.Name);


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void Update()
        {
            Console.WriteLine("Updated");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
}
