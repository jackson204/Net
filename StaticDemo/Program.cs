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
            Console.WriteLine(new string('*',10));

            //在非靜態類中，可以有非靜態成員與靜態成員
            //在調用非靜態成員，需要使用對象名.非靜態成員
            var person = new Person();
            //實例方法
            person.M1();
            
            //在調用靜態成員，需要使用類名.靜態成員
            //靜態方法
            Person.M2();
            
            //總結:靜態成員必須使用類明去掉用，而實例成員使用對象名調用
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