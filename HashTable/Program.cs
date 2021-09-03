using System;
using System.Collections.Generic;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<int, int> table = new();
            table.Add(1, 3);
            table.Add(142, 3);
            table.Add(242, 3);
            table.Add(234, 3);
            table.Add(1224, 3);
            table.Add(143, 3);
            table.Add(53, 3);
            table.Add(23, 3);
            table.Add(124, 3);
            table.Add(53, 3);
            table.Add(1, 3);
            table.Add(1, 3);
            table.Add(234, 3);
            table.Add(234, 3);

            Random random = new();

            Console.WriteLine(table.Remove(1));
            table.Print();
            Console.WriteLine(table.Remove(142));
            table.Print();
            Console.WriteLine(table.Remove(143));
            table.Print();
            Console.WriteLine(table.Remove(53));
            table.Print();
            Console.WriteLine(table.Remove(234));
            table.Print();
            Console.WriteLine(table.Remove(1224));
            table.Print();
            Console.WriteLine(table.Remove(1));
            table.Print();
            Console.WriteLine(table.Remove(53));
            table.Print();
            Console.WriteLine(table.Remove(2621));
            table.Print();

            Dictionary<int, int> pairs;
            Console.WriteLine("Hello World!");
        }
    }
}
