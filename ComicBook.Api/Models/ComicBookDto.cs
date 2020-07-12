using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Models
{
    public class ComicBookDto
    {
        public Int64 Id { get; set; }
        public string Description { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime DateOfCreation { get; set; }

        public int Issue { get; set; }
    }
}
