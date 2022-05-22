using System;
using System.Diagnostics.Eventing.Reader;

namespace TryCatchDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string email = null;
            try
            {
                int result = GetIndexOfAt(email);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Q1();
        }

        private static int GetIndexOfAt(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException(nameof(email), "email is null");
            }

            return email.IndexOf('@');
        }

        private static void Q1()
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