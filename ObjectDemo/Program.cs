namespace ObjectDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "AAA"; //set_Name()
            person.Age = -123;
            person.Gender = '好';
            person.CHISS();

        }
    }
}