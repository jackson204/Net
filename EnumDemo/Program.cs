using System;

namespace EnumDemo
{
    public enum QQState
    {
        OnLine = 1,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    public enum Season
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
            #region 將enum強轉成int

            var qqState = QQState.OnLine;
            Console.WriteLine((int) qqState);

            #endregion

            #region 將int強轉成enum

            Console.WriteLine((QQState) 8);

            #endregion

            #region 將string強轉成enum

            object o = Enum.Parse(typeof(QQState), "1");
            QQState state = (QQState) o;
            Console.WriteLine(state);

            #endregion

            Console.WriteLine("input 0-OnLine or 1-OffLine");
            var input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    var s1 = (QQState) Enum.Parse(typeof(QQState), input);
                    Console.WriteLine(s1);
                    break;
                case "2":
                    var s2 = (QQState) Enum.Parse(typeof(QQState), input);
                    Console.WriteLine(s2);
                    break;
            }
        }
    }
}   