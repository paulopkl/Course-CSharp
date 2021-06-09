using System;
using System.Collections.Generic;
using System.Text;

namespace Course.HashAndSorted.Entities
{
    class ProductHash
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductHash(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Price.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (!(obj is ProductHash))
            {
                return false;
            }

            ProductHash other = obj as ProductHash;

            return this.Name.Equals(other.Name) && this.Price.Equals(other.Price);
        }
    }
}
