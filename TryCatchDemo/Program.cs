using System;
using System.Diagnostics.Eventing.Reader;

namespace TryCatchDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input :");
            var input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine(input);
            
        }
    }
}