using System;

namespace StaticDemo
{
    public class Person
    {
        private static string _name;
        private char _gander;

        public static string Name
        {
            get { return Person._name; }
            set => Person._name = value;
        }

        public char Gander
        {
            get => _gander;
            set => _gander = value;
        }

        public void M1()
        {
            // Name
            // _gander 非靜態方法，可以呼叫靜態成員與實例成員
            Console.WriteLine("非靜態方法");
        }

        public static void M2()
        {
            //Name
            //_gander 靜態方法中，只能呼叫靜態成員，不允許訪問實例成員
            Console.WriteLine("靜態方法");
        }
    }
}