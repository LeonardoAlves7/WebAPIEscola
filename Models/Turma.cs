using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class Turma
    {
        public int TurmaId { get; set; }
        public string Nome { get; set; }

        public List<TurmaAluno> Alunos { get; set; }
        public List<TurmaProfessor> Professores { get; set; }

        public List<Mensagem> Mensagens { get; set; }
    }
}
