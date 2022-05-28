namespace ConstDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number = 20;
            number = 10;   // 可重新賦直

            const int number2 = 10;
            // number2 = 20; //  不可重新賦直
        }
    }
}