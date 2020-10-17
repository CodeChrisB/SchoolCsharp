using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MusicStore.Libary
{
    public class Logic
    {

        public Genre[] Generes { get; }
        public Artist[] Artists { get; }
        public Album[] Albums { get; }
        public Track[] Track { get; }
        public Track[] Tracks { get; }

        
    


        public ObjectModel[] Filter(ObjectModel[] list,string name)
        {
           return list.Where(t => t.Name == name).ToArray();
        }

             

    public Logic()
        {
            //genre
            Generes = File.ReadAllLines("CSVData/Genre.csv", Encoding.UTF8)
                .Select(l => l.Split(';'))
                .Skip(1)
                .Select(data => new Genre
                {
                    Id = Convert.ToInt32(data[0]),
                    Name = data[1]
                }).ToArray();

            //artist
            Artists = File.ReadAllLines("CSVData/Artist.csv", Encoding.UTF8)
                .Select(l => l.Split(';'))
                .Skip(1)
                .Select(data => new Artist
                {
                    Id = Convert.ToInt32(data[0]),
                    Name = data[1]
                }).ToArray();


            //album
            Albums = File.ReadAllLines("CSVData/Album.csv", Encoding.UTF8)
                .Select(l => l.Split(';'))
                .Skip(1)
                .Select(data => new Album
                {
                    Id = Convert.ToInt32(data[0]),
                    title = data[1],
                    ArtistId = Convert.ToInt32(data[2]),
                    artist = Artists.SingleOrDefault(e => e.Id == Convert.ToInt32(data[2]))
                }).ToArray();

            //Track
            //Id;Name;AlbumId;GenreId;Composer;Milliseconds;Bytes;UnitPrice
            Track = File.ReadAllLines("CSVData/Track.csv", Encoding.UTF8)
                .Select(l => l.Split(';'))
                .Skip(1)
                .Select(data => new Track
                {
                    Id = Convert.ToInt32(data[0]),
                    Name = data[1],
                    AlbumId = Convert.ToInt32(data[2]),
                    GenreId = Convert.ToInt32(data[3]),
                    Composer = data[4],
                    Milliseconds = Convert.ToInt32(data[5]),
                    Bytes = Convert.ToInt32(data[6]),
                    UnitPrice = 1
                }).ToArray();

        }
    }
}
