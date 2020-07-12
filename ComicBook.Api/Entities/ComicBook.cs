using ComicBook.Api.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Entities
{
    public class ComicBook : EntityBase
    { 
        public string Description { get; set; }

        public string  Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int Issue { get; set; }
    }
}
