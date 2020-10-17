using DemoLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
    class Program
    {

        static List<Student> Students { get; } = new List<Student>
        { 
            new Student { Id =2013001, Name = "Bety", Subject ="Math"},
            new Student { Id =2012002, Name = "Adam", Subject ="Computing"},
            new Student { Id =2011003, Name = "Chris", Subject ="Teamleading"},
            new Student { Id =2014004, Name = "Dora", Subject ="Science"}
        };
        static List<Marking> Marks { get; } = new List<Marking> 
        { 
            new Marking {Id =1, StudentId =2012001, Course=" Programming" ,Mark =1},
            new Marking {Id =2, StudentId =2011001, Course=" Database" ,Mark =2},
            new Marking {Id =3, StudentId =2014001, Course=" Webtechnology" ,Mark =3},
            new Marking {Id =4, StudentId =2013001, Course=" Math" ,Mark =2},
            new Marking {Id =5, StudentId =2012001, Course=" Biology" ,Mark =5},
            new Marking {Id =6, StudentId =2014001, Course=" NVS" ,Mark =2},
            new Marking {Id =7, StudentId =2011001, Course=" PROO" ,Mark =1}
        };

        static void Main(string[] args)
        {
           
            var result = from s in Students
                         join m in Marks on s.Id equals m.StudentId
                         group s by s.Subject;

            foreach(var item in result){
                Console.WriteLine(item.Key);
            }

            Console.WriteLine("--------------------------");

            var result2 = from s in Students
                          group s by s.Subject;

            foreach (var item in result2)
            {
                Console.WriteLine(item.Key);
                foreach(var item2 in item.Select(s => new {s.Id, s.Name }))
                {
                    Console.WriteLine($"\t{item2.Id}-{item2.Name}");
                }
            }

            Console.WriteLine("--------------------------");
            var result3 = from s in Students
                          group s by s.Subject into g
                          select new { Subject = g.Key, N = g.Count() };

            foreach(var item in result3)
            {
                Console.WriteLine($"{item.Subject} - {item.N}");
            }

            Console.WriteLine("--------------------------");
            var result4 = from s in Students
                          join m in Marks on s.Id equals m.StudentId
                          select new { s.Name, m.Course, m.Mark };

            foreach (var item in result4)
            {
                Console.WriteLine(item.ToString().Substring(1,item.ToString().Length-3).Replace(',',' '));
            }


            Console.WriteLine("--------------------------");
            var result5 = from s in Students
                          join m in Marks on s.Id equals m.StudentId into list
                          select new { s.Name, Marks = list };

            foreach (var item in result5)
            {
                Console.WriteLine(item.Name);
                foreach(var item2 in item.Marks)
                {
                    Console.WriteLine($"{item2.Course} - {item2.Mark}");

                }
            }


            Console.WriteLine("--------------------------");
            var result6 = from s in Students
                          let year = s.Id / 1000
                          where year == 2012
                          select s;

            foreach (var item in result6)
            {
                Console.WriteLine($"{item.Id}-{item.Name}");
            }


            Console.WriteLine("--------------------------");
            var result7 = from s in Students
                          join m in Marks on s.Id equals m.StudentId
                          where m.Mark == 5
                          select s;
                          
            foreach (var item in result7)
            {
                Console.WriteLine(item.Name);
            }




        }
    }
}
