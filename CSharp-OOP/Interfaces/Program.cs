using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // İnterface`ler  genel olarak servis implementasyonlarında ve katmanlar arası geçişler zamanı kullanılır.
    class Program
    {
        static void Main(string[] args)
        {
            // Example1();
            //  Example2();

            Console.ReadLine();
        }

        private static void Example2()
        {
            CustomerManager customer = new CustomerManager();
            customer.Add(new SqlServerCustomerDAL());
            customer.Add(new OracleCustomerDAL());
        }

        private static void Example1()
        {
            CustomManager customManager = new CustomManager();
            customManager.Add(new Customer { Id = 1, Name = "Farid", Surname = "Maharramov" });
            customManager.Add(new Student { Id = 1, Name = "Nur", Surname = "İsmayılova" });
        }
    }
    // İnterface`ler soyut nesnelerdir, tek başına bhiç bir anlam ifade etmez
    interface IPerson
    {
        int Id { get; set; }

        string Name { get; set; }

        string Surname { get; set; }
    }
    // Class`lar ise somut nesnelerdir
    class Customer : IPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }

    class CustomManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Customer " + person.Name + " Added");
        }
    }
}
