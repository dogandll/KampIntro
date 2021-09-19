using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //interface implement eden sınıfı referans olarak tutabilir.

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);

        }
    }
}
