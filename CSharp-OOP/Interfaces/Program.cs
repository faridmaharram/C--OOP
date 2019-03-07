using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
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
    class Customer
    {

    }

    class Student
    {

    }
}
