using System;

namespace Metotlar_16012020
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";            

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler) // Urun = veri tipi , urun = değişken , urunler = gezilecek yer
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("\n--------------------METOTLAR--------------------\n");
            //instance
            //encapsulation 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut", 12 , 10);
            sepetManager.Ekle2("Elma", "Kırmızı elma", 12 , 11);
            sepetManager.Ekle2("Karpuz", "Dişi karpuz", 12 , 12);


        }
    }
}
//Do not repeat yourself.!