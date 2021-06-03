using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class StringsFunctions
    {
        public StringsFunctions()
        {
            string originary = " acxxcz       z    ZXCadsdassdaCXZCXZ /asdasddsadsa asdlçflç       ";

            string s1 = originary.ToUpper();

            Console.WriteLine($"|{s1}|");

            s1 = originary.ToLower();

            Console.WriteLine($"|{s1}|");

            s1 = originary.Trim();

            Console.WriteLine($"|{s1}|");

            int s2 = originary.IndexOf("ddsa");

            Console.WriteLine($"IndeOf ddsa: {s2}");

            int s3 = originary.LastIndexOf("fl");

            Console.WriteLine($"LastIndeOf fl: {s3}");

            string s4 = originary.Substring(3);

            Console.WriteLine($"Substring 3: |{s4}|");

            string s5 = originary.Substring(3, 5);

            Console.WriteLine($"Substring 3 - 5: |{s5}|");

            string s6 = originary.Replace('a', '4');

            Console.WriteLine($"Replace a -> 4: |{s6}|");

            bool nullOrEmpty = String.IsNullOrEmpty(originary);

            Console.WriteLine($"originary is NullOrEmpty: |{nullOrEmpty}|");

            bool nullOrWhiteSpace = String.IsNullOrWhiteSpace(originary);

            Console.WriteLine($"originary is IsNullOrWhiteSpace: |{nullOrWhiteSpace}|");
        }
    }
}
