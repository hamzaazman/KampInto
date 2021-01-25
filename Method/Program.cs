using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            Urun urun2 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Aciklama + " " + urun.Fiyati);
            }

            Console.WriteLine("-----------Metotlar-------------");

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //sepetManager.Ekle2("Armut", "Yeşil Elma", 12);
            //sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 80); 
            //sepetManager.Ekle2("Erik", "Yesil erik", 8);


            Urun urun3 = new Urun();
            urun3.Adi = "Kiraz";
            urun3.Aciklama = "Kırmızı kiraz";
            urun3.stokAdedi = 10;

            sepetManager.Ekle2(urun3);
            sepetManager.StokTakip(urun3);
            

        }

    }
}
