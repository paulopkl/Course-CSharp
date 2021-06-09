using System;
using System.Collections.Generic;

namespace Course.PrintService
{
    class PrintServiceProgram
    {  

        public PrintServiceProgram()
        {

            //Service<string> printService = new Service<string>();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    //int x = int.Parse(Console.ReadLine());
            //    string x = Console.ReadLine();

            //    printService.AddValue(x);
            //}

            //printService.Print();
            //Console.WriteLine();
            //Console.Write("First: ");
            //Console.WriteLine(printService.First());

            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                list.Add(x);
            }

            CalculationService calculationService = new CalculationService();

            int max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}
