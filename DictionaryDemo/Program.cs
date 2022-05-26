using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace DictionaryDemo
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            // var cities = new Dictionary<int, string>();
            // cities.Add(1, "台北"); // key是整數型別, value 是字串型別
            // cities.Add(16, "台中");
            // cities.Add(99, "高雄");
            // Console.WriteLine(cities[16]);//台中

            //---------key 不可以相同(大小寫相異視為不同)-----
            // Dictionary<string, string> cities = new Dictionary<string, string>();
            // cities.Add("A", "台北"); 
            // cities.Add("a", "台中");
            // Console.WriteLine(cities["a"]); //台中 

            //---------key  (大小寫相異視為相同)-----
            // Dictionary<string, string> cities = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            // cities.Add("A", "台北");
            // cities.Add("a", "台中");

            // foreach (var key in cities.Keys)
            // {
            //     Console.WriteLine($" Key =  {key} , Value ={cities[key]}");
            // }

            // Q1();

            // Q2();
            
        }

        private static void Q2()
        {
            var maps = new Dictionary<string, string>();
            maps.AppendKeyRange("1,2,99,8,a,ac".Split(','), "A");
            maps.AppendKeyRange("3,5,10,r,xyz".Split(','), "B");
            maps.AppendKeyRange("b,z,-1,0".Split(','), "C");
        }

        public static void AppendKeyRange<T1, T2>(this Dictionary<T1, T2> source, T1[] keys, T2 value)
        {
            foreach (var key in keys)
            {
                source.Add(key, value);
            }
        }

        private static void Q1()
        {
            string[] items = new string[] {"A", "C", "B", "A", "Z", "A", "C"};

            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var item in items)
            {
                if (result.ContainsKey(item))
                {
                    result[item]++;
                }
                else
                {
                    result.Add(item, 1);
                }
            }

            DisplayResult(result);
        }

        private static void DisplayResult(Dictionary<string, int> result)
        {
            foreach (KeyValuePair<string, int> item in result)
            {
                Console.WriteLine($"{item.Key} 出現 {item.Value} 次");
            }
        }
    }
}