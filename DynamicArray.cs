using System;

namespace Task1_Collection1
{
    public class DynamicArray
    {

        // Length - колличество записаных объектов в массиве
        public int Length { get; private set; }

        //Capacity - емкость всего массива
        public int Capacity { get; private set; }

        object[] Arr;

        //Индексатор
        public object this[int i]
        {
            get { return Arr[i]; }
            set { Arr[i] = value; }
        }


        public DynamicArray()
        {

            Arr = new object[8];
            Length = 0;
            Capacity = 8;

        }

        public DynamicArray(int Count)
        {

            Arr = new object[Count];
            Length = 0;
            Capacity = Count;

        }

        public DynamicArray(object[] array)
        {
            Arr = new object[array.Length];
            Length = 0;
            Capacity = array.Length;
        }

        public void Add(object x)
        {
            if (Capacity > Length)
            {
                Arr[Length] = x;
                Length++;
            }
            else
            {
                int tempCap = Capacity;
                Capacity = Capacity * 2;

                object[] tempArr = new object[tempCap];
                for (int i = 0; i < tempCap; i++)
                {
                    tempArr[i] = Arr[i];
                }

                Arr = new object[Capacity];
                for (int i = 0; i < tempCap; i++)
                {
                    Arr[i] = tempArr[i];
                }
                Arr[Length] = x;
                Length++;
            }


        }

        public void AddRange(object[] arr)
        {
            int length = arr.Length;
            if (Capacity - Length > length)
            {
                for (int i = 0; i < length; i++)
                {
                    Arr[Length] = arr[i];
                    Length++;
                }
            }
            else
            {
                int tempCap = Capacity;
                for (; Capacity - Length < length;)
                {
                    Capacity = Capacity * 2;
                }

                object[] tempArr = new object[tempCap];
                for (int i = 0; i < tempCap; i++)
                {
                    tempArr[i] = Arr[i];
                }

                Arr = new object[Capacity];
                for (int i = 0; i < tempCap; i++)
                {
                    Arr[i] = tempArr[i];
                }

                for (int i = 0; i < length; i++)
                {
                    Arr[Length] = arr[i];
                    Length++;
                }
            }


        }

        public bool Remove(int p)
        {
            bool res;
            if (p < Length)
            {
                for (; p < Length - 1; p++)
                {
                    Arr[p] = Arr[p + 1];
                }
                Length--;
                res = true;
            }
            else if (p == Length)
            {
                Length--;
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        public void Insert(object x, int p)
        {
            try
            {

                if (Capacity > Length)
                {
                    for (int i = Length; i > p - 1; i--)
                    {
                        Arr[i] = Arr[i - 1];
                    }
                    Arr[p - 1] = x;
                    Length++;
                }
                else
                {
                    int tempCap = Capacity;
                    Capacity = Capacity * 2;

                    object[] tempArr = new object[tempCap];
                    for (int i = 0; i < tempCap; i++)
                    {
                        tempArr[i] = Arr[i];
                    }


                    Arr = new object[Capacity];
                    for (int i = 0; i < p - 1; i++)
                    {
                        Arr[i] = tempArr[i];
                    }
                    Arr[p - 1] = x;
                    for (int i = p; i < Length + 1; i++)
                    {
                        Arr[i] = tempArr[i - 1];
                    }
                    Length++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        /* public void Filter(object x)
         {
             for (int i = 0; i < Length; i++)
             {
                 if (Arr[i] != x)
                 {
                     Remove(i);
                    i--;
                     
                 }
             }
         }*/


       /* public delegate object Filter(object x);

        public static void DelegateRemove(object[] arr, int p)
        {
            bool res;
            if (p < arr.Length)
            {
                for (; p < arr.Length - 1; p++)
                {
                    arr[p] = arr[p + 1];
                }
            }
            else if (p == arr.Length)
            {
                arr[p - 1] = 0;                
            }
            else
            {
                res = false;
            }
         }

        Filter fil = DelegateRemove;

        */

    }
}
