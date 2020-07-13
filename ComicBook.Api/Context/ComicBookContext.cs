using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBook.Api.Context
{
    public class ComicBookContext:DbContext
    {

        public ComicBookContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Entities.ComicBook> ComicBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.ComicBook>().HasData(new Entities.ComicBook()
            {
                Id=1,
                Description="Test comic for pollo",
                ReleaseDate=DateTime.Now,
                Issue=69,
                Title="Venganza del toro vince part 1"
            });;

        }
    }
}
