using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Program
    {
        static void PrintCollection(IDictionary<int,long> map)
        {
            foreach (var q in map)
            {
                Console.WriteLine("{0} {1}", q.Key, q.Value);
            }
        }

        static void PrintCollection(IEnumerable<Min> list)
        {
            foreach (var q in list)
            {
                Console.WriteLine("{0}", q.Value);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, long> map = new Dictionary<int, long>();
            map.Add(1, 2345);
            map.Add(2, 456);
            map.Add(3, 488458);
            Console.WriteLine("Первый контейнер: ");
            PrintCollection(map);
            map.Remove(1);
            map.Add(1, 5465);
            PrintCollection(map);
            Dictionary<int, long> map2 = new Dictionary<int, long>();
            map2.Add(4, 23434345);
            map2.Add(5, 453436);
            map2.Add(6, 483438458);
            Console.WriteLine("\nВторой контейнер: ");
            PrintCollection(map2);
            map.Remove(1);
            map.Remove(2);
            foreach(var w in map2)
            {
                map.Add(w.Key, w.Value);
            }
            Console.WriteLine("Первый контейнер и второй: ");
            PrintCollection(map);
            PrintCollection(map2);
            Console.WriteLine("Вторая программа");
            List<Min> list = new List<Min>();
            list.Add(new laba5.Min(1));
            list.Add(new laba5.Min(7));
            list.Add(new laba5.Min(10));
            list.Sort(new MinComparer());
            PrintCollection(list);
            var temp = from q in list
                       where (q.Value > 5)
                       select q;
            PrintCollection(temp);
            List<Min> list2 = new List<Min>();
            list2.AddRange(temp);
            PrintCollection(list2);
            list.Sort();
            list2.Sort();
            PrintCollection(list);
            PrintCollection(list2);
            var e = list.Union(list2);
            PrintCollection(e);
            Console.WriteLine("Удовлетворяют условию {0} ",e.Where(s=>s.Value>5).Count());

        }
    }

}
