using MusicStore.Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.Logic
{
    public class ModelFactory
    {
        public static Contracts.IArtist GetArtist()
        {
            return new Artist();
        }

        public static Contracts.Models.IAlbum CreateAlbum()
        {
            return new Album();
        }
    }
}
