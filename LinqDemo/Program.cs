using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Person>()
            {
                new Person(){ProdectNmae ="Hi", Category="H" , Number = 1},
                new Person(){ProdectNmae ="A", Category="A" , Number = 2},
                new Person(){ProdectNmae ="Ban", Category="B" , Number = 3},
                new Person(){ProdectNmae ="Baab", Category="B" , Number = 4},
            };
           var result = list.GroupBy(l => l.Category);
           foreach (var item in result)
           {
               Console.WriteLine($"產品分類 {item.Key}");
               foreach (var person in item)
               {
                   Console.WriteLine($"{person.ProdectNmae}");
               }
           }
        }
    }

    internal class Person
    {
        public string ProdectNmae { get; set; }

        public string Category { get; set; }

        public int Number { get; set; }
    }
}