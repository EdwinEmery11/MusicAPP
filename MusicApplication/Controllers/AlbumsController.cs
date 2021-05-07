using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicApplicationWebLibrary.Models;
using MusicApplicationWebLibrary.Models.Binding;
using MusicApplicationWebLibrary.Data;
using MusicApplicationWebLibrary.Repositories;
using MusicApplicationWebLibrary.Interfaces;

namespace MusicApplication.Controllers
{
    [Route("[Controller]")]
    public class AlbumsController : Controller
    {
        private IRepositoryWrapper repository;
        public AlbumsController(IRepositoryWrapper repositoryWrapper)//constructor 
        {
            repository = repositoryWrapper;
        }
        //read this file
        //READ
        public IActionResult Index()// show me all the albums that exist
        {
            var allAlbums = repository.Albums.FindAll();
            //var allAlbums = dbContext.Albums.ToList();
            // the view / the page that will show up will show all albums
            return View(allAlbums); //return a view
        }
        #region songonalbum controller
        //[Route("SongsonAlbum/{id:int}")]
        //public IActionResult SongsonAlbum(int id)// show me all the albums that exist
        //{
        //    var allsongs = repository.Song.FindAll();
        //    //var allSongs = dbContext.Songs.Where(s => s.Album.ID == id).ToList();
        //    // the view / the page that will show up will show all albums
        //    return View(allSongs); //return a view
        //}
#endregion 

        //GET DETAILS
        [Route("details/{id:int}")]//putting a placeholder 
        //maps directly to whatever is in the Details parameters
        public IActionResult Details(int id)// view the details of 1 album
        {
            //saying go to the details of the Album with this identity 
            //if it finds an album return that album with that ID
            var albumById = repository.Albums.FindByCondition(a => a.ID == id).FirstOrDefault();
            //var albumById = dbContext.Albums.FirstOrDefault(a => a.ID == id);
            return View(albumById);
        }
        //make the details come from a form 

        //CREATE
        [Route("create")]
        public IActionResult Create()//create an album
        {
            return View();
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(AddAlbumBindingModel bindingModel)
        {
            var albumToCreate = new Albums
            {
                Name = bindingModel.Name,
                Tracks = bindingModel.Tracks,
                PictureURL = "https://th.bing.com/th/id/Rf2b084b356e6001e681d6458c8ac9e0f?rik=IoKZA8E4mW2lzg&riu=http%3a%2f%2fwww.clique.tv%2fwp-content%2fuploads%2f2015%2f09%2fdrake-future-what-a-time-to-be-alive-album-cover-lead.jpg&ehk=8A3P%2fVHf0aKPpvyz3YOw3O3ic%2fKpv4v8mmKOLHUPmA4%3d&risl=&pid=ImgRaw",
                Genre = bindingModel.Genre,
                Information = bindingModel.Information,
                CreatedAt = DateTime.Now
            };
            repository.Albums.Create(albumToCreate);
            repository.save();
            //dbContext.SaveChange();
            return RedirectToAction("Index");
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)//update an album
        {
            var albumById = repository.Albums.FindByCondition(a => a.ID == id).FirstOrDefault();
            //var albumById = dbContext.Albums.FirstOrDefault(a => a.ID == id);
            return View(albumById);
        }
        [HttpPost]// modifying information
        [Route("update/{id:int}")]
        public IActionResult Update (Albums album, int id)
        {
            repository.Albums.Update(album);           
                repository.save();
            //dbContext.SaveChanges();
            //return redirecting back to the home page index
            return RedirectToAction("Index");
          }

        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)//delete an album
        {
            //every operation you must call dbcontext and save the changes 
            var albumToDelete = repository.Albums.FindByCondition(a => a.ID == id).FirstOrDefault();
            //var albumToDelete = dbContext.Albums.FirstOrDefault(a => a.ID == id);
            var songsInAlbum = repository.Song.FindByCondition(a => a.AlbumID == id);
            //var songsInAlbum = dbContext.Songs.Include(a => a.Album).Where(s => s.Album.ID == id);
            //repository.RemoveRange(songsInAlbum);
            foreach(var rSong in songsInAlbum)
            {
                repository.Song.Delete(rSong);
            }
            //dbContext.RemoveRange(songsInAlbum);
            repository.save();
            //dbContext.SaveChanges();
            repository.Albums.Delete(albumToDelete);
            //dbContext.Albums.Remove(albumToDelete);
            repository.save();
            //dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
    //shows us pages not performing actions here 
// loads pages for us 
//how we get the information from the database 
