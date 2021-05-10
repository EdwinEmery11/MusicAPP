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
    public class SongControllerTest
    {
        private Mock<IRepositoryWrapper> mockRepo;
        private AddSongBindingmodel addSong;
        private Mock<IUpdateSong> updateSongMock;
        private Song aSong;
        private Song updateSong;
        private Mock<ISong> songMock;
        private List<ISong> songsMock;
        private List<Song> songs;
        private Mock<IAddSong> addSongsMock;
        private Mock<IUpdateSong> updateSongsMock;
        private Mock<IViewSong> songViewModelMock;
        private List<IViewSong> songsViewModelMock;
        private SongController songsController;
        public SongControllerTest()
        {
            //mock setup
            songMock = new Mock<ISong>();
            songsMock = new List<ISong> { songMock.Object };
            addSongsMock = new Mock<IAddSong>();
            updateSongMock = new Mock<IUpdateSong>();
            aSong = new Song();
            songs = new List<Song>();
            //viewmodels mock setup
            songViewModelMock = new Mock<IViewSong>();
            songsViewModelMock = new List<IViewSong>();

            //sample models
            addSong = new AddSongBindingmodel { };
            updateSong = new Song { };

            //controller setup
            var albumResultsMock = new Mock<IActionResult>();
            mockRepo = new Mock<IRepositoryWrapper>();
            var allSongs = GetSongs();
            songsController = new SongController(mockRepo.Object);
        }

        [Fact]
        //get all albums 
        public void GetAllSongs_test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Song.FindAll()).Returns(GetSongs());
            mockRepo.Setup(repo => repo.Song.FindByCondition(a => a.ID == It.IsAny<int>())).Returns(GetSongs());
            //Act
            var controllerActionResult = new SongController(mockRepo.Object).SongIndex(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);

        }

        //create album
        [Fact]
        public void AddSong_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Song.FindByCondition(a => a.ID == It.IsAny<int>())).Returns(GetSongs());
            //Act
            var controllerActionResult = new SongController(mockRepo.Object).SongIndex(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);

        }

        //Delete song  
        [Fact]
        public void DeleteSongs_Test()
        {
            //Arrange
            mockRepo.Setup(repo => repo.Song.FindByCondition(a => a.ID == It.IsAny<int>())).Returns(GetSongs());
            mockRepo.Setup(repo => repo.Song.Delete(GetSong()));
            //Act
            var controllerActionResult = new SongController(mockRepo.Object).Delete(It.IsAny<int>());
            //Assert
            Assert.NotNull(controllerActionResult);
        }

        private IEnumerable<Song> GetSongs()
        {
            var tSongs = new List<Song> {
            new Song(){ID = 1, artistName ="Drake", Genre=Genre.Pop, TrackName="Thinging about you", PictureURL="Hello" },
            new Song(){ID = 2, artistName ="Ice", Genre=Genre.Dancehall, TrackName="Thinging", PictureURL="Hello" },

            };
            return tSongs;
        }
        //private IEnumerable<Song> GetSongs()
        //{
        //    return new List<Song>()
        //    {
        //        new Song { ID = 1, artistName ="Drake", Genre=Genre.Pop, TrackName="Thinging about you", PictureURL="Hello" },
        //        //new Song { ID = 2, Song = GetSongs().ToList()[1] },
        //    };

        //}

        public Song GetSong()
        {
            return GetSongs().ToList()[0];
        }


    }
}
