using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServerDatabase sqlServerDatabase = new SqlServerDatabase();
            sqlServerDatabase.Add();
            MysqlDatabase mysqlDatabase = new MysqlDatabase();
            mysqlDatabase.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by defaul");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServerDatabase : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql");
          //  base.Add();
        }
    }
    class MysqlDatabase : Database
    {

    }
}
