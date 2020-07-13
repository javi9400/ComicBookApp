using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ComicBook.Api.Commons
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);

        void Insert(TEntity entityToInsert);

        void Update(int id, TEntity entityToUpdate);

        void Delete(int id);

        void SaveChanges();

        bool Exists(int id);


    }
}
