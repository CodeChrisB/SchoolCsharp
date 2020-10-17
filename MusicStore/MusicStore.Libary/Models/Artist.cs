using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    public class Artist : ObjectModel
    {
        public string ArtistId { get; set; }
        public override string ToString()
        {
            return $"{Id},{Name},";
        }
    }
}
