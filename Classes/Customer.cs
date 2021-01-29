using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {    //Property(özellikleri)
        public int Id { get; set; }   //'public string FirstName dersek'(field değişken tanımlamış oluruz)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
