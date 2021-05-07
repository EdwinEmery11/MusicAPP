using MusicApplicationWebLibrary.Data;
using MusicApplicationWebLibrary.Interfaces;
using MusicApplicationWebLibrary.Models;

namespace MusicApplicationWebLibrary.Repositories
{
    public class SongRepository: Repository<Song>, ISongRepository 
    {
        public SongRepository (ApplicationDbContext dbContext): base (dbContext)
        {

        }
    }
}
