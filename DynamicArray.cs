using System;

namespace Task1_Collection1
{
    public class DynamicArray
    {

        public int Length { get; private set; }
        public int Capacity { get; private set; }

        public int Indexator(int i)
        {
            try
            {
                return Arr[i];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        int[] Arr;


        public DynamicArray()
        {

            Arr = new int[8];
            Length = 0;
            Capacity = 8;

        }

        public DynamicArray(int Count)
        {

            Arr = new int[Count];
            Length = 0;
            Capacity = Count;

        }

        public DynamicArray(int[] array)
        {
            Arr = new int[array.Length];
            Length = 0;
            Capacity = array.Length;
        }

        public void Add(int x)
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

                int[] tempArr = new int[tempCap];
                for (int i = 0; i < tempCap; i++)
                {
                    tempArr[i] = Arr[i];
                }

                Arr = new int[Capacity];
                for (int i = 0; i < tempCap; i++)
                {
                    Arr[i] = tempArr[i];
                }
                Arr[Length] = x;
                Length++;
            }


        }

        public void AddRange(int[] arr)
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

                int[] tempArr = new int[tempCap];
                for (int i = 0; i < tempCap; i++)
                {
                    tempArr[i] = Arr[i];
                }

                Arr = new int[Capacity];
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
                for (; p < Length; p++)
                {
                    Arr[p - 1] = Arr[p];
                    Arr[p] = 0;
                }
                Length--;
                res = true;
            }
            else if (p == Length)
            {
                Arr[p - 1] = 0;
                Length--;
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }

        public void Insert(int x, int p)
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

                    int[] tempArr = new int[tempCap];
                    for (int i = 0; i < tempCap; i++)
                    {
                        tempArr[i] = Arr[i];
                    }


                    Arr = new int[Capacity];
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

    }
}
