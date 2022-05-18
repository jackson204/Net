using System;

namespace IfElseDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            // Q04010101();
            Q1(DateTime.Now);
            Q2(DateTime.Now);
            
        }

        private static void Q04010101()
        {
            // 計算一天停車費, 一小時5 元, 每天最多收 30元
            Console.Write("請輸入停車的小時數(1~24):");
            var input = Console.ReadLine();

            // 在本練習裡,不特別針對輸入值是否正確進行檢查
            var hours = int.Parse(input);

            var fee = CalculateParkingRates(hours);

            Console.WriteLine($"停車時數={hours}, 停車費用為 {fee}");
        }
        private static void Q1(DateTime dt)
        {
            string greeting = string.Empty;
            if (dt < dt.Date.AddHours(12))
            {
                greeting = "早安";
            }else if (dt < dt.Date.AddHours(18))
            {
                greeting = "午安";
            }
            else
            {
                greeting = "晚安";
            }

            Console.WriteLine(greeting);
        }

        /// <summary>
        /// 根據目前時間, 決定顯示什麼問安文字
        /// - 大於或等於 00:00 且小於 11:30 : 早安
        /// - 大於或等於 11:30 且小於 17:45 : 午安
        /// - 大於或等於 17:45: 晚安
        /// </summary>
        private static void Q2(DateTime dt)
        {
            string greeting = string.Empty;
            if (dt < dt.Date.AddHours(11.5))
            {
                greeting = "早安";
            }
            else if (dt < dt.Date.AddHours(17).AddMinutes(45))
            {
                greeting = "午安";
            }
            else
            {
                greeting = "晚安";
            }

            Console.WriteLine(greeting);
        }
        private static int CalculateParkingRates(int hours)
        {
            var price = hours * 5;
            return price > 30 ? 30 : price;
        }
    }
}