using ComicBook.Api.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Commons
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        private readonly ComicBookContext _comicBookContext;

        public GenericRepository(ComicBookContext comicBookContext)
        {
            _comicBookContext = comicBookContext;

        }

        public virtual void Delete(int id)
        {
            _comicBookContext.Remove(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _comicBookContext.Set<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return _comicBookContext.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public virtual void Insert(TEntity entityToInsert)
        {
            _comicBookContext.Set<TEntity>().Add(entityToInsert);
        }

        public virtual void SaveChanges()
        {
            _comicBookContext.SaveChanges();
        }

        public virtual void Update(int id, TEntity entityToUpdate)
        {
            _comicBookContext.Set<TEntity>().Update(entityToUpdate);
        }
    }
}
