using System;
using System.Collections.Generic;
using System.Text;

namespace Method
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void StokTakip(Urun urun)
        {
            Console.WriteLine("Urunun Stok Adedi : " + urun.stokAdedi);
        }
    } 
}
