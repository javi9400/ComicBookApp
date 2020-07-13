using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBook.Api.Models;
using ComicBook.Api.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComicBook.Api.Controllers
{
    [EnableCors("AllowOrigin")]
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

            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public ActionResult<ComicBookDto> GetById(int id)
        {
            var comicFromDb = _comicBookRepository.GetById(id);

            if(comicFromDb == null)
            {
                return NotFound();
            }

            ComicBookDto dto = new ComicBookDto()
            {
                Id = comicFromDb.Id,
                Description = comicFromDb.Description,
                DateOfCreation = comicFromDb.DateOfCreation,
                ReleaseDate = comicFromDb.ReleaseDate,
                Issue = comicFromDb.Issue,
                Title = comicFromDb.Title
            };

            return Ok(dto);
        }

        [HttpPost]
        public ActionResult InsertComic(ComicBookForInsert dto)
        {
            Entities.ComicBook comicBook = new Entities.ComicBook();
            comicBook.Description = dto.Description;
            comicBook.Issue = dto.Issue;
            comicBook.ReleaseDate = dto.ReleaseDate;
            comicBook.Title = dto.Title;

            _comicBookRepository.Insert(comicBook);
            _comicBookRepository.SaveChanges();

            return Ok();

        }

        [HttpPut("{id}")]
        public ActionResult UpdateComic(int id, ComicBookForUpdate dto)
        {
            Entities.ComicBook comicBook = new Entities.ComicBook();

            comicBook.Description = dto.Description;
            comicBook.Title = dto.Title;

            if(!_comicBookRepository.Exists(id))
            {
                return NotFound();
            }

            _comicBookRepository.Update(id,comicBook);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public ActionResult DeleteComic(int id)
        {
            if(!_comicBookRepository.Exists(id))
            {
                return NotFound();
            }

            _comicBookRepository.Delete(id);

            return NoContent();
        }
    }
}