using System;

namespace myProject1_13012020
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety : tip güvenliği
            // do not repeat your self : kendini tekrar etme ulan
            string kategoriEtiketi = "Kategori";
            Console.WriteLine("********************************");
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine("********************************");
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine("********************************");

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı verileri bulundu.");
            }
            else
            {
                Console.WriteLine("Giriş yapınız.");
            }
            Console.WriteLine("********************************");
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış oku..");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku..");
            }
            else
            {
                Console.WriteLine("Eşit çizgisi..");
            }
            Console.WriteLine("********************************");
            // array : dizi
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Yazılım için Temel Kurs";
            string kurs3 = "Yazılım JAVA Kursu";
            string kurs4 = "Yazılım PYTHON Kursu";

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", 
                "Yazılım için Temel Kurs",
                "Yazılım JAVA Kursu",
                "Yazılım PYTHON Kursu",
                "Yazılım C# Kursu"};
            for (int i=0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("********************************");
            for (int i = 1; i <= 5; i+=2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("********************************");
            foreach (string kurs in kurslar)  //kurslar ı dolaş , foreach dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            Console.WriteLine("********************************");
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
                i += 1;
            }
        }
    }
}
