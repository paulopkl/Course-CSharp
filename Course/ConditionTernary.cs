using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ConditionTernary
    {
        public ConditionTernary()
        {
            int num = (2 > 4) ? 50 : 80;

            Console.WriteLine(num);

            string btt = ("Maria".Length > 2) ? "Sim" : "Não";
            Console.Write("Maria is bigger than 2? ");
            Console.Write(btt);
        }
    }
}
