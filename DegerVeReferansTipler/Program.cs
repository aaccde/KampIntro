using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Deger Tip (int,decimal,float,double,bool)
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine("sayı1=" + sayi1);
            //sayi1 = 30
            //sayi2 = 65
            
            //Referans Tip(array,class,interface)
            //new:bellekten bir adres oluştur.
            //heap:yeni bir yer oluştur.
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999
            Console.WriteLine("sayılar 1=" + sayilar1[0]);


        }
    }
}
