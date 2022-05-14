using System;

namespace StringDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string value1 = null; // null 表示沒有值
            string value2 = "allen";
            string result = value1 + value2;
            Console.WriteLine(result); // 答案是 allen

            value1 = "";           // 空字串
            value2 = string.Empty; // 空字串
            
            value1 = "     "; // 很多空白組合而成的字串
            
            // 判斷字串是不是 null
            value1 = null;
            Console.WriteLine(value1 == null);
            
            // 判斷字串是不是空字串
            string value2A = string.Empty;
            bool result2A = (value2A == string.Empty);
            Console.WriteLine($"string.Empty = {result2A}");
            
            string value2B = "";
            bool result2B = (value2B == string.Empty);
            Console.WriteLine(result2B);

            // Trim() 用來將字串左右的空白刪除, 但不刪除字串中間的空白
            string value3 = "    ";
            Console.WriteLine($"Trim {value3.Trim() == string.Empty}");
            Console.WriteLine(new string('*',10));
            Console.WriteLine("IsNullOrEmpty");
            // 判斷字串是不是null 或空字串
            value1 = null;
            Console.WriteLine($"判斷字串是不是null {string.IsNullOrEmpty(value1)}");
            value2 = String.Empty;
            Console.WriteLine($"判斷字串是不是空字串 {string.IsNullOrEmpty(value2)}");
            
            Console.WriteLine(new string('*',10));
            Console.WriteLine("IsNullOrWhiteSpace");
            // 判斷字串是不是null, 空字串,或連續空白字串
            value1 = null;
            Console.WriteLine($"判斷字串是不是null {string.IsNullOrWhiteSpace(value1)}");
            value2 = String.Empty;
            Console.WriteLine($"判斷字串是不是空字串 {string.IsNullOrWhiteSpace(value2)}");
            value3 = "    ";
            Console.WriteLine($"判斷字串是不是空字串 {string.IsNullOrWhiteSpace(value3)}");
            
        }
    }
}