using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{


    class CustomerManager
    {
        public void Add(ICustomerDAL customerDAL)
        {
            customerDAL.Add();
        }
    }

    interface ICustomerDAL
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDAL : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Deleted");
        }

        public void Update()
        {
            Console.WriteLine("SQL Updated");
        }
    }

    class OracleCustomerDAL : ICustomerDAL
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
           Console.WriteLine("Oracle Updated");
        }
    }
}
