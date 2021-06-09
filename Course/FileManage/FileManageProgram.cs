using System;
using System.IO;

namespace Course.FileManage
{
    class FileManageProgram
    {
        public FileManageProgram()
        {

            string sourcePath = @"C:\Users\Paulo\AppData\Local\Temp\ManageProgram.txt";
            string targetPath = @"C:\Users\Paulo\AppData\Local\Temp\ManageProgram2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                string[] lines = File.ReadAllLines(sourcePath);

                //fileInfo.CopyTo(targetPath); // Copy the file

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException err)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(err.Message);
            }
        }
    }
}
