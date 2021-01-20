using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string UrunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun Urun1 = new Urun();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";


            Urun[] urunler = new Urun[] {Urun1,urun2 };

            foreach (Urun Urun in urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine(Urun.Aciklama);
                Console.WriteLine("--------");
            }


            Console.WriteLine("------------Metotlar-------------");
            //instance-örnek
            //Encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
            sepetManager.Ekle2("Erik", "Yeşil Erik", 3,60);
            sepetManager.Ekle2("Ayva", "Sayrı ayva", 2,90);
          
        }
    }
}
