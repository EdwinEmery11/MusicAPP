using MusicApplicationWebLibrary.Data;
using MusicApplicationWebLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplicationWebLibrary.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        ApplicationDbContext _repoContext;
        public RepositoryWrapper(ApplicationDbContext repoContext)
        {
            _repoContext = repoContext;
        }
         IAlbumsRepository _albums;

         ISongRepository _songs;

        //public method to do the assignment for private methods
        public IAlbumsRepository Albums
        {
            get
            {
                if (_albums == null)
                {
                    _albums = new AlbumsRepository(_repoContext);
                }
                return _albums;
            }
        }
        public ISongRepository Song
        {
            get
            {
                if (_songs == null)
                {
                    _songs = new SongRepository(_repoContext);
                }
                return _songs;
            }
        }

        void IRepositoryWrapper.save()
        {
            _repoContext.SaveChanges();
        }
    }
}
