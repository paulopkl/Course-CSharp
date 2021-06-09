using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Interfaces.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.BasicPayment = basicPayment;
            this.Tax = tax;
        }

        public double TotalPayment
        {
            get { return this.BasicPayment + this.Tax; }
        }

        public override string ToString()
        {
            return $"Basic Payment: {this.BasicPayment.ToString("F2")}\nTax: {this.Tax.ToString("F2")}" +
                $"\nTotal payment: {this.TotalPayment.ToString("F2")}";
        }
    }
}
