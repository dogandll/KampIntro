﻿using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(4, 5);
            dortIslem.Topla(5, 6);
            Console.ReadKey();
        }
    }
}