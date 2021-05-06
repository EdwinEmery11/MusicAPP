using Microsoft.EntityFrameworkCore;
using MusicApplicationWebLibrary.Data;
using MusicApplicationWebLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicApplicationWebLibrary.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ApplicationDbContext RepositoryContext { get; set; }
        public Repository (ApplicationDbContext repositoryContext)
        {
            RepositoryContext = repositoryContext;

        }
        public T Create(T entity)
        {
            //.set<T>takes whatever class youre passing into the generic Repository
            //and makes it this way so it will be repositorycontext which is application dbcontext
            // is it . anything 
            //add the entity we are passing in because we are returning type T we have to return
            //the entity to the database
            return RepositoryContext.Set<T>().Add(entity).Entity;
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public IEnumerable<T> FindAll()
        {
            // Do not want to be notified of any changes that happens here 
            return RepositoryContext.Set<T>().AsNoTracking();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public T Update(T entity)
        {
            return RepositoryContext.Set<T>().Update(entity).Entity;
        }
    }
}
