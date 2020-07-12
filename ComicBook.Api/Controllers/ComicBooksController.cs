using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBook.Api.Models;
using ComicBook.Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComicBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicBooksController : ControllerBase
    {
        private readonly IComicBookRepository _comicBookRepository;
        public ComicBooksController(IComicBookRepository comicBookRepository)
        {
            _comicBookRepository = comicBookRepository ?? throw new ArgumentNullException(nameof(comicBookRepository));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ComicBookDto>> GetComics()
        {
            var comicBooksFromDb = _comicBookRepository.GetAll();
            List<ComicBookDto> dtos = new List<ComicBookDto>();

            foreach (var comic in comicBooksFromDb)
            {
                dtos.Add(new ComicBookDto()
                {
                    DateOfCreation = comic.DateOfCreation,
                    Issue = comic.Issue,
                    Description = comic.Description,
                    ReleaseDate = comic.ReleaseDate,
                    Title = comic.Title,
                    Id = comic.Id
                });
            }

            return dtos;
        }
    }
}