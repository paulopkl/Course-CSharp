using Course.HashAndSorted.Entities;
using System;
using System.Collections.Generic;

namespace Course.HashAndSorted
{
    class HashAndSortedProgram
    {
        public HashAndSortedProgram()
        {
            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set);
            //Console.WriteLine(set.Contains("Computer"));

            //foreach (string p in set)
            //{
            //    Console.WriteLine(p);
            //}

            //SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            //SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //SortedSet<string> c = new SortedSet<string>() { "Paulo", "Maria", "Batata" };

            //// Union
            //SortedSet<int> d = new SortedSet<int>(a);
            //d.UnionWith(b);

            //PrintCollection(d);

            //// Intersection
            //SortedSet<int> e = new SortedSet<int>(a);
            //e.IntersectWith(b);

            //PrintCollection(a);
            //PrintCollection(b);
            //PrintCollection(e);

            HashSet<ProductHash> a = new HashSet<ProductHash>();

            a.Add(new ProductHash("TV", 900.00));
            a.Add(new ProductHash("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            ProductHash prod = new ProductHash("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));
            foreach (ProductHash ph in a)
            {
                Console.WriteLine(ph.Name + ", " + prod.Name);
            }

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            Console.Write("[ ");
            foreach (T obj in collection)
            {
                Console.Write(obj + ", ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
