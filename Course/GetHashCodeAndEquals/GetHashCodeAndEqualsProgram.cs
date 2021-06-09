using Course.GetHashCodeAndEquals.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course.GetHashCodeAndEquals
{
    class GetHashCodeAndEqualsProgram
    {
        public GetHashCodeAndEqualsProgram()
        {
            //string a = "Maria";
            //string b = "Maria";
            //string c = "Paulo";

            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(c.GetHashCode());

            Client ca = new Client() { Name = "Paulo", Email = "paulo@email.com" };
            Client cb = new Client() { Name = "Paulo", Email = "paulo@email.com" };

            Console.WriteLine(ca.Equals(cb));
            Console.WriteLine(ca == cb);
            Console.WriteLine(ca.GetHashCode());
            Console.WriteLine(cb.GetHashCode());
        }
    }
}
