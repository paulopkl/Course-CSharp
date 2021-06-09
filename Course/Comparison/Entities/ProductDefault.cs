using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Comparison.Entities
{
    class ProductDefault : IComparable<ProductDefault>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductDefault(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Price.ToString("F2")}";
        }

        public int CompareTo(ProductDefault other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
