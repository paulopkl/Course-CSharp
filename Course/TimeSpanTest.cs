﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class TimeSpanTest
    {
        public TimeSpanTest()
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            Console.WriteLine(t1);

            Console.WriteLine(t1.Ticks);
            
            TimeSpan t2 = new TimeSpan(9000000000L);

            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(1, 2, 11, 21);

            Console.WriteLine(t3);

            TimeSpan t4 = new TimeSpan(1, 2, 11, 21, 321);

            Console.WriteLine(t4);

            TimeSpan t5 = TimeSpan.FromDays(1.5);

            Console.WriteLine(t5);

            TimeSpan t6 = TimeSpan.FromHours(1.5);

            Console.WriteLine(t6);

            TimeSpan t7 = TimeSpan.FromMinutes(1.5);

            Console.WriteLine(t7);

            TimeSpan t8 = TimeSpan.FromSeconds(1.5);

            Console.WriteLine(t8);

            TimeSpan t9 = TimeSpan.FromMilliseconds(1.5);

            Console.WriteLine(t9);

            TimeSpan t10 = TimeSpan.FromTicks(010000000L);

            Console.WriteLine(t10);
        }
    }
}
