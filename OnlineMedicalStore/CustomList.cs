using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class CustomList<Type> : IEnumerable,IEnumerator 
    {
        //fields 
        private int _count;
        private int _capacity;
        private Type[] _array;
        //Properties
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        public Type this[int index]{get{return _array[index];}set{_array[index]=value;}}

        //Constructor
        public CustomList(int capacity)
        {
            _capacity=capacity;
            _count=0;
            _array = new Type[_capacity];
        }
        public CustomList()
        {
            _capacity=4;
            _count=0;
            _array=new Type[_capacity];
        }

        //Functionalities
        public void Add(Type T)
        {
            if(_count ==_capacity)
            {
                GrowSize();
            }
            _array[_count]=T;
            _count++;

        }
        //Increase capacity
        public void GrowSize()
        {
            _capacity*=2;
            Type[]temp = new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        
        public void AddRange(CustomList<Type> list)
        {
            _capacity = _count+list.Count+4;
            Type[]temp = new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            for(int i=_count;i<list.Count;i++)
            {
                temp[i] = list[i];
            }
            _count=_count+list.Count;
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
            Reset();
            return false;
        }
        public void Reset()
        {
            position=-1;
        }

        public object Current{get{return _array[position];}}

    }
}