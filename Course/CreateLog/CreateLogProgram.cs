using Course.CreateLog.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Course.CreateLog
{
    class CreateLogProgram
    {
        public CreateLogProgram()
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");

                        set.Add(new LogRecord { Username = line[0], Instant = DateTime.Parse(line[1]) });
                    }

                    foreach (var item in set)
                    {
                        Console.WriteLine($"{item.Username}, {item.Instant}");
                    }

                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
