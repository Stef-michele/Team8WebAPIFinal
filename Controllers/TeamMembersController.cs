using Microsoft.AspNetCore.Mvc;
using Team8WebAPIFinal.Data;
using Team8WebAPIFinal.Models;

namespace Team8WebAPIFinal.Controllers
{

        [Route("api/[controller]")]
        [ApiController]
        public class TeamMemberController : ControllerBase
        {
            private readonly AppDbContext _context;

            public TeamMemberController(AppDbContext context)
            {
                _context = context;
            }

        [HttpGet]
        public IActionResult GetTeamMembers()
        {
            return Ok(_context.TeamMembers.Take(5).ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetTeamMember(int id)
        {
            var member = _context.TeamMembers.Find(id);
            if (member == null) return NotFound();
            return Ok(member);
        }

        [HttpPost]
        public IActionResult CreateTeamMember(TeamMember member)
        {
            _context.TeamMembers.Add(member);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTeamMember), new { id = member.Id }, member);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTeamMember(int id, TeamMember updatedMember)
        {
            var member = _context.TeamMembers.Find(id);
            if (member == null) return NotFound();

            member.FullName = updatedMember.FullName;
            member.Birthdate = updatedMember.Birthdate;
            member.CollegeProgram = updatedMember.CollegeProgram;
            member.YearInProgram = updatedMember.YearInProgram;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeamMember(int id)
        {
            var member = _context.TeamMembers.Find(id);
            if (member == null) return NotFound();

            _context.TeamMembers.Remove(member);
            _context.SaveChanges();
            return NoContent();
        }
    }
}