using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApplication.Data;
using MusicApplication.Migrations;
using MusicApplicationWebLibrary.Models;
using MusicApplicationWebLibrary.Models.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Controllers
{
    [Route("[Controller]")]
    public class SongController : Controller
    {
        private readonly ApplicationDbContext dbContext;//dependancy injection
        //operation mapper
        public SongController(ApplicationDbContext applicationDbContext)//constructor 
        {
            dbContext = applicationDbContext;
        }

        //READ
        [Route("SongIndex/{id:int}")]
        public IActionResult SongIndex(int id)// show me all the Songs that exist
        {
            ViewBag.AlbumID = id;
            var allSongs = dbContext.Songs.Where(s => s.Album.ID == id).ToList();
            // the view / the page that will show up will show all albums
            return View(allSongs); //return a view
        }
        //make the details come from a form 

        //CREATE
        [Route("SongCreate/{id:int}")]
        public IActionResult SongCreate(int id)//create an Song
        {
            AddSongBindingmodel bindingmodel = new AddSongBindingmodel()
            {
                AlbumID = id
            };
            //ViewBag.AlbumID = id;
            ViewData["AlbumID"] = id;
            return View(bindingmodel);
        }
        [HttpPost]
        [Route("SongCreate/{id:int}")]
        public IActionResult SongCreate(AddSongBindingmodel bindingModel, int id)
        {
            
            var SongsToCreate = new Song
            {

                artistName = bindingModel.artistName,
                TrackName = bindingModel.TrackName,
                PictureURL = "https://th.bing.com/th/id/Rf2b084b356e6001e681d6458c8ac9e0f?rik=IoKZA8E4mW2lzg&riu=http%3a%2f%2fwww.clique.tv%2fwp-content%2fuploads%2f2015%2f09%2fdrake-future-what-a-time-to-be-alive-Song-cover-lead.jpg&ehk=8A3P%2fVHf0aKPpvyz3YOw3O3ic%2fKpv4v8mmKOLHUPmA4%3d&risl=&pid=ImgRaw",
                Genre = bindingModel.Genre,
                Favourite = bindingModel.Favourite,
                Album=dbContext.Albums.FirstOrDefault(a=>a.ID==id)
            };
            //entity - means give back the created object
            //entity field is the song that has been created in song create
            var songAdded = dbContext.Songs.Add(SongsToCreate).Entity;
            dbContext.SaveChanges();         
            return RedirectToAction("SongIndex",new { id = id});
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)//update an Song
        {
            var SongById = dbContext.Songs.Include(a => a.Album).FirstOrDefault(a => a.ID == id);
            var albumID = SongById.Album.ID;
            ViewData["AlbumID"] = albumID;
            return View(SongById);
        }
        [HttpPost]// modifying information
        [Route("Update/{id:int}")]
        public IActionResult Update(Song Song, int id)
        { //what to find the Song with that ID
          //need to get the Song out the database
          //where the Song id matches the id of the Song I want to modify 
            var SongsToUpdate = dbContext.Songs.Include(a => a.Album).FirstOrDefault(s => s.ID == id);
            var albumID = SongsToUpdate.Album.ID;    
            //map all the properties to modify 
            SongsToUpdate.artistName = Song.artistName;
            SongsToUpdate.TrackName = Song.TrackName;
            SongsToUpdate.PictureURL = Song.PictureURL;
            SongsToUpdate.Genre = Song.Genre;
            SongsToUpdate.Favourite = Song.Favourite;
            //because weve reassigned values we need to save the changes 
            dbContext.SaveChanges();
            //return redirecting back to the home page index
            return RedirectToAction("SongIndex", new { id = albumID });
        }

        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)//delete an Song
        {
            //every operation you must call dbcontext and save the changes 
            var SongToDelete = dbContext.Songs.Include(a => a.Album).FirstOrDefault(s => s.ID == id);
            var albumID = SongToDelete.Album.ID;
            //var SongToDelete = dbContext.Songs.FirstOrDefault(a => a.ID == id);
            dbContext.Songs.Remove(SongToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("SongIndex", new { id = albumID });
        }


    }
}
