using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya Başlangıç İçin Temel Kurs" ,"Java","Python","C#"};


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti.");

            foreach (string kurs in kurslar)
                // foreach = DİZİ TEMELLİ YAPILARI TEK TEK DÖNMEYE(DOLAŞMAYA) YARAR !
                // foreach dizilere uygulanır.
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu-footer");
        }
    }
}
