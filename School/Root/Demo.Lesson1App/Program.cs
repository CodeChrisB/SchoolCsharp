using CommonBase.Extensions;
using System;

namespace Demo.Lesson1App
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "Hell1o Wor2ld3";
            Console.WriteLine(text);

            string[] strings = new[] { "Hello", "World", "how", "are", "you", "?" };

            Console.WriteLine("--->  "+ text.toInt32());
            strings.PrintLn();
            Console.WriteLine("");
            strings.PrintIndex();
            Console.WriteLine("");
            strings.PrintNth(2);
        }
    }
}
