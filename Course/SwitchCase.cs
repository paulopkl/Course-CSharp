using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class SwitchCase
    {
        public SwitchCase()
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednessday";
                    break;
                case 5:
                    day = "thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                case 1:
                    day = "Sunday";
                    break;
                default:
                    day = "Invalid Date";
                    break;
            }

            Console.WriteLine(day);
        }
    }
}
