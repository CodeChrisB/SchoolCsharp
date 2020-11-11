using System;

namespace MusicStore.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Contracts.IArtist artist = Logic.ModelFactory.GetArtist();

            artist.Name = "AC/DC";
        
        }
    }
}
