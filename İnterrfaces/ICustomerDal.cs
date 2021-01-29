using System;
using System.Collections.Generic;
using System.Text;

namespace İnterrfaces
{
    interface ICustomerDal // Dal: Veritabanı işlerini kaydeder.
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Delete()
        {
            Console.WriteLine("sql deleted");
        }

        public void Add()
        {
            Console.WriteLine("sql added");
        }

        public void Update()
        {
            Console.WriteLine("sql updated");
        }
    }


    class OracleCustomerDal : ICustomerDal
    {
        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        public void Add()
        {
            Console.WriteLine("oracle addeed");
        }

        public void Update()
        {
            Console.WriteLine("oracle updated");
        }

       
    }

    class MySqlCustomerDal : ICustomerDal
    {
        public void Delete()
        {
            Console.WriteLine("MySql deleted");
        }

        public void Add()
        {
            Console.WriteLine("MySql addeed");
        }

        public void Update()
        {
            Console.WriteLine("MySql updated");
        }


    }


    class CustomerManager
    {
        public void Add(ICustomerDal customerDal )
        {
            customerDal.Add();
        }
    }

}
