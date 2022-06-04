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
        }

        public class Member
        {
            private Member() { }
            private int Id;
            private string Name;
            private string Email;

            public static class MemberFactory
            {
                public static Member CreateByName(int id, string name)
                {
                    Console.WriteLine(nameof(CreateByName));
                    return new Member { Id = id, Name = name };
                }

                public static Member CreateByEmail(int id, string email)
                {
                    Console.WriteLine(nameof(CreateByName));
                    return new Member { Id = id, Email = email };
                }
            }
        }
        
    }

}