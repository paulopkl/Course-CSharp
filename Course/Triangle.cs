using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course
{
    class Triangle
    {
        public double A;
        public double B;
        public double C;
        public double P;

        public void generatePerimeter()
        {
            this.P = (this.A + this.B + this.C) / 2;
        }

        public void generateArea()
        {
            if (this.P == default(double))
            {
                this.generatePerimeter();
            }

            double area = Math.Sqrt(this.P * (this.P - this.A) * (this.P - this.B) * (this.P - this.C));
            Console.WriteLine($"Area is equals to {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}