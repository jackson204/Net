using System;

namespace ConstructorDemo
{
    internal class Member
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