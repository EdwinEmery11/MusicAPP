using Microsoft.AspNetCore.Mvc;
using Moq;
using MusicApplication.Controllers;
using MusicApplicationWebLibrary.Interfaces;
using MusicApplicationWebLibrary.Models;
using MusicApplicationWebLibrary.Models.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace MusicAppTest
{
    public class AlbumControllerTest
    {
        private Mock<IRepositoryWrapper> mockRepo;
        private AddAlbumBindingModel addAlbum;
        private Mock<IUpdateAlbum> updateAlbumMock;
        private Albums album;
        private Albums updateAlbum;
        private Mock<IAlbum> albumMock;
        private List<IAlbum> albumsMock;
        private List<Albums> albums;
        private Mock<IAddAlbum> addAlbumsMock;
        private Mock<IUpdateAlbum> updateAlbumsMock;
        private Mock<IViewAlbum> albumViewModelMock;
        private List<IViewAlbum> albumsViewModelMock;
        private AlbumsController albumsController;
        public AlbumControllerTest()
        {
            //mock setup
            albumMock = new Mock<IAlbum>();
            albumsMock = new List<IAlbum> { albumMock.Object };
            addAlbumsMock = new Mock<IAddAlbum>();
            updateAlbumMock = new Mock<IUpdateAlbum>();
            album = new Albums();
            albums = new List<Albums>();
            //viewmodels mock setup
            albumViewModelMock = new Mock<IViewAlbum>();
            albumsViewModelMock = new List<IViewAlbum>();

            //sample models
            addAlbum = new AddAlbumBindingModel { };
            updateAlbum = new Albums { };

            //controller setup
            var albumResultsMock = new Mock<IActionResult>();
            mockRepo = new Mock<IRepositoryWrapper>();
            var allAlbums = GetAlbums();
            albumsController = new AlbumsController(mockRepo.Object);
        }

        [Fact]
        //get all albums 
        public void GetAllAlbums_test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Albums.FindAll()).Returns(GetAlbums());
            mockRepo.Setup(repo => repo.Song.FindByCondition(r => r.AlbumID == It.IsAny<int>())).Returns(GetSongs());
            //Act
            var controllerActionResult = new AlbumsController(mockRepo.Object).Index();
            //Assert
            Assert.NotNull(controllerActionResult);

        }

        //create album
        [Fact]
        public void AddAlbum_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Albums.FindByCondition(a => a.ID == It.IsAny<int>())).Returns(GetAlbums());
            //Act
            var controllerActionResult = new AlbumsController(mockRepo.Object).Create();
            //Assert
            Assert.NotNull(controllerActionResult);
            
        }

        //Update Albums
        [Fact]    
        public void UpdateAlbums_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Albums.FindByCondition(c => c.ID == It.IsAny<int>())).Returns(GetAlbums());
            mockRepo.Setup(repo => repo.Albums.Update(GetAlbum()));
            //Act
            var controllerActionResult = new AlbumsController(mockRepo.Object).Update(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }


        //Delete album
        [Fact]
        public void DeleteAlbums_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Albums.FindByCondition(a => a.ID == It.IsAny<int>())).Returns(GetAlbums());
            mockRepo.Setup(repo => repo.Albums.Delete(GetAlbum()));
            //Act
            var controllerActionResult = new AlbumsController(mockRepo.Object).Delete(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }

        private IEnumerable<Albums> GetAlbums()
        {
            var tAlbums = new List<Albums> {
            new Albums(){ID=1, Name="CS101", Tracks=11, Information= "1", Genre=Genre.HipHop, PictureURL="Hello"},
            new Albums(){ID=2, Name="CS102", Tracks=11, Information= "1", Genre=Genre.HipHop, PictureURL="Hello"},
            new Albums(){ID=3, Name="CS103", Tracks=11, Information= "1", Genre=Genre.HipHop, PictureURL="Hello"},
            new Albums(){ID=4, Name="CS104", Tracks=11, Information= "1", Genre=Genre.HipHop, PictureURL="Hello"},
            new Albums(){ID=5, Name="CS105", Tracks=11, Information= "1", Genre=Genre.HipHop, PictureURL="Hello"},

            };
            return tAlbums;
        }
        private IEnumerable<Song> GetSongs()
        {
            return new List<Song>()
            {
                new Song { ID = 1, Album = GetAlbums().ToList()[0] },
                //new Song { ID = 2, Album = GetAlbums().ToList()[1] },
            };

        }

        public Albums GetAlbum()
        {
            return GetAlbums().ToList()[0];
        }


    }
}
