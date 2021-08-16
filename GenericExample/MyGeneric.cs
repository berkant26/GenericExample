using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{
    class MyGeneric<T>
    {
        T[] _tempArray;
        T[] _array;
        public MyGeneric()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {

            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];

            }

            _array[_array.Length - 1] = item;


            Console.WriteLine("Added ctiy :"+" "+item);
        }

        public int Count        
        {
            get { return _array.Length; }
        }

    }
}
