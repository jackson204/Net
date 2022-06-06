using System;
using System.Runtime.InteropServices;

namespace TryParseDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //使用Convert 進行轉換 成功舊城，失敗就掏異常  Convert.ToInt32 內部使用就是用int.Parse
            // var numberOne = Convert.ToInt32("123a");
            //另一種寫法
            // var numberOne = int.Parse("123a");

            var b = int.TryParse("123a" , out var result );
            Console.WriteLine(result);           
            
             b = int.TryParse("123" , out  result );
            Console.WriteLine( b);
            Console.WriteLine(result);

            bool c= MyTryParse("123a", out var result2);
            Console.WriteLine( result2);
        }

        private static bool MyTryParse(string input, out int result)
        {
            result = 0;
            try
            {
                result = Convert.ToInt32(input);
                return true;
               
            }
            catch (Exception e)
            {
                return false;
            }
            
          
        }
    }
}