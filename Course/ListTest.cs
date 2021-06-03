using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ListTest
    {
        private List<string> list2;
        private List<string> list;

        public ListTest()
        {
            //List<string> list = new List<string>();

            this.list2 = new List<string> { "Maria", "Alex" };

            this.list2.Add("Carlos");
            this.list2.Add("Bob");
            this.list2.Add("Ana");

            this.list2.Insert(2, "Paulo");

            foreach (string obj in this.list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"List contains {this.list2.Count} entries!");

            Console.WriteLine("----------------------------------------");

            string s1 = this.list2.Find(Test);

            Console.WriteLine($"The First 'A' is: {s1}");

            Console.WriteLine("----------------------------------------");

            string s2 = this.list2.FindLast(x => x[0] == 'A');

            Console.WriteLine($"Last 'A': {s2}");

            Console.WriteLine("----------------------------------------");

            int pos1 = this.list2.FindIndex(x => x[0] == 'A');

            Console.WriteLine($"The First position starting with 'A': {pos1}");

            Console.WriteLine("----------------------------------------");

            int pos2 = this.list2.FindLastIndex(x => x[0] == 'A');

            Console.WriteLine($"The Last position starting with 'A': {pos2}");

            Console.WriteLine("----------------------------------------");

            this.list = this.list2.FindAll(x => x.Length == 5);

            foreach (string item in this.list)
            {
                Console.WriteLine(item);
            }

            //this.list2.Remove("Alexx"); // Nothing

            Console.WriteLine("----------------------------------------");

            foreach (string item in this.list2)
            {
                Console.WriteLine(item);
            }

            this.list2.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("----------------------------------------");

            foreach (string item in this.list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------");

            this.list2.RemoveAt(3); // "bob"

            foreach (string item in this.list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------------");

            this.list2.RemoveRange(1, 3);

            foreach (string item in this.list2)
            {
                Console.WriteLine(item);
            }
        }

        public bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
