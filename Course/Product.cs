using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        //private int _quantity;
        //private double _price;

        public Product() {  }

        public Product(string name, double price) : this()
        {
            this._name = name;
            this.Price = price;
        }

        public Product(string name, double price, int quantity) : this(name, price)
        {
            this.Quantity = quantity;
        }

        public double TotalStockValue()
        {
            return this.Price * this.Quantity;
        }

        public void addProducts(int quantity)
        {
            this.Quantity += quantity;
        }

        public void removeProducts(int quantity)
        {
            this.Quantity -= quantity;
        }

        public string Name {
            get {
                return this._name;
            }

            set {
                if (value != null && value.Length > 1) {
                    this._name = value;
                }
            }
        }

        //public string GetName()
        //{
        //    return this._name;
        //}

        //public void setName(string name)
        //{
        //    if (name != null && name.Length > 1)
        //    {
        //        this._name = name;
        //    }
        //}

        //public double Price
        //{
        //    get { return this._price; }
        //    set
        //    {
        //        this._price = value;
        //    }
        //}

        //public int Quantity
        //{
        //    get { return this._quantity; }
        //}

        public override string ToString()
        {
            return 
                this._name
                + ", R$ "
                + this.Price.ToString("F2")
                + ", "
                + this.Quantity
                + " unities, Total: R$ "
                + this.TotalStockValue().ToString("F2");
        }
    }
}
