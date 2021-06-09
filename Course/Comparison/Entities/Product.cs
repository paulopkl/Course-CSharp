namespace Course.Comparison.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{this.Name}, {this.Price.ToString("F2")}";
        }
    }
}
