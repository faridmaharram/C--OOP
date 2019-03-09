using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        //Bir sınıf birden fazla sınıfı mireas alamaz, ama birden fazla interface alabilir
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person{ Name="Farid" },
                new Customer{ Name="Maksat"},
                new Student{Name="Nur"}
            };


            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
            Console.ReadLine();
        }
    }


    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }

    class Customer : Person
    {

    }

    class Student : Person
    {

    }
}
