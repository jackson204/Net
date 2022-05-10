using System;
using System.Threading;

namespace StaticDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Method();
            Method();
            Method();
        }
        private static void Method()
        {
            try
            {
                Thread.Sleep(1000);
                new MyClass();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetBaseException().Message);
            }
        }
        public class MyClass
        {
            //呼叫一次後 第二次並不會呼叫
            //建議 不要放任何可能會發生Exception在裡面
            static MyClass()
            {
                throw new Exception(DateTime.Now.ToString());
            }
        }
    }
}