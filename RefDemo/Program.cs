using System;
using System.Net.Sockets;

namespace RefDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double salary = 5000;
            Add(salary);
            Console.WriteLine(salary);

            var result = Return_Add(salary);
            Console.WriteLine(result);
            Console.WriteLine(new string('*',10));
            Console.WriteLine($"Before salary {salary}");
            Add(ref salary);
            Console.WriteLine($"After salary {salary}");
        }

        private static void Add(double salary)
        {
            salary += 500;
        }
        
        private static double Return_Add(double salary)
        {
           return salary += 500;
        }
        private static void Add(ref double salary)
        {
            salary += 500;
        }
    }
}