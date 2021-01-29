using System;

namespace İnterrfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

        }
            private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "sipan",
                LastName = "ayus",
                Address = "diyarbakır"

            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "kaan",
                LastName = "gül",
                Departmant = "Computer Sciences",

            };
            manager.Add(customer);
            manager.Add(student);
            //manager.Add(new Customer{Id = 1, FirstName = "sipan", LastName = "ayus", Address = "diyarbakır",});   //Bu satırdaki gibi kişi tanımlanabilir.Yazım şekli denir buna
        }
    }
    interface IPerson //temel nesne oluşturup tüm nesneleri ondan implemente etmektir amaç //interface soyut nesneler
    {
        int Id { get; set; }  //interface'ler için sadece methodun imzası kullanıllır.
        string FirstName { get; set; } //interface'ler her iki classında ortak özelliğini tutar(IPerson dediğimiz için) bunlar (Id,FirstName,LastName)
        string LastName { get; set; }
    }


    class Customer:IPerson //classlar somut nesneler
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; } //müşteriye ait <yrıca özellik
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; } //öğrenciye ait  ayrıca özellik
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}

