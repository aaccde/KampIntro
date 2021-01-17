using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Muz";
            urun2.Fiyati = 18;
            urun2.Aciklama = "Antalya muzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)     //var yerine Urun kullanılabilir.
            {
                Console.WriteLine("Ürün Adı:" + urun.Adi);
                Console.WriteLine("Ürün Fiyatı:" + urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması:" + urun.Aciklama);
                Console.WriteLine("-----------"); 
            }
            Console.WriteLine("----------------METOTLAR--------------");
            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
      
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,35);
            sepetManager.Ekle2("Üzüm", "Kara üzüm", 18,40);
            sepetManager.Ekle2("Kavun", "Sarı Kavun", 14,45);
        }
    }
}



//Dont repeat yourself - DRY - Clean Code - Best Practice