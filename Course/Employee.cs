using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee()
        {

        }

        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void increaseSalary(double percent)
        {
            this.Salary *= ((percent / 100) + 1);
        }
    }
}
