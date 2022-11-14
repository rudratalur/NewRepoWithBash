using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkQueriesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new[] { "Pune", "Ballari", "bengaluru", "Nasik" };
            var res1 = from c in cities
                          where c.StartsWith("N")
                          orderby c 
                          select c;

            // foreach (var item in res1)
            //{
            //   Console.WriteLine(item);
            //}

            var res2 = cities.Where((c) => c.StartsWith("N"));
            var res3 = cities.Where(c => c.StartsWith("N"));
       //     var res4 = cities.Where(() => cities.StartsWith("N"));
            var res4 = cities.Where((a,b) => cities.Contains("N"));

            Console.WriteLine();

            int[] a2 = { 5, 4, 3, 2, 7, 8, 10, 12, 5 };
            /*        var result1 = from a in a2
                                  where a % 2 == 0
                                  select a; */


            /*      foreach(var b in result1)
                  {
                      Console.WriteLine(b);
                  }
            */
            //write linq query to printall even numbers of an array
            var even = a2.Where((item) => item % 2 == 0);
                foreach (var item in even) 
                {
                    Console.WriteLine(item);
                }

            var evenNos = a2.Where((item) => item % 2 != 0);
            foreach(var item in evenNos)
            {
                Console.WriteLine($"odd numbers are: {item}");
               
            }


            List<int> avg = new List<int>(a2);
            Console.WriteLine($"avgs is: {avg.Average(a=>a)}");



            List<int> list2 = new List<int>(a2);
            Console.WriteLine($"usung firstorDefault on empty list: {list2.FirstOrDefault()}");
            //Console.WriteLine($"usung first on empty list: {list2.First()}");
            list2.Sort();
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }  
            Console.WriteLine(list2.Count());
            Console.WriteLine(list2.Average());
            //Console.WriteLine(list2.Append(222));
            //Console.WriteLine(list2.length());
            Console.WriteLine(list2.Contains(73));
            //Console.WriteLine(list2.FindIndex(6));
            //Console.WriteLine(list2.Find(2));
            //Console.WriteLine(list2.Add(6));
            Console.WriteLine(list2.IndexOf(7));
            Console.WriteLine(list2.FindIndex(5));


            Console.ReadLine();
           
        }
    }
}
