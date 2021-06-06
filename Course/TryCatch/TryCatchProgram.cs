using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Course.TryCatch
{
    class TryCatchProgram
    {
        public TryCatchProgram() 
        {
            FileStream fs = null;

            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());

            //    int result = n1 / n2;
            //    Console.WriteLine(result);
            //}
            ////catch(Exception err)
            //catch (DivideByZeroException err)
            //{
            //    Console.WriteLine($"Erro! {err.Message}");
            //}
            //catch (FormatException err)
            //{
            //    Console.WriteLine($"Format error! {err.Message}");
            //}
            //finally {  }

            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (DirectoryNotFoundException err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
