﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class DateTime_Iso8601
    {
        public DateTime_Iso8601()
        {
            //DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            //DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            //DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            //Console.WriteLine("D1: " + d1);
            //Console.WriteLine("D1 Kind: " + d1.Kind);
            //Console.WriteLine("D1 to Local: " + d1.ToLocalTime());
            //Console.WriteLine("D1 to Utc: " + d1.ToUniversalTime());
            //Console.WriteLine("");
            //Console.WriteLine("D2: " + d2);
            //Console.WriteLine("D2 Kind: " + d2.Kind);
            //Console.WriteLine("D2 to Local: " + d2.ToLocalTime());
            //Console.WriteLine("D2 to Utc: " + d2.ToUniversalTime());
            //Console.WriteLine("");
            //Console.WriteLine("D3: " + d3);
            //Console.WriteLine("D3 Kind: " + d3.Kind);
            //Console.WriteLine("D3 to Local: " + d3.ToLocalTime());
            //Console.WriteLine("D3 to Utc: " + d3.ToUniversalTime());

            this.Pparser();
        }
        
        private void Pparser()
        {
            DateTime d1 = DateTime.Parse("2000-08-15 13:58:59");

            DateTime d2 = DateTime.Parse("2000-08-15T13:58:59Z");

            Console.WriteLine(d1.Kind);
            Console.WriteLine(d2.Kind);
        }
    }
}
