using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicApplicationWebLibrary.Models;
using MusicApplication.Data;
using MusicApplicationWebLibrary.Models.Binding;

namespace MusicApplication.Controllers
{
    [Route("[Controller]")]
    public class AlbumsController : Controller
    {
        private readonly ApplicationDbContext dbContext;//dependancy injection
        //operation mapper
        public AlbumsController(ApplicationDbContext applicationDbContext)//constructor 
        {
            dbContext = applicationDbContext;
        }
        //read this file
        //READ
        public IActionResult Index()// show me all the albums that exist
        {
            var allAlbums = dbContext.Albums.ToList();
            // the view / the page that will show up will show all albums
            return View(allAlbums); //return a view
        }

        [Route("SongsonAlbum/{id:int}")]
        public IActionResult SongsonAlbum(int id)// show me all the albums that exist
        {
            var allSongs = dbContext.Songs.Where(s => s.Album.ID == id).ToList();
            // the view / the page that will show up will show all albums
            return View(allSongs); //return a view
        }

        //GET DETAILS
        [Route("details/{id:int}")]//putting a placeholder 
        //maps directly to whatever is in the Details parameters
        public IActionResult Details(int id)// view the details of 1 album
        {
            //saying go to the details of the Album with this identity 
            //if it finds an album return that album with that ID
            var albumById = dbContext.Albums.FirstOrDefault(a => a.ID == id);
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
            var albumToCreate = new Album
            {
                Name = bindingModel.Name,
                Tracks = bindingModel.Tracks,
                PictureURL = "https://th.bing.com/th/id/Rf2b084b356e6001e681d6458c8ac9e0f?rik=IoKZA8E4mW2lzg&riu=http%3a%2f%2fwww.clique.tv%2fwp-content%2fuploads%2f2015%2f09%2fdrake-future-what-a-time-to-be-alive-album-cover-lead.jpg&ehk=8A3P%2fVHf0aKPpvyz3YOw3O3ic%2fKpv4v8mmKOLHUPmA4%3d&risl=&pid=ImgRaw",
                Genre = bindingModel.Genre,
                Information = bindingModel.Information,
                CreatedAt = DateTime.Now
            };
            dbContext.Albums.Add(albumToCreate);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


        //UPDATE
        [Route("update/{id:int}")]
        public IActionResult Update(int id)//update an album
        {
            var albumById = dbContext.Albums.FirstOrDefault(a => a.ID == id);
            return View(albumById);
        }
        [HttpPost]// modifying information
        [Route("update/{id:int}")]
        public IActionResult Update (Album album, int id)
        { //what to find the album with that ID
          //need to get the album out the database
          //where the album id matches the id of the album I want to modify 
            var albumToUpdate = dbContext.Albums.FirstOrDefault(a => a.ID == id);
           //map all the properties to modify 
                albumToUpdate.Name = album.Name;
                albumToUpdate.Tracks = album.Tracks;
                albumToUpdate.PictureURL = album.PictureURL;
                albumToUpdate.Genre = album.Genre;
            albumToUpdate.Information = album.Information;   
            //because weve reassigned values we need to save the changes 
                dbContext.SaveChanges();
            //return redirecting back to the home page index
                return RedirectToAction("Index");
          }

        //DELETE
        [Route("delete/{id:int}")]
        public IActionResult Delete(int id)//delete an album
        {
            //every operation you must call dbcontext and save the changes 
            var albumToDelete = dbContext.Albums.FirstOrDefault(a => a.ID == id);
            var songsInAlbum = dbContext.Songs.Include(a => a.Album).Where(s => s.Album.ID == id);
            dbContext.RemoveRange(songsInAlbum);
            dbContext.SaveChanges();
            dbContext.Albums.Remove(albumToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
    //shows us pages not performing actions here 
// loads pages for us 
//how we get the information from the database 
