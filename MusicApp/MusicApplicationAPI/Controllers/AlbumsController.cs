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
    public class AlbumsController : ControllerBase
    {
        //Database connection
        private readonly ApplicationDbContext dbContext;
        public AlbumsController(ApplicationDbContext ApplicationDbContext)
        {
            dbContext = ApplicationDbContext;

        }
        //Index Read
        [HttpGet("")]
        public IActionResult GetAllAlbums()
        {
            var allAlbums = dbContext.Albums.ToList();
            // the view / the page that will show up will show all Albums
            return Ok(allAlbums); //return a view
        }

        //Details
        [HttpGet("{id:int}")]
        public IActionResult GetAlbumById(int id)
        {
            var albumById = dbContext.Albums.FirstOrDefault(c => c.ID == id);
            if (albumById == null)
                return NotFound();
            return Ok(albumById);
        }
        //Create
        [HttpPost("")]
        public IActionResult CreateAlbum([FromBody] AddAlbumBindingModel bindingModel)
        {
            var AlbumToCreate = new Album
            {
                Name = bindingModel.Name,
                Tracks = bindingModel.Tracks,
                PictureURL = "https://th.bing.com/th/id/Rf2b084b356e6001e681d6458c8ac9e0f?rik=IoKZA8E4mW2lzg&riu=http%3a%2f%2fwww.clique.tv%2fwp-content%2fuploads%2f2015%2f09%2fdrake-future-what-a-time-to-be-alive-album-cover-lead.jpg&ehk=8A3P%2fVHf0aKPpvyz3YOw3O3ic%2fKpv4v8mmKOLHUPmA4%3d&risl=&pid=ImgRaw",
                Genre = bindingModel.Genre,
                Information = bindingModel.Information,
                CreatedAt = DateTime.Now
            };
            var createdAlbum = dbContext.Albums.Add(AlbumToCreate).Entity;
            dbContext.SaveChanges();
            return Ok(createdAlbum);
        }

        //Update
        [HttpPut("{id:int}")]
        public IActionResult UpdateAlbum([FromBody] Album Album, int id)
        {
            var AlbumById = dbContext.Albums.FirstOrDefault(a => a.ID == id);
            if (AlbumById == null)
                return NotFound();
            //map all the properties to modify 
            AlbumById.Name = Album.Name;
            AlbumById.Tracks = Album.Tracks;
            AlbumById.PictureURL = Album.PictureURL;
            AlbumById.Genre = Album.Genre;
            AlbumById.Information = Album.Information;
            //because weve reassigned values we need to save the changes 
            dbContext.SaveChanges();
            return Ok(AlbumById);

        }

        //Delete
        [HttpDelete("{id:int}")]// needs the id of the Album to know what to delete
        public IActionResult DeleteAlbum(int id)
        {
            var AlbumsToDelete = dbContext.Albums.FirstOrDefault(c => c.ID == id);
            if (AlbumsToDelete == null)
                return NotFound();
            dbContext.Albums.Remove(AlbumsToDelete);
            dbContext.SaveChanges();
            return NoContent();
        }
    }
}
