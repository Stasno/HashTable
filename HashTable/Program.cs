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

            Console.WriteLine("Original value");
            table.Print();

            Random random = new();

            Console.WriteLine("1 Is deleted: " + table.Remove(1));
            table.Print();
            Console.WriteLine("142 Is deleted: " + table.Remove(142));
            table.Print();
            Console.WriteLine("143 Is deleted: " + table.Remove(143));
            table.Print();
            Console.WriteLine("53 Is deleted: " + table.Remove(53));
            table.Print();
            Console.WriteLine("234 Is deleted: " + table.Remove(234));
            table.Print();
            Console.WriteLine("1224 Is deleted: " + table.Remove(1224));
            table.Print();
            Console.WriteLine("1 Is deleted: " + table.Remove(1));
            table.Print();
            Console.WriteLine("53 Is deleted: " + table.Remove(53));
            table.Print();
            Console.WriteLine("2621 Is deleted: " + table.Remove(2621));
            table.Print();

            Dictionary<int, int> pairs;
            Console.WriteLine("Hello World!");
        }
    }
}
