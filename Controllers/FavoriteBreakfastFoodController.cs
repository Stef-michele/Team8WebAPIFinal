using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamApi.Data;
using TeamApi.Models;

namespace TeamApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteBreakfastFoodsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoriteBreakfastFoodsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteBreakfastFoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteBreakfastFood>>> GetFavoriteBreakfastFoods(int? id)
        {
            if (id.HasValue && id.Value > 0)
            {
                var food = await _context.FavoriteBreakfastFoods.FindAsync(id.Value);
                if (food == null)
                    return NotFound();

                return Ok(food);
            }

            return Ok(await _context.FavoriteBreakfastFoods.Take(5).ToListAsync());
        }

        // POST: api/FavoriteBreakfastFoods
        [HttpPost]
        public async Task<ActionResult<FavoriteBreakfastFood>> PostFavoriteBreakfastFood(FavoriteBreakfastFood food)
        {
            _context.FavoriteBreakfastFoods.Add(food);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFavoriteBreakfastFoods), new { id = food.Id }, food);
        }

        // PUT: api/FavoriteBreakfastFoods/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteBreakfastFood(int id, FavoriteBreakfastFood food)
        {
            if (id != food.Id)
                return BadRequest();

            _context.Entry(food).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent(); // Successful update, no content to return
        }

        // DELETE: api/FavoriteBreakfastFoods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavoriteBreakfastFood(int id)
        {
            var food = await _context.FavoriteBreakfastFoods.FindAsync(id);
            if (food == null)
                return NotFound();

            _context.FavoriteBreakfastFoods.Remove(food);
            await _context.SaveChangesAsync();

            return NoContent(); // Successful deletion, no content to return
        }
    }
}
