using System;
using System.Globalization;
using Newtonsoft.Json;

namespace DateTimeDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = "{\"Time\":\"2022/07/07 08:39:17.19-04:00\",\"DateTimeOffset\":\"2022/07/07 08:39:17.19-04:00\"}";
            var value = JsonConvert.DeserializeObject<MyClass>(input);
            Console.WriteLine($"time            {value.Time}");
            Console.WriteLine($"DateTimeOffset  {value.DateTimeOffset}");
            Console.WriteLine($"UtcTime         {value.UtcTime}");
           // NewMethod();
         
        }

        private static void NewMethod()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(new DateTime(2003, 5, 28));

            // 計算明天
            Console.WriteLine(DateTime.Today.AddDays(+1));

            // 計算昨天 
            Console.WriteLine(DateTime.Today.AddDays(-1));

            // 計算本月初
            var firstDay = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            Console.WriteLine(firstDay);

            //計算本月底
            var endDay = firstDay.AddMonths(1).AddDays(-1);
            Console.WriteLine(endDay);

            //計算本月有幾天
            Console.WriteLine(DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

            //計算今天是星期幾
            Console.WriteLine(DateTime.Today.DayOfWeek);

            #region 顯示今年星期天的所有日期

            firstDay = new DateTime(DateTime.Today.Year, 1, 1);
            int weekday = (int) firstDay.DayOfWeek;       // 今年一月一日是星期幾
            int delta = 7 - weekday;                      // 計算1月1日與星期日差距幾天
            DateTime beginDate = firstDay.AddDays(delta); // 今年第一個星期日

            // 找出今年最後一個星期日
            DateTime lastDate = firstDay.AddYears(1).AddDays(-1);     // 今年最後一天
            int weeks = (int) ((lastDate - beginDate).TotalDays / 7); // 計算有幾星期
            DateTime endDate = beginDate.AddDays(weeks * 7);          //

            DateTime current = beginDate;
            while(current <= endDate)
            {
                Console.Write("{0:yyyy/MM/dd}\t", current);
                current = current.AddDays(7);
            }

            #endregion

            #region 顯示今天的中華民國日期

            DateTime today = DateTime.Today;
            var taiwanCalendar = new TaiwanCalendar();
            string message = $"民國 {taiwanCalendar.GetYear(today)} 年 {today.Month:00} 月 {today.Day:00}  日";
            Console.WriteLine(message);

            #endregion
        }
    }

    internal class MyClass
    {
        public DateTime Time { get; set; }

        public DateTimeOffset DateTimeOffset { get; set; }

        public DateTime UtcTime => DateTimeOffset.UtcDateTime;
    }
}