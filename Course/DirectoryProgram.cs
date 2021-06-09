using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Course
{
    class DirectoryProgram
    {
        public DirectoryProgram()
        {
            string path = @"C:\Users\Paulo\AppData\Local\Temp\testFolder";
            string targetPath = @"C:\Users\Paulo\AppData\Local\Temp\ManageProgram2.txt";

            try
            {
                //var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException err)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(err.Message);
            }
        }
    }
}
