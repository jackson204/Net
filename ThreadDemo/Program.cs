using System;
using System.Threading;

namespace ThreadDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var t1 = new Thread(JobA);
            var t2 = new Thread(() => JobB("Test"));
            t1.Start();
            t2.Start();
            Console.WriteLine($"Hello mian Thread {Thread.CurrentThread.ManagedThreadId}");
            
        }

        private static void JobB(string test)
        {
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"ThreadId: {Thread.CurrentThread.ManagedThreadId}. {i} {test}");
            }
        }

        private static void JobA()
        {
            for(int i = 0; i < 15; i++)
            {
                Console.WriteLine($"ThreadId: {Thread.CurrentThread.ManagedThreadId}. {i}");
            }
        }
    }
}