using Course.AbstractMethod.Entities.Enums;
using System;

namespace Course.AbstractMethod.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }
    }
}
