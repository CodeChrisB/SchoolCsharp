using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace CommonBase.Extensions
{
    public static class EnumrableExtension
    {

        public static IEnumerable<T> MyForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
            {
                action(item);
            }
            return source;
        }

        public static void PrintLn(this IEnumerable source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintIndex(this IEnumerable source)
        {
            int i = 0;
            foreach (var item in source)
            {
                Console.WriteLine("Index " + i + ": " + item);
                i++;
            }
        }

        public static void PrintNth(this IEnumerable source, int n)
        {
            int i = 1;
            foreach (var item in source)
            {
                if (i % n == 0)
                    Console.WriteLine(item);
                i++;



            }
        }
    }
}
