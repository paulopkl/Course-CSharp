using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Course
{
    class StreamWriterProgram
    {
        public StreamWriterProgram()
        {
            string sourcePath = @"C:\Users\Paulo\AppData\Local\Temp\ManageProgram.txt";
            string targetPath = @"C:\Users\Paulo\AppData\Local\Temp\ManageProgram2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException err)
            {
                Console.WriteLine("An error has occurred");
                Console.WriteLine(err.Message);
            }
        }
    }
}
