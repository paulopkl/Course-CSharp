using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class ExercisesLists
    {
        public Employee[] list;

        public ExercisesLists()
        {
            Console.Write("How many employees will be registered? ");

            int range = int.Parse(Console.ReadLine());

            this.list = new Employee[range];

            //foreach (Employee emp in this.list)
            //{
            //    Console.WriteLine($"Employee #{this.list. emp}");
            //}

            for (int i = 0; i < this.list.Length; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");

                Console.Write("Id: ");
                int empId = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string empName = Console.ReadLine();

                Console.Write("Salary: ");
                double empSalary = double.Parse(Console.ReadLine());

                this.list[i] = new Employee(empId, empName, empSalary);

                Console.WriteLine("");
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int luckyBoy = int.Parse(Console.ReadLine());

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            foreach (Employee emp in this.list)
            {
                if (emp.Id == luckyBoy)
                {
                    emp.increaseSalary(percentage);
                }
            }

            Console.WriteLine("Updated list of employees:");

            foreach (Employee emp in this.list)
            {
                Console.WriteLine($"{emp.Id}, {emp.Name}, {emp.Salary}");
            }
        }
    }
}
