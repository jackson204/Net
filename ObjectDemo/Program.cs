using System;
using System.Security;
using System.Security.Policy;

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

    internal class Person
    {
        // Fields 
        private string _name;

        //Properties
        // 1.保護Fields，對Fields取值和賦值進行限定
        // 2.相當於兩個方法 一個get() 一個set()
        // 3.屬性只是個過度是沒有存值的
        public string Name
        {
            get { return _name; }
            set { _name = value; }

            //   get 相當於  
            // public string get_Name()
            // {
            //     return this._name ;
            // }
            //   set 相當於    
            //     public void set_Name(string value)
            // {
            //     this._name = value;
            // }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                this._age = value;
            }
        }

        private char _gender;

        public Char Gender
        {
            get
            {
                if (_gender !='男' || _gender!='女')
                {
                    _gender = '男';
                }
                return _gender;
            }
            set { this._gender = value; }
        }

        public void CHISS()
        {
            //get_Name()
            Console.WriteLine($"Hello {this.Name}  , {this.Age}  ,{this.Gender}");
        }
    }
}