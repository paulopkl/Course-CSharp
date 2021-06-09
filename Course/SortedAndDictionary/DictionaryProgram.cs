using System;
using System.Collections.Generic;
using System.Text;

namespace Course.SortedAndDictionary
{
    class DictionaryProgram
    {
        public DictionaryProgram()
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99999999999";
            cookies["phone"] = "98988921388";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no (\"email\") key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES: ");
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine($"\"{item.Key}\": {item.Value}");
            }
        }
    }
}
