using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax yazım farkları 
        public void Ekle()
        {
            Console.WriteLine("sepete eklendi " );
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi) //encapsulation düzenleme
        {
            Console.WriteLine("sepete eklendi : " + urunAdi);
        }
    }
}
