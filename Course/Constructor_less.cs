using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Constructor_less
    {
        public string name;
        public int age;
        public char gender;

        public Constructor_less() { }

        public Constructor_less(string name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void returnData()
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Gender: {gender}");
        }
    }
}
