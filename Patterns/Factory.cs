using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    public class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }

        private Student(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public static Student Initialize(string name, string age)
        {
            return new Student(name, age);
        }
    }
}

