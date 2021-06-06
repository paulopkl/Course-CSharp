﻿using Course.AbstractMethod.Entities.Enums;
using System;

namespace Course.AbstractMethod.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base(color) 
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Area()
        {
            return this.Width * this.Height;
        }
    }
}
