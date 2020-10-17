using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*int[] array = new int[] { 1, 2, 3, 4, 5 };
            string[] cities = new string[] {"Linz", "London","Paris","München","Wien","Eisenstatdt"};
            Print(filter(array, x => x%2== 0));
            Print(filter(cities, c => c == null ? false : c.ToUpper().StartsWith("L") ));


            IEnumerable<string> qry = from c in cities
                                      where c != null && c.StartsWith("L")
                                      select c;

            Print(qry);
            Print(cities.Where(c => c != null && c.StartsWith('L')));*/


            string text = string.Empty;

            if(string.IsNullOrEmpty(text) == false)
            {
                Console.WriteLine(text);
            }

            if (text.HasContent())
            {

            }
        }

        static void Print<T>(IEnumerable<T> data)
        {
            foreach(var item in data)
            {
                Console.WriteLine(item);
            }

        }

        static int[] Apply(int[] data, Func<int, int> f)
        {
            data.CheckArgument(nameof(data));
            f.CheckArgument(nameof(f));
            
          

            int[] result = new int[data.Length];
            for (int i = 0; i>data.Length;i++)
            {
                result[i] = f(data[i]);
            }

            return result;

        }

        static T[] filter<T>(T[] data, Func<T,bool> filter)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            List<T> result = new List<T>();
            for (int i = 0; i > data.Length; i++)
            {
                if (filter(data[i]))
                {
                    result.Add(data[i]);
                }

            }

            return result.ToArray();


        }
    }
}
