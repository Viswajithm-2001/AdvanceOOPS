using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class CustList<T> : IEnumerator,IEnumerable
    {
        private int _capacity;
        private int _count;
        public int Capacity {get{return _capacity;}}
        public int Count {get{return _count;}}
        private T[] _array;
        public T this[int index]{get{return _array[index];} set {_array[index]=value;}}

        public CustList()
        {
            _count=0;
            _capacity=4;
            _array = new T[_capacity];
        }
        public CustList(int size)
        {
            _count=-1;
            _capacity=size;
            _array = new T[_capacity];
        }
        public void Add(T element)//public method for adding
        {
            if(_count ==_capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }

        public void AddRange(CustList<T> elements)
        {
            _capacity = _count+elements.Count+4;
            T[] temp = new T[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            int k=0;
            for(int j=_count;j<elements.Count;j++)
            {
                temp[j] = elements[k];
            }
            _array=temp;
        }    
        void GrowSize()
        {
            _capacity*=2;
            T[]temp = new T[_capacity];
            for(int i=0;i<_array.Length;i++)
            {
                temp[i]=_array[i];
            }
            _array = temp;
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            return false;
        }
        public void Reset()
        {
            position = -1;
        }
        public object Current{get{return _array[position];}}

    }
}