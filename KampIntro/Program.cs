using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //do not repeat yourself
            double dolarDun = 7.55;
            double dolarBugun = 7.10;
           

            if (dolarDun>dolarBugun){
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun){
                Console.WriteLine("Artış butonu");
            }
            else{
                Console.WriteLine("Değişiklik yok butonu");
            }


        }
    }
}
