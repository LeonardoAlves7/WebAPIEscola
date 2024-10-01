using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class TurmaProfessor
    {
        public int TurmaId { get; set; }
        public Turma Turma { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
