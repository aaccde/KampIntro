using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ali Demir";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Aslı Şahin";
            kurs2.IzlenmeOranı = 18;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Kerem Taş";
            kurs3.IzlenmeOranı = 100;


            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" : "+ kurs.Egitmen);
            }

  

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
