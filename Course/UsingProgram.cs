using System;
using System.IO;

namespace Course
{
    class UsingProgram
    {
        public UsingProgram()
        {
            string path = @"C:\Users\Paulo\AppData\Local\Temp\ManageProgram.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    //using (StreamReader sr = new StreamReader(fs))
                    using (StreamReader sr = File.OpenText(path))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                //}
            }
            catch (IOException err)
            {
                Console.WriteLine("An Error occurred");
                Console.WriteLine(err.Message);
            }
        }
    }
}
