using System;
using System.Linq;

namespace outDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new[] {1, 2, 3, 4, 5, 6};
            GetAll(a, out var max, out var min);
            Console.WriteLine($"max {max} , min {min}");
        }

        private static void GetAll(int[] ints, out int max, out int min)
        {
            max = ints.Max();
            min = ints.Min();
        }
    }
}