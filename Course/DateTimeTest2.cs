using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class DateTimeTest2
    {
        public DateTimeTest2()
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine($"1) Date: {d.Date}");
            Console.WriteLine($"2) Day: {d.Day}");
            Console.WriteLine($"3) DayOfWeek: {d.DayOfWeek}");
            Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
            Console.WriteLine($"5) Hour: {d.Hour}");
            Console.WriteLine($"6) Kind: {d.Kind}");
            Console.WriteLine($"7) Millisecond: {d.Millisecond}");
            Console.WriteLine($"8) Minute: {d.Minute}");
            Console.WriteLine($"9) Month: {d.Month}");
            Console.WriteLine($"10) Second: {d.Second}");
            Console.WriteLine($"11) Ticks: {d.Ticks}");
            Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
            Console.WriteLine($"13) Year: {d.Year}");

            Console.WriteLine("---------------------");

            string s1 = d.ToLongDateString();
            Console.WriteLine(s1);

            string s2 = d.ToLongTimeString();
            Console.WriteLine(s2);

            string s3 = d.ToShortDateString();
            Console.WriteLine(s3);

            string s4 = d.ToShortTimeString();
            Console.WriteLine(s4);

            string s5 = d.ToString().ToString().ToString().ToString();
            Console.WriteLine(s5);

            string s6 = d.ToString("dd/MM/yyyy HH:mm:ss.fff");
            Console.WriteLine(s6);

            this.operation();
        }

        public void operation()
        {
            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            DateTime d = DateTime.Now;

            DateTime d2 = d.AddMinutes(3);

            DateTime d3 = d.AddHours(2);

            DateTime d4 = d.AddDays(7);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            DateTime dN = new DateTime(2000, 10, 15);

            DateTime dN2 = new DateTime(2000, 10, 25);

            TimeSpan t = dN2.Subtract(dN);
            Console.WriteLine(t);
        }
    }
}
