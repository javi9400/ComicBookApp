using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Models
{
    public class ComicBookForUpdate
    {
        public string Description { get; set; }

        public string Title { get; set; }

        public Int64 Id { get; set; }

    }
}
