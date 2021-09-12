using System;
using System.Collections.Generic;

namespace DictonarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<int, string> myDictonary = new MyDictonary<int, string>();
            myDictonary.Add(1, "Doğan");
            myDictonary.Add(2, "Uğur");
            myDictonary.Add(3, "Zehra");
            myDictonary.Add(4, "Fatma");
            Console.WriteLine("CountKey :" + myDictonary.CountKey);
            Console.WriteLine("CountValue :" + myDictonary.CountValue);
            Console.WriteLine("Count :" + myDictonary.Count);
        }
    }

    class MyDictonary<Tkey, Tvalue>
    {
        Tkey[] tkeys;
        Tvalue[] tvalues;

        Tkey[] _tempkeys;
        Tvalue[] _tempvalues;

        public MyDictonary()
        {
            tkeys = new Tkey[0];
            tvalues = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            tkeys = new Tkey[tkeys.Length + 1];
            tvalues = new Tvalue[tvalues.Length + 1];

            _tempkeys = tkeys;
            _tempvalues = tvalues;



            for (int i = 0; i < tkeys.Length; i++)
            {
                tvalues[i] = _tempvalues[i];
                tkeys[i] = _tempkeys[i];
            }
            tvalues[tvalues.Length - 1] = value;
            tkeys[tkeys.Length - 1] = key;


        }

        public int Count
        {
            get { return tkeys.Length + tvalues.Length; }
        }
        public int CountKey
        {
            get { return tkeys.Length; }
        }

        public int CountValue
        {
            get { return tvalues.Length; }
        }
    }

}


