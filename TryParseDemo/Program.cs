using System;
using System.Runtime.InteropServices;

namespace TryParseDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("請輸入您的年齡(整數),如果輸入 x 表示要結束程式:");
                var input = Console.ReadLine();
                if (input =="x")
                {
                    return;
                }
                var isInt = int.TryParse(input,out var age);
                if (isInt)
                {
                    Console.WriteLine($"您輸入的值是 {age}");
                    break;
                }
                else
                {
                    Console.WriteLine($"您輸入的值是 {age}");
                    Console.WriteLine("您沒有輸入正確的數值, 請再試一次\r\n");
                }
            }
          
            
        }
    }
}