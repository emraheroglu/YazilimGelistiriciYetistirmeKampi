using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar_16012020
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.. Sepete Eklendi. : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stok )
        {
            Console.WriteLine("Tebrikler.. Sepete Eklendi. : " + urunAdi);
        }
    }
}
