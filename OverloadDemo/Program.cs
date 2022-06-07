namespace OverloadDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
          //1. 方法名稱需相同  
         // 2.如果參數個數相同，那麼參數的型別就不能相同
         // 3.如果參數型別相同，那麼參數的個數就不能相同
         // 4.與 回傳值 無關
        }

        private static void M(int n1, int n2)
        {
            var result = n1 + n2;
        }

        private static double M(double n1, double n2)
        {
            return n1 + n2;
        }

        private static void M(int n1, int n2, int n3)
        {
            var result = n1 + n2 + n3;
        }

        private static string M(string n1, string n2)
        {
            return n1 + n2;
        }
    }
}