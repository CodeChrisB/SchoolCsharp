using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    public class Track : ObjectModel
    {

        //Id;Name;AlbumId;GenreId;Composer;Milliseconds;Bytes;UnitPrice
     
        public int AlbumId { get; set; }

        public int GenreId { get; set; }

        public string Composer { get; set; }

        public int Milliseconds { get; set; }
        public int Bytes { get; set; }

        public int UnitPrice { get; set; }


        public override string ToString()
        {
            return $"{Name},{AlbumId},{GenreId},{Composer},{Milliseconds},{Bytes},{UnitPrice}";
        }
    }
}
