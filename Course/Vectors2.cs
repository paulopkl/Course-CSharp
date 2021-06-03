using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Vectors2
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Vectors2 () { }

        public Vectors2 (string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
