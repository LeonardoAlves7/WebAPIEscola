using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class TurmaAluno
    {
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }

        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
    }
}
