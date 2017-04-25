using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void PrintDictinary(Dictionary<int,long> map)
        {
            foreach (var q in map)
            {
                Console.WriteLine("{0} {1}", q.Key, q.Value);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, long> map = new Dictionary<int, long>();
            map.Add(1, 2345);
            map.Add(2, 456);
            map.Add(3, 488458);
            Console.WriteLine("Первый контейнер: ");
            PrintDictinary(map);
            map.Remove(1);
            map.Add(1, 5465);
            PrintDictinary(map);
            Dictionary<int, long> map2 = new Dictionary<int, long>();
            map2.Add(4, 23434345);
            map2.Add(5, 453436);
            map2.Add(6, 483438458);
            Console.WriteLine("\nВторой контейнер: ");
            PrintDictinary(map2);
            map.Remove(1);
            map.Remove(2);
            foreach(var w in map2)
            {
                map.Add(w.Key, w.Value);
            }
            Console.WriteLine("Первый контейнер и второй: ");
            PrintDictinary(map);
            PrintDictinary(map2);
        }
    }
}
