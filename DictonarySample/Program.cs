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
            Console.WriteLine(myDictonary);
        }
    }

    public class MyDictonary<Tkey, Tvalue>
    {
        Tkey[] tkeys;
        Tkey[] _tempkeys;
        Tvalue[] tvalues;
        Tvalue[] _tempvalues;
        public MyDictonary()
        {
            tkeys = new Tkey[0];
            tvalues = new Tvalue[0];
        }

        public void Add(Tkey key, Tvalue value)
        {
            _tempkeys = tkeys;
            _tempvalues = tvalues;
            tkeys = new Tkey[tkeys.Length + 1];
            tvalues = new Tvalue[tvalues.Length + 1];
            for (int i = 0; i < tkeys.Length; i++)
            {
                _tempkeys[i] = tkeys[i];
                _tempvalues[i] = tvalues[i];
            }
            tkeys[tkeys.Length - 1] = key;
            tvalues[tvalues.Length - 1] = value;

        }
    }
}


