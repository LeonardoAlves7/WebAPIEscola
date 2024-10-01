using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebAPI.Models;

namespace WebAPI.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<TurmaProfessor> Turmas { get; set; }
    }
}
