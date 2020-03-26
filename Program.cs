using System;

namespace Task1_Collection1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------------");
            DynamicArray A1 = new DynamicArray();

            A1.Add(1);
            A1.Add(2);
            A1.Add(3);
            A1.Add(4);
            A1.Add(5);

            for (int i = 0; i < A1.Length; i++)
            {
                Console.WriteLine(A1.Indexator(i));
            }
            Console.WriteLine("--------------------------------");


            A1.Insert(6, 1);
            A1.Insert(7, 5);
            A1.Insert(8, 8);

            for (int i = 0; i < A1.Length; i++)
            {
                Console.WriteLine(A1.Indexator(i));
            }
            Console.WriteLine("--------------------------------");

            bool r1 = A1.Remove(3);
            bool r2 = A1.Remove(6);
            bool r3 = A1.Remove(10);

            for (int i = 0; i < A1.Length; i++)
            {
                Console.WriteLine(A1.Indexator(i));
            }
            Console.WriteLine("r1 = " + r1);
            Console.WriteLine("r2 = " + r2);
            Console.WriteLine("r3 = " + r3);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Length = " + A1.Length);
            Console.WriteLine("Capacity = " + A1.Capacity);

        }
    }
}
