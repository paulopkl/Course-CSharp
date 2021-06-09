using System;

namespace Course.ExtensionMethod
{
    class ExtensionMethodProgram
    {
        public ExtensionMethodProgram()
        {
            DateTime dt = new DateTime(2021, 6, 8, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(7));
        }
    }
}
