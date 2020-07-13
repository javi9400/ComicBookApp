using ComicBook.Api.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Entities
{
    public class ComicBook : EntityBase
    {
        public ComicBook()
        {
            DateOfCreation = DateTime.Now;
        }

        public string Description { get; set; }

        public string  Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateOfCreation { get; private set; }

        public int Issue { get; set; }
    }
}
