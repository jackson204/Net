using System;

namespace EnumDemo
{
    public enum Gander
    {
        男,
        女
    }

    public enum Seson
    {
        春,
        夏,
        秋,
        冬
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var gander = Gander.男;
            Console.WriteLine((int)gander);
        }
    }
}