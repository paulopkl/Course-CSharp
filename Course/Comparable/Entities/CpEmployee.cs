using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Comparable.Entities
{
    class CpEmployee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public CpEmployee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(",");
            this.Name = vect[0];
            this.Salary = double.Parse(vect[1]);
        }
        public override string ToString()
        {
            return $"{this.Name}, {this.Salary.ToString("F2")}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is CpEmployee))
            {
                throw new ArgumentException("Comparing error: argument isn't CpEmployee");
            }

            CpEmployee other = obj as CpEmployee;

            return this.Salary.CompareTo(other.Salary);
        }
    }
}
