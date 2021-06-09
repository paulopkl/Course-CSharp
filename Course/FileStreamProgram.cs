using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Course
{
    class FileStreamProgram
    {
        public FileStreamProgram()
        {
            string path = @"C:\Users\Paulo\AppData\Local\Temp\ManageProgram.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException err)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(err.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
