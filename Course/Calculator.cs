using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Calculator
    {
        public static double PI = Math.PI;

        public static double circumference(double radius)
        {
            return 2 * Calculator.PI * radius;
        }

        public static double Volume(double radius)
        {
            return 4.0 / 3.0 * Calculator.PI * Math.Pow(radius, 3);
        }
    }
}
