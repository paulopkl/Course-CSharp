using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course
{
    class Vectors
    {
        private int n;
        private double[] vect;
        private double sum = 0.0;
        private double avg;

        public Vectors(string num)
        {
            this.n = int.Parse(num);

            this.vect = new double[this.n];

            for (int i = 0; i < this.n; i++)
            {
                this.vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < n; i++)
            {
                this.sum += vect[i];
            }

            this.avg = sum / n;

            Console.WriteLine($"Average is {this.avg.ToString("F2", CultureInfo.InvariantCulture)}!");
        }
    }
}
