using ComicBook.Api.Commons;
using ComicBook.Api.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Repositories
{
    public class ComicBookRepository : GenericRepository<Entities.ComicBook>, IComicBookRepository
    {
        public ComicBookRepository(ComicBookContext comicBookContext) : base(comicBookContext)
        {
           
        }

        public override void Update(int id, Entities.ComicBook entityToUpdate)
        {
            var comicToUpdate = GetById(id);

            comicToUpdate.Description = entityToUpdate.Description;
            comicToUpdate.Title = entityToUpdate.Title;

            base.Update(id, comicToUpdate);
        }
    }
}
