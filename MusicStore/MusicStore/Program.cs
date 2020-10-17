using System;
using System.IO;
using System.Linq;
using System.Text;
using MusicStore.Libary;

namespace MusicStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MusicStore");

            Logic logic = new Logic();

            Genre[] generes = logic.Generes;
            Artist[] artists = logic.Artists;
            Album[] albums = logic.Albums;
            Track[] track = logic.Track;

            bool run = true;

            while (run)
            {

                Console.WriteLine("What should I open ?");
                Console.WriteLine("A -> Albums");
                Console.WriteLine("B -> Artists");
                Console.WriteLine("C -> Genres");
                Console.WriteLine("D -> Tracks");
                Console.WriteLine("E -> Filter");
                Console.WriteLine("F -> Exit programm");

                Console.Write("Your input : ");
                ConsoleKeyInfo cki = Console.ReadKey();
                Console.WriteLine("");

                string s = cki.Key.ToString().ToLower();

                switch (s)
                {
                    case "a":
                        print(albums);
                        break;
                    case "b":
                        print(artists);
                    break;
                    case "c":
                        print(generes);
                    break;
                    case "d":
                        print(track);
                    break;
                    case "e":
                        filter();
                        break;
                    case "f":
                        run = false;
                        break;
                }


            }

            static void print(ObjectModel[] om)
            {
                foreach (ObjectModel model in om)
                {
                    Console.WriteLine(model.ToString());
                }
                Console.WriteLine("Press any to to proceed");
                Console.ReadLine();
                Console.Clear();
            }

        }

        private static void filter()
        {
            Console.WriteLine("What should I filter ?");
            Console.WriteLine("A -> Albums");
            Console.WriteLine("B -> Artists");
            Console.WriteLine("C -> Genres");
            Console.WriteLine("D -> Tracks");

            Console.Write("Your input : ");
            ConsoleKeyInfo cki = Console.ReadKey();
            Console.WriteLine("");
            string what = cki.Key.ToString().ToLower();

            Console.WriteLine("By what should I filter ?");
            Console.WriteLine("A -> Id");
            Console.WriteLine("B -> Name");

            Console.Write("Your input : ");
            cki = Console.ReadKey();
            Console.WriteLine("");
            string how = cki.Key.ToString().ToLower();
            Func<bool> fun = getFunc();

            Logic l = new Logic();

            switch (what)
            {
                case "a":
                    print(l.Albums);
                    break;
                case "b":
                    print(l.Artists);
                    break;
                case "c":
                    print(l.Generes);
                    break;
                case "d":
                    print(l.Tracks);
                    break;
                case "e":
                    filter();
                    break;
                case "f":
                    run = false;
                    break;
            }



        }

        private static Func<bool> getFunc(string what)
        {
           if (what == "a")
           {
              return new Func<bool> =   
           }
        }

        private static void print(object albums)
        {
            throw new NotImplementedException();
        }
    }
