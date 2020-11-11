using CsvSimpleMapper.Logic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;

namespace CsvSimpleMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Person> people = new List<Person>();

            Console.WriteLine("a for automatic list");
            string ch = Console.ReadKey().ToString().ToLower();
            if (ch == "a")
            {
                people = autoCreatePerson();
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    people.Add(createPerson());
                }
            }

            CSVHelper.Write(people);
            

        }

        public static List<Person> autoCreatePerson()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person(1,"Max", "Müller"));
            people.Add(new Person(2,"Chris", "Chung"));
            people.Add(new Person(3,"Sebastian", "Buchberger"));
            people.Add(new Person(4,"Julian", "Egger"));
            people.Add(new Person(5,"Kevin", "Fellinger"));

            return people;
        }



        public static Person createPerson()
        {
            Console.Write("Firstname :");
            string fname = Console.ReadLine();
            Console.Write("Last :");
            string lname = Console.ReadLine();
            Console.Write("Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"{fname} {lname}");
            return new Person(id,fname, lname);
        }
    }
}
