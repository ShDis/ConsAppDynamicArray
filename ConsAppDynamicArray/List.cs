using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppDynamicArray
{
    public class List<T>
    {
        private T[] array;
        private int count;

        public List()
        {
            array = new T[4];
            count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                array[index] = value;
            }
        }

        public void Add(T item)
        {
            if (count == array.Length)
            {
                ResizeArray();
            }
            array[count] = item;
            count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i], item))
                {
                    RemoveAt(i);
                    break;
                }
            }
        }

        public int Count
        {
            get { return count; }
        }

        private void ResizeArray()
        {
            T[] newArray = new T[array.Length * 2];
            Array.Copy(array, newArray, count);
            array = newArray;
        }
    }
}
