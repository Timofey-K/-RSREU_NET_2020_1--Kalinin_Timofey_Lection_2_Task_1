using System;

namespace Task1_Collection1
{
    public class DynamicArray<T>
    {
        // Task 1
        //------------------------------------------------------------------------------------------------------------------------------
        // Length - колличество записаных объектов в массиве
        public int Length { get; private set; }

        //Capacity - емкость всего массива
        public int Capacity { get; private set; }

        T[] Arr;

        //Индексатор
        public T this[int i]
        {
            get
            {
                if (i < Length && i >= 0)
                {
                    return Arr[i];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }
            set { Arr[i] = value; }
        }

        public DynamicArray()
        {

            Arr = new T[8];
            Length = 0;
            Capacity = 8;

        }

        public DynamicArray(int Count)
        {

            Arr = new T[Count];
            Length = 0;
            Capacity = Count;

        }

        public DynamicArray(T[] array)
        {
            Arr = new T[array.Length];
            Length = 0;
            Capacity = array.Length;
        }

        public void Add(T x)
        {
            if (Capacity > Length)
            {
                Arr[Length] = x;
                Length++;
            }
            else
            {
                ExtendArr();
                Add(x);
            }
        }

        public void AddRange(T[] array)
        {
            int length = array.Length;
            if (Capacity - Length > length)
            {
                array.CopyTo(Arr, Length);
                Length += length;
            }
            else
            {
                ExtendArr();
                AddRange(array);
            }
        }

        public bool Remove(T x)
        {
            bool res = false;

            int index = Array.IndexOf(Arr, x);
            if (index >= 0)
            {
                Length--;
                for (int i = index; i < Length; i++)
                {
                    Arr[i] = Arr[i + 1];
                }
                res = true;
            }
            return res;
        }

        public void Insert(T x, int p)
        {
            if (p > Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if (Capacity <= Length)
            {
                ExtendArr();
                Insert(x, p);
            }
            else
            {
                for (int i = Length; i > p; i--)
                {
                    Arr[i] = Arr[i - 1];
                }
                Arr[p] = x;
                Length++;
            }
        }

        private void ExtendArr()
        {
            T[] tempArr = new T[Capacity];
            Arr.CopyTo(tempArr, 0);
            Capacity = Capacity * 2;
            Arr = new T[Capacity];
            tempArr.CopyTo(Arr, 0);
        }

        //------------------------------------------------------------------------------------------------------------------------
        // Task 2
        //------------------------------------------------------------------------------------------------------------------------

        public void Filter(Func<T, bool> filter)
        {
            for (int i = 0; i < Length; i++)
            {
                if (filter(Arr[i]) == false)
                {
                    bool r = Remove(Arr[i]);
                    if (r == true) { i--; }                    
                }
            }
        }

        public void Sort(Func<T, T, int> compare) 
        {
            for( int j = 1; j< Length; j++)
            {
                for(int i = 0; i < Length - j; i++)
                {
                    if (compare(Arr[i], Arr[i+1]) > 0)
                    {
                        T temp = Arr[i];
                        Arr[i] = Arr[i + 1];
                        Arr[i + 1] = temp;
                    }
                }
            }
        }




    }
}
