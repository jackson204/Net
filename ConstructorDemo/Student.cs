using System;

namespace ConstructorDemo
{
    public class Student
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            Age = age;
        }

        public Student(string name)
            : this(name, 0)
        {
            
        }
    }
}