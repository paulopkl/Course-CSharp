using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class DateTimeTest
    {
        public DateTimeTest()
        {
            DateTime d1 = DateTime.Now;

            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);

            Console.WriteLine("------------------------------");

            DateTime d2 = new DateTime(2018, 11, 25);

            Console.WriteLine(d2);

            Console.WriteLine("------------------------------");

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);

            Console.WriteLine(d3);

            Console.WriteLine("------------------------------");

            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500);

            Console.WriteLine(d4);

            Console.WriteLine("------------------------------");

            DateTime d5 = new DateTime(2018, 11, 25, 20, 45, 03);

            Console.WriteLine(d5);

            Console.WriteLine("------------------------------");

            DateTime d6 = DateTime.Today;

            Console.WriteLine(d6);

            Console.WriteLine("------------------------------");

            DateTime d7 = DateTime.UtcNow;

            Console.WriteLine(d7);

            Console.WriteLine("------------------------------");

            DateTime d8 = DateTime.Parse("2000-08-15");

            Console.WriteLine(d8);

            Console.WriteLine("------------------------------");

            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");

            Console.WriteLine(d9);

            Console.WriteLine("------------------------------");

            DateTime d10 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            Console.WriteLine(d10);

            Console.WriteLine("------------------------------");

            DateTime d11 = DateTime.ParseExact("15/09/2001 13:05:58", "dd/MM/yyyy HH:mm:ss", new CultureInfo("pt-br", false));

            Console.WriteLine(d11);
        }
    }
}
