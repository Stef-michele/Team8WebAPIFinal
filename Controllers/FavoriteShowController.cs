using Microsoft.AspNetCore.Mvc;
using Team8WebAPIFinal.Data;
using Team8WebAPIFinal.Models;

namespace Team8WebAPIFinal.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteShowController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FavoriteShowController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFavoriteShows()
        {
            return Ok(_context.FavoriteShows.Take(5).ToList());
        }

        [HttpGet("{name}")]
        public IActionResult GetFavoriteShow(int name)
        {
            var show = _context.FavoriteShows.Find(name);
            if (show == null) return NotFound();
            return Ok(show);
        }

        [HttpPost]
        public IActionResult CreateFavoriteShow(FavoriteShow show)
        {
            _context.FavoriteShows.Add(show);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetFavoriteShow), new { name = show.Title }, show);
        }

        [HttpPut("{name}")]
        public IActionResult UpdateFavoriteShow(string name, FavoriteShow updatedShow)
        {
            var show = _context.FavoriteShows.Find(name);
            if (show == null) return NotFound();

            show.Id = updatedShow.Id;
            show.Title = updatedShow.Title;
            show.Genre = updatedShow.Genre;
            show.ReleaseYear = updatedShow.ReleaseYear;
            show.FavoriteCharacter = updatedShow.FavoriteCharacter;
            show.Creator = updatedShow.Creator;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult DeleteFavoriteShow(string name)
        {
            var show = _context.FavoriteShows.Find(name);
            if (show == null) return NotFound();

            _context.FavoriteShows.Remove(show);
            _context.SaveChanges();
            return NoContent();
        }
    }
}