using MusicApplicationWebLibrary.Data;
using MusicApplicationWebLibrary.Interfaces;
using MusicApplicationWebLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplicationWebLibrary.Repositories
{
    public class AlbumsRepository: Repository<Albums>, IAlbumsRepository 
    {
        public AlbumsRepository (ApplicationDbContext dbContext): base (dbContext)
        {

        }
    } 
}
