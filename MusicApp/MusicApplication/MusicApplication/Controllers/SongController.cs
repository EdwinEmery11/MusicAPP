using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()// show me all the Songs that exist
        {
            var allSongs = dbContext.Songs.ToList();
            // the view / the page that will show up will show all Songs
            return View(allSongs); //return a view
        }
        //make the details come from a form 

        //CREATE
        [Route("songCreate")]
        public IActionResult create()//create an Song
        {
            return View();
        }
        [HttpPost]
        [Route("songCreate")]
        public IActionResult create(AddSongBindingmodel bindingModel)
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
            dbContext.Songs.Add(SongsToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)//update an Song
        {
            var SongById = dbContext.Songs.FirstOrDefault(a => a.ID == id);
            return View(SongById);
        }
        [HttpPost]// modifying information
        [Route("Update/{id:int}")]
        public IActionResult Update(Song Song, int id)
        { //what to find the Song with that ID
          //need to get the Song out the database
          //where the Song id matches the id of the Song I want to modify 
            var SongsToUpdate = dbContext.Songs.FirstOrDefault(a => a.ID == id);
            //map all the properties to modify 
            SongsToUpdate.artistName = Song.artistName;
            SongsToUpdate.TrackName = Song.TrackName;
            SongsToUpdate.PictureURL = Song.PictureURL;
            SongsToUpdate.Genre = Song.Genre;
            SongsToUpdate.Favourite = Song.Favourite;
            //because weve reassigned values we need to save the changes 
            dbContext.SaveChanges();
            //return redirecting back to the home page index
            return RedirectToAction("Index");
        }

        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)//delete an Song
        {
            //every operation you must call dbcontext and save the changes 
            var SongToDelete = dbContext.Songs.FirstOrDefault(a => a.ID == id);
            dbContext.Songs.Remove(SongToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
