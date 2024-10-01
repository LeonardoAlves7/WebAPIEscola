using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.DTOs;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AlunosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarAluno(CriarAlunoDto alunoDto)
        {
            var aluno = new Aluno
            {
                Nome = alunoDto.Nome,
                Email = alunoDto.Email
            };

            _context.Alunos.Add(aluno);
            _context.SaveChanges();
            return Ok(aluno);
        }

        [HttpGet]
        public IActionResult ListarAlunos()
        {
            var alunos = _context.Alunos.ToList();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public IActionResult ObterAluno(int id)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno == null)
                return NotFound();

            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarAluno(int id, AtualizarAlunoDto alunoAtualizadoDto)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno == null)
                return NotFound();

            aluno.Nome = alunoAtualizadoDto.Nome;
            aluno.Email = alunoAtualizadoDto.Email;
            _context.Entry(aluno).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarAluno(int id)
        {
            var aluno = _context.Alunos.Find(id);
            if (aluno == null)
                return NotFound();

            _context.Alunos.Remove(aluno);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
