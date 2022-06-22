using System;

namespace ConstructorDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var member1 = Member.MemberFactory.CreateByEmail(1, "allen@gmail.com");
            Console.WriteLine(member1);
            var member2 = Member.MemberFactory.CreateByEmail(2, "allen@gmail.2222");
            Console.WriteLine(member2);
            var member3 = Member.MemberFactory.CreateByName(1, "Allen Kuo");
            Console.WriteLine(member3);
            
            Console.WriteLine(new string('*',10));

            var student = new Student("HelloA", 12);
        }
    }
}