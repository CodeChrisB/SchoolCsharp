using DemoReflection.Attributes;
using System;
using System.Linq;
using System.Reflection;

namespace DemoReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Reflection");

            Person person = new Person();

            Type type = person.GetType();
            Console.WriteLine(type.Name.Split(".")[0]);

            Person p2 = CreateInstance<Person>();

            Student s1 = CreateInstance<Student>();
            

            PrintType<Person>(null);
            PrintType<Student>(null);
        }

        static void PrintType<T>(T obj)
        {
            //if (p == null) throw new ArgumentNullException();

            Type type = obj != null ? obj.GetType() : typeof(T);
            Console.WriteLine($"{MethodBase.GetCurrentMethod().Name}");
            
            //Data Class Attribute
            var dca =type.GetCustomAttribute<DataClassAttribute>();
            Console.WriteLine($"Tpe: {type.Name} IsDataClass {dca !=null}");


            foreach(var item in type.GetProperties())
            {
                Console.WriteLine($"\titem.Name: {item.PropertyType.Name}");
                if(item.CanRead)
                    Console.WriteLine($"\treadable");

                if(item.CanWrite)
                    Console.WriteLine($"\tWriteable");
                
                0if (item.GetCustomAttribute<DataPropertyInfoAttribute>().isRequierd)
                    Console.WriteLine($"\tIsRequired");
                else
                    Console.WriteLine($"\tNotRequired");

            }

            Console.WriteLine("\n\nMethods");
            foreach(var item in type.GetMethods())
            {
                Console.WriteLine($"\t{item.Name}");
            }
            Console.WriteLine();
        }

        static T CreateInstance<T>() where T : new()
        {
            T result = new T();

            foreach(var item in 
                result
                .GetType()
                .GetProperties()
                .Where(p => p.PropertyType == typeof(String)&& 
                p.CanWrite))
            {
                object value = item.GetValue(result);
                
                if(value == null)
                {
                    item.SetValue(result, String.Empty);
                }
                return result;
            }

            return default(T);
        }
    }
}
