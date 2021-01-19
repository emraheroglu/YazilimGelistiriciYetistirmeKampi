using System;

namespace classIntro_13012020
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Emrah Eroğlu";
            int yas = 23;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 78;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "JAVA";
            kurs2.Egitmen = "Emrah Eroğlu";
            kurs2.IzlenmeOrani = 67;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Ali Muhammed";
            kurs3.IzlenmeOrani = 62;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Muhammet Ali";
            kurs4.IzlenmeOrani = 87;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + " , %" + kurs1.IzlenmeOrani);
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi +" : "+ kurs.Egitmen +" , %"+ kurs.IzlenmeOrani +" tamamlandı.");
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
