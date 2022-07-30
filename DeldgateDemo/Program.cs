using System;
using System.Collections.Generic;
using System.Security.Permissions;

namespace DeldgateDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dele d = Show;
            d.Invoke("AA"); // d"AA");
            
            //匿名
            Del2 a;
            a = delegate(int x)
            {
                return  x * x;
            };
            var i = a(3);
            Console.WriteLine(i);

            var ints = new List<int>();
            Console.WriteLine(ints.GetType());
            
            //擴充方法
            var student = new Student();
            student.Show();
            student.Run();
            student.ShowName("fff");
        }

        private static string Show(string s)
        {
            Console.WriteLine(s + " World");
            return s;
        }

        static int a(int x) => x * x;

        public delegate string Dele(string name);

        public delegate int Del2(int index);
    }

    internal static class StudentEX
    {
        //this Student : 不是形參，而是指名這個方法是提供給誰用的
        public static void Run(this Student student)
        {
            Console.WriteLine("run");
        } 
        public static void ShowName(this Student student , string name)
        {
            Console.WriteLine(name);
        }
    }

    internal class Student
    {
        //添加一個Run 的方法 但不能添加在該類別中 =>為Student 類 擴充一個方法
        public void Show()
        {
            Console.WriteLine("Show");
        }
    }
}