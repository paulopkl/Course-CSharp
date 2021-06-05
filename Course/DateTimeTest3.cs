using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class DateTimeTest3
    {
        public DateTimeTest3()
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            //Console.WriteLine($"{t1}, {t2}, {t3}");

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);

            //Console.WriteLine($"Days: {t4.Days}");

            TimeSpan t5 = new TimeSpan(1, 30, 10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t5.Add(t6);
            TimeSpan diff = t5.Subtract(t6);
            TimeSpan mult = t5.Multiply(2.0);

            Console.WriteLine($"{t5}, {t6}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Difference = {diff}");
            Console.WriteLine($"Multiply * 2.0 = {mult}");
        }
    }
}
