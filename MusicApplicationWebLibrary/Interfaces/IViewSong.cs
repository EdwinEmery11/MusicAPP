using MusicApplicationWebLibrary.Models;

namespace MusicApplicationWebLibrary.Interfaces
{
    public interface IViewSong
    {
        public int ID { get; set; }
        public string PictureURL { get; set; }
        public string artistName { get; set; }
        public string TrackName { get; set; }
        public Genre Genre { get; set; }
        public Favourite Favourite { get; set; }
        public int AlbumID { get; set; }
        //1 song can only be linked to one album
        //declare it as a field also 
        //virtual keyword creates the relationship


    }
}
