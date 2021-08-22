using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dont repeat yourself - Kendini tekrar etme !

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //Type safe --- tip güvenli   
            foreach (var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyat);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("------------------------------------");

            }
            Console.WriteLine("-----------------Metotlar----------------");
            //Instance - Örnek
            SepetManager manager = new SepetManager();
            foreach (var item in urunler)
            {
                manager.Ekle(item);
            }
 
            Console.ReadKey();

        }
    }
}

