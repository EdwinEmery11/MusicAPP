using System;
using System.Collections.Generic;

namespace MusicApplicationWebLibrary.Models
{
    public class Albums
    {
        public int ID { get; set; }//unique identifier
        public string Name { get; set; }
        public int Tracks { get; set; }
        public string PictureURL { get; set; }
        public Genre Genre { get; set; }
        public string Information { get; set; }
        public DateTime CreatedAt { get; set; }
        // this links to the songs relationships must be virtual
        public virtual List<Song> Songs { get; set; }

    }
}
