using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım kampı";
            string kurs2 = "programlama kursu";
            string kurs3 = "java kursu";
            string kurs4 = "python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);


            //array - dizi

            string[] kurslar = new string[] {"yazılım kampı","programlama kampı","java kampı","python" };

            for(int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine();
            }

            Console.WriteLine("sayfo sonu - footer");
        }
    }
}

