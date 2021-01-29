using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyatı = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            // type safe tip güvenlidir c# ve java(Çalışacağı veriyi bilmek ister)
            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("........metotlar........");
            //instance - örnek
            //encapsulation - kapsülleme

            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle();

            sepetManager.Ekle2("armut", "yeşil armut", 12,10);
            sepetManager.Ekle2("elma", "yeşil elma", 25,45);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,56);


        }
    }
}
