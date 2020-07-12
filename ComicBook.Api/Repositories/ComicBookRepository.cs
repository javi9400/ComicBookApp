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
    }
}
