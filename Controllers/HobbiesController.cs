using Microsoft.AspNetCore.Mvc;
using Team8WebAPIFinal.Data;
using Team8WebAPIFinal.Models;

namespace Team8WebAPIFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HobbiesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HobbiesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Hobbies
        [HttpGet]
        public IActionResult GetHobbies()
        {
            return Ok(_context.Hobbies.Take(5).ToList());
        }

        // GET: api/Hobbies/{id}
        [HttpGet("{id}")]
        public IActionResult GetHobbies(int id)
        {
            var Hobbies = _context.Hobbies.Find(id);
            if (Hobbies == null) return NotFound();
            return Ok(Hobbies);
        }

        // POST: api/Hobbies
        [HttpPost]
        public IActionResult CreateHobbies(Hobbies Hobbies)
        {
            _context.Hobbies.Add(Hobbies);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetHobbies), new { id = Hobbies.Id }, Hobbies);
        }

        // PUT: api/Hobbies/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateHobbies(int id, Hobbies updatedHobbies)
        {
            var Hobbies = _context.Hobbies.Find(id);
            if (Hobbies == null) return NotFound();

            Hobbies.Name = updatedHobbies.Name;
            Hobbies.Description = updatedHobbies.Description;
            Hobbies.EstimatedHoursPerWeek = updatedHobbies.EstimatedHoursPerWeek;
            Hobbies.SkillLevel = updatedHobbies.SkillLevel;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Hobbies/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteHobbies(int id)
        {
            var Hobbies = _context.Hobbies.Find(id);
            if (Hobbies == null) return NotFound();

            _context.Hobbies.Remove(Hobbies);
            _context.SaveChanges();
            return NoContent();
        }
    }
}