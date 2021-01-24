using System;

namespace GenericsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> urunler = new MyDictionary<string>();
            urunler.Add("Laptop");
            urunler.Add("Tv Ünitesi");
            Console.Write("Toplamda " + urunler.Count + " adet ürün bulunmaktadır.\n");
            foreach (var urun in urunler.Urunler)
            {
                Console.WriteLine(urun);
            }
            

        }
    }
}
