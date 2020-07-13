using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Models
{
    public class ComicBookForInsert
    {
        public string Description { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Issue { get; set; }
    }
}
