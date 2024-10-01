using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.DTOs;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TurmasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TurmasController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult CriarTurma(CriarTurmaDto turmaDto)
        {
            var turma = new Turma
            {
                Nome = turmaDto.Nome
            };

            _context.Turmas.Add(turma);
            _context.SaveChanges();
            return Ok(turma);
        }

        [HttpPost("{turmaId}/vincularAluno/{alunoId}")]
        public IActionResult VincularAluno(int turmaId, int alunoId)
        {
            var turmaAluno = new TurmaAluno { TurmaId = turmaId, AlunoId = alunoId };
            _context.TurmaAlunos.Add(turmaAluno);
            _context.SaveChanges();
            return Ok(turmaAluno);
        }

        [HttpPost("{turmaId}/vincularProfessor/{professorId}")]
        public IActionResult VincularProfessor(int turmaId, int professorId)
        {
            var turmaProfessor = new TurmaProfessor { TurmaId = turmaId, ProfessorId = professorId };
            _context.TurmaProfessores.Add(turmaProfessor);
            _context.SaveChanges();
            return Ok(turmaProfessor);
        }
    }
}
