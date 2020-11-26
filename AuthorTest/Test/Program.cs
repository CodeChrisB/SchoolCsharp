using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Attributes;
using System.Security.Cryptography.X509Certificates;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.AddOrder(new Order());
            account.AddOrder(new Order());
            account.AddOrder(new Order());

            PrintAttributes(account);
            Console.WriteLine(new String('-', 64));
            foreach (var order in account.GetOrders())
            {
                PrintAttributes(order);
                Console.WriteLine(new String('-', 64));
            }

            Console.ReadLine();
        }

        private static void PrintAttributes(object o)
        {
            Type type = o.GetType();
            IEnumerable<Attribute> attributes = type.GetCustomAttributes();
            Console.WriteLine($"Attributes for {type.Name}");
            foreach (Attribute a in attributes)
            {
                Type x = a.GetType();
                Console.WriteLine($"{x.Name} : {a}");
            }

            foreach (MemberInfo member in type.GetMembers(BindingFlags.Public | BindingFlags.Instance))
            {
                String message = "--> Is not tested!";
                Attribute attrib = member.GetCustomAttribute(typeof(IsTestedAttribute), true);
                if (attrib != null)
                    message = $"--> {attrib.ToString()}";
                Console.WriteLine($"Member: {member.Name} {message}");
            }
        }
    }
}
