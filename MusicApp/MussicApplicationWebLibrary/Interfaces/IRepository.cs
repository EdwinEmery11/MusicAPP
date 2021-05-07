using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplicationWebLibrary.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> FindAll();
        // takes a method in takes expression in as its own argument  
        // these are the contracts created - things we want to happen for the repository
        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);

    }
}
