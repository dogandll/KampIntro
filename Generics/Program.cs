
using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Van");
            sehirler.Add("istanbul");
            Console.WriteLine(sehirler.Count);

            Mylist<string> sehirler2 = new Mylist<string>();
            sehirler2.Add("istanbul");
            sehirler2.Add("Van");
            sehirler2.Add("İzmir");
            sehirler2.Add("Trabzon");
            sehirler2.Add("Elazığ");
            Console.WriteLine(sehirler2.Count);

        }
    }

    class Mylist<T> //Generic class
    {
        T[] _array;
        T[] _temparray;
        public Mylist()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _temparray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }
            _array[_array.Length - 1] = item;

        }


        public int Count
        {
            get { return _array.Length; }

        }

    }
}
