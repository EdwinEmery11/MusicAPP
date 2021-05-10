using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicApplicationWebLibrary.Repositories;

namespace MusicApplicationWebLibrary.Interfaces
{// the wrapper is called all the tables orm in the database is called and changes are saved to the database
    public interface IRepositoryWrapper
    {
        IAlbumsRepository Albums { get; }
        ISongRepository Song { get; }
        void save();
    }

}
