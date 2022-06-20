using System;

namespace StaticDemo
{
    public static class Student
    {
        private static string _name;

        //private int _age;//靜態類中，指允許有靜態成員，不允許出現實例成員
        public static string Name
        {
            get { return Student._name; }
            set { Student._name = value; }
        }

        public static void M1()
        {
            Console.WriteLine("Hello World");
        }
    }
}