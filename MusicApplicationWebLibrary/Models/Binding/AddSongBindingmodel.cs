using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplicationWebLibrary.Models.Binding
{
    public class AddSongBindingmodel
    {
        
        public string PictureURL { get; set; }
        public string artistName { get; set; }
        public string TrackName { get; set; }
        public Genre Genre { get; set; }
        public Favourite Favourite { get; set;}
        public int AlbumID { get; set; }

    }
}