using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    public partial class Genre : ObjectModel
    {
       
        public override string ToString()
        {
            return $"{Id},{Name},";
        }
    }
}
