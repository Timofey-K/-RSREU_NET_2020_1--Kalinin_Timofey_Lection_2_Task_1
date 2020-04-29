using System;

namespace Task1_Collection1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //----------------------------------------------------------------------------------------------------------------------------
            DynamicArray<int> A1 = new DynamicArray<int>();

            A1.Add(7);
            A1.Add(1);
            A1.Add(3);
            A1.Add(3);
            A1.Add(6);
            A1.Add(5);
            A1.Add(4);
            A1.Add(0);

            /*
                        for (int i = 0; i < A1.Length; i++)
                        {
                            Console.WriteLine(A1[i]);
                        }
                        Console.WriteLine("--------------------------------");

                        int[] A2 = { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                        A1.AddRange(A2);

                        for (int i = 0; i < A1.Length; i++)
                        {
                            Console.WriteLine(A1[i]);
                        }
                        Console.WriteLine("--------------------------------");

                        bool r1 = A1.Remove(3);
                        bool r2 = A1.Remove(5);
                        bool r3 = A1.Remove(10);

                        for (int i = 0; i < A1.Length; i++)
                        {
                            Console.WriteLine(A1[i]);
                        }
                        Console.WriteLine("r1 = " + r1);
                        Console.WriteLine("r2 = " + r2);
                        Console.WriteLine("r3 = " + r3);
                        Console.WriteLine("--------------------------------");

                        A1.Insert(100, 0);
                        A1.Insert(200, 5);
                        A1.Insert(300, 10);

                        for (int i = 0; i < A1.Length; i++)
                        {
                            Console.WriteLine(A1[i]);
                        }
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("Length = " + A1.Length);
                        Console.WriteLine("Capacity = " + A1.Capacity);

                        Console.WriteLine("--------------------------------");
                        //---------------------------------------------------------------------------------------------------------------------------
                        // Task 2
                       */ //---------------------------------------------------------------------------------------------------------------------------
/*
            A1.Filter((x) => x == 5);
            //A1.Filter(MyFilter);
            for (int i = 0; i < A1.Length; i++)
            {
                Console.WriteLine(A1[i]);
            }
            Console.WriteLine("--------------------------------");
*/
/*

            A1.Sort((x, y) => x - y );

            for (int i = 0; i < A1.Length; i++)
            {
                Console.WriteLine(A1[i]);
            }
            Console.WriteLine("--------------------------------");
*/




        }
/*
        public static bool MyFilter(int el)
        {
            return el >= 3;
        }
*/

    }
}