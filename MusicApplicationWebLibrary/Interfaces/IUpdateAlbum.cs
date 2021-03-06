using MusicApplicationWebLibrary.Models;
using System;
using System.Collections.Generic;

namespace MusicApplicationWebLibrary.Interfaces
{// the wrapper is called all the tables orm in the database is called and changes are saved to the database
    public interface IUpdateAlbum
    {
       
        public string Name { get; set; }
        public int Tracks { get; set; }
        public string PictureURL { get; set; }
        public Genre Genre { get; set; }
        public string Information { get; set; }
        public DateTime CreatedAt { get; set; }
        // this links to the songs relationships must be virtual
       // public virtual List<Song> Songs { get; set; }
    }

}
