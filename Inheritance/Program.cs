using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =new Person[3]
            {
               new Customer{FirstName = "sipan" },
               new Student{FirstName = "kaan" },
               new Person{ FirstName = "minnoş"},
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person  //Person2 diye başka bir tane tanımlarsak onlar Customer ve student'a eşit olmaz çünkü bir kişinin bir babası olur.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer :Person //Customer'ın babası Person
    {
        public string City { get; set; }
    }

    class Student :Person  //Student'ın babası Person
    {
        public string Departmant { get; set; }
    }
}

