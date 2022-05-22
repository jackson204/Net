using System;

namespace ForDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 300;
            int i = 1;
            while(i < number)
            {
                if (300%i==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            // Q1();
            // Q2();
            // Q3();
            // Q4();
            // Q5();
            // Q6();
        }

        static void Q1()
        {
            DisplayHeader("三角形");
            int rows = 5;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Q2()
        {
            DisplayHeader("倒三角形");
            int rows = 5;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j <= 5 - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Q3()
        {
            DisplayHeader("靠右對齊三角形");
            int rows = 5;
            for(int i = 0; i <= rows; i++)
            {
                for(int j = 5; j >= 0; j--)
                {
                    if (i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("");
            }
        }

        static void Q4()
        {
            DisplayHeader("靠右對齊倒三角形");
            int rows = 5;
            for(int i = rows; i > 0; i--)
            {
                string row = new string(' ', rows - i) + new string('*', i);
                Console.WriteLine(row);
            }
        }

        static void Q5()
        {
            DisplayHeader("等腰三角形");

            int rows = 4;

            for(int i = 1; i <= rows; i++)
            {
                string row = new string(' ', rows - i) + new string('*', i * 2 - 1);
                Console.WriteLine(row);
            }
        }

        static void Q6()
        {
            DisplayHeader("倒等腰三角形");
            int rows = 4;

            for(int i = rows; i > 0; i--)
            {
                string row = new string(' ', rows - i) + new string('*', i * 2 - 1);
                Console.WriteLine(row);
            }
        }

        static void DisplayHeader(string title)
        {
            Console.WriteLine("\r\n");
            Console.WriteLine(title);
            Console.WriteLine(new string('=', 40));
        }
    }
}