using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MusicApplicationWebLibrary.Data;
using MusicApplicationWebLibrary.Interfaces;
using MusicApplicationWebLibrary.Models;
using MusicApplicationWebLibrary.Models.Binding;
using MusicApplicationWebLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApplication.Controllers
{
    [Route("[Controller]")]
    public class SongController : Controller
    {
        private IRepositoryWrapper repository;
        public SongController(IRepositoryWrapper repositoryWrapper)//constructor 
        {
            repository = repositoryWrapper;
        }

        //READ
        [Route("SongIndex/{id:int}")]
        public IActionResult SongIndex(int id)// show me all the Songs that exist
        {
            ViewBag.AlbumID = id;
            var allSongs = repository.Song.FindByCondition(s => s.Album.ID == id).ToList();
            //var allSongs = dbContext.Songs.Where(s => s.Album.ID == id).ToList();
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
                AlbumID = id
                //Album=dbContex.Albums.FirstOrDefault(a=>a.ID==id)
            };
        //entity - means give back the created object
        //entity field is the song that has been created in song create
        var songAdded = repository.Song.Create(SongsToCreate);
        //var songAdded = dbContext.Songs.Add(SongsToCreate).Entity;
            repository.save();         
            return RedirectToAction("SongIndex",new { id = songAdded.AlbumID});
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)//update an Song
        {
            var SongById = repository.Song.FindByCondition(a => a.ID == id).FirstOrDefault();
            var albumID = SongById.AlbumID;
            ViewData["AlbumID"] = albumID;
            return View(SongById);
        }
        [HttpPost]// modifying information
        [Route("Update/{id:int}")]
        public IActionResult Update(Song Song, int id)
        {
            repository.Song.Update(Song);
            repository.save();
            //return redirecting back to the home page index
            return RedirectToAction("SongIndex", new { id = Song.AlbumID });
        }
        //delete
        //delete
        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)//delete an Song
        {
            //every operation you must call dbcontext and save the changes 
            var SongToDelete = repository.Song.FindByCondition(a => a.ID == id).FirstOrDefault();
            repository.Song.Delete(SongToDelete);
            repository.save();
            return RedirectToAction("SongIndex", new { id = SongToDelete.AlbumID });
        }


    }
}
