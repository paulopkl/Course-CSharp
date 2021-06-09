using System;
using System.Collections.Generic;
using System.IO;
using Course.Comparable.Entities;

namespace Course.Comparable
{
    class ComparableProgram
    {
        public ComparableProgram()
        {
            string path = @"C:\Users\Paulo\AppData\Local\Temp\testFolder\Salary.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<CpEmployee> list = new List<CpEmployee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new CpEmployee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (CpEmployee str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException err)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(err.Message);
            }
        }
    }
}
