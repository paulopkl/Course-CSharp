using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class MatrizTest
    {
        double[,] mat = new double[2, 3];
        int[,] matriz;

        public MatrizTest()
        {
            //Console.WriteLine(this.mat.Length);
            //Console.WriteLine(this.mat.Rank);
            //Console.WriteLine(this.mat.GetLength(0));
            //Console.WriteLine(this.mat.GetLength(1));

            int n = int.Parse(Console.ReadLine());

            this.matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int x = 0; x < n; x++)
                {
                    this.matriz[i, x] = int.Parse(values[x]);
                }
            }

            Console.WriteLine("");

            Console.WriteLine("Main Diagonal!");

            for (int i = 0; i < n; i++)
            {
                Console.Write(this.matriz[i, i] + ", ");
            }

            Console.WriteLine("");

            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    Console.Write(this.matriz[i, x] + ", ");
                }
            }

            Console.WriteLine("");

            Console.Write("Negative Numbers: ");

            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (this.matriz[i, x] < 0)
                    {
                        Console.Write(this.matriz[i, x] + ", ");
                    }
                }
            }
        }
    }
}
