using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MusicApplicationAPI.Data;
using MusicApplicationWebLibrary.Models;
using MusicApplicationWebLibrary.Models.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public SongsController(ApplicationDbContext ApplicationDbContext)
        {
            dbContext = ApplicationDbContext;

        }
        [HttpGet("")]
        public IActionResult GetAllSongs()
        {
            var allSongs = dbContext.Songs.ToList();
            // the view / the page that will show up will show all Songs
            return Ok(allSongs); //return a view
        }
        [HttpPost("")]
        public IActionResult CreateSong([FromBody]AddSongBindingmodel bindingModel)
        {
            var SongsToCreate = new Song
            {
                artistName = bindingModel.artistName,
                TrackName = bindingModel.TrackName,
                PictureURL = "https://th.bing.com/th/id/Rf2b084b356e6001e681d6458c8ac9e0f?rik=IoKZA8E4mW2lzg&riu=http%3a%2f%2fwww.clique.tv%2fwp-content%2fuploads%2f2015%2f09%2fdrake-future-what-a-time-to-be-alive-Song-cover-lead.jpg&ehk=8A3P%2fVHf0aKPpvyz3YOw3O3ic%2fKpv4v8mmKOLHUPmA4%3d&risl=&pid=ImgRaw",
                Genre = bindingModel.Genre,
                Favourite = bindingModel.Favourite,
                //Album=dbContext.Albums.FirstOrDefault(a=>a.ID==bindingModel.AlbumID)
            };
           var createdSong = dbContext.Songs.Add(SongsToCreate).Entity;
            dbContext.SaveChanges();
            return Ok(createdSong);
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateSong ([FromBody] Song Song, int id)
        {
            var songById = dbContext.Songs.FirstOrDefault(a => a.ID == id);
            if (songById == null)
                return NotFound();
            //map all the properties to modify 
            songById.artistName = Song.artistName;
            songById.TrackName = Song.TrackName;
            songById.PictureURL = Song.PictureURL;
            songById.Genre = Song.Genre;
            songById.Favourite = Song.Favourite;
            //because weve reassigned values we need to save the changes 
            dbContext.SaveChanges();
            return Ok(songById);

        }

        [HttpDelete("{id:int}")]// needs the id of the song to know what to delete
        public IActionResult DeleteSong(int id)
        {
            var songsToDelete = dbContext.Songs.FirstOrDefault(c => c.ID == id);
            if (songsToDelete == null)
                return NotFound();
            dbContext.Songs.Remove(songsToDelete);
            dbContext.SaveChanges();
            return NoContent();
        }

    }
}
