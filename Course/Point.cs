﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }
}
