using System;

namespace VariableDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 變數型別 變數名稱;
            int number; //定義一個 int 型別的變數

            //變數名稱 = 值 "="不等於等於的意思 而是賦值，表示把等號右邊的值賦值給等號左邊的變數
            number = 10; //把10賦值給number ; 

            //--------------------------
            int age = 18; // 宣告整數類型的變數, 名稱是 age, 它的值是 18

            //--------------------------

            // 宣告變數時, 不一定要給予值, 可以事後才給值, 之後也仍可以持續變動其值
            // 也正因為它的值可以持續被改變,我們才稱它為 '變數'
            int height;
            height = 180; // 設定變數值為 180
            
            // 一次宣告多個變數可以折行, 最後記得要加分號, 表示結尾
            int productId = 921, unitPrice = 12000, qty;

            var a = 10; // 在編譯時, 會經由數字10, 推測 a 的型別應該是整數。
            
            //判別其奇數 or 偶數
            var number1 = 9;
            var number2 = 202;
            
            var result1 = IsEven(number1) ? "偶數" : "奇數";
            var result2 = IsEven(number2) ? "偶數" : "奇數";
            Console.WriteLine(result1);
            Console.WriteLine(result2);

        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}