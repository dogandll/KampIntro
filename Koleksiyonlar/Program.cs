using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();
            isimler.Add("Doğan");
            isimler.Add("Baran");
            isimler.Add("Yusuf");
            isimler.Add("Uğur");
            isimler.Add("Eray");
            isimler.Add("Apo");

            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}