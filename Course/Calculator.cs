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

        //public static int Sum(int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (var num in numbers)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //}

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static void Triple(ref int x)
        {
            x *= 3;
        }

        public static void TripleOut(int origin, out int result)
        {
            result = origin * 3;
        }
    }
}
