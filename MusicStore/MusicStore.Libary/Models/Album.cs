using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    public class Album : ObjectModel
    {
    
        public string title { get; set; }
        public Artist artist { get; set; }
        public int ArtistId { get; set; }


        public override string ToString()
        {
            return $"{ArtistId},{title},{artist}";
        }
    }
}
