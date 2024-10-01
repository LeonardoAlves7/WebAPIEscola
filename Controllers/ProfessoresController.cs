using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.DTOs;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProfessoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarProfessor(CriarProfessorDto professorDto)
        {
            var professor = new Professor
            {
                Nome = professorDto.Nome,
                Email = professorDto.Email
            };

            _context.Professores.Add(professor);
            _context.SaveChanges();
            return Ok(professor);
        }

        [HttpGet]
        public IActionResult ListarProfessores()
        {
            var professores = _context.Professores.ToList();
            return Ok(professores);
        }

        [HttpGet("{id}")]
        public IActionResult ObterProfessor(int id)
        {
            var professor = _context.Professores.Find(id);
            if (professor == null)
                return NotFound();

            return Ok(professor);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProfessor(int id, AtualizarProfessorDto professorAtualizadoDto)
        {
            var professor = _context.Professores.Find(id);
            if (professor == null)
                return NotFound();

            professor.Nome = professorAtualizadoDto.Nome;
            professor.Email = professorAtualizadoDto.Email;
            _context.Entry(professor).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarProfessor(int id)
        {
            var professor = _context.Professores.Find(id);
            if (professor == null)
                return NotFound();

            _context.Professores.Remove(professor);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
