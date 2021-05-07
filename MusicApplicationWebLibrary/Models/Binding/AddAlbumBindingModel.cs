using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplicationWebLibrary.Models.Binding
{
    public class AddAlbumBindingModel
    {   
        public string Name { get; set; }
        public int Tracks { get; set; }       
        public Genre Genre { get; set; }
        public string Information { get; set; }
        public string PictureURL { get; set; }
    }
}
