using Microsoft.AspNetCore.Mvc;
using WebAPI.Data;
using WebAPI.DTOs;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MensagensController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MensagensController(ApplicationDbContext context)
        {
            _context = context;
        }

        
        [HttpPost("enviarPrivada")]
        public IActionResult EnviarMensagemPrivada(EnviarMensagemPrivadaDto mensagemDto)
        {
            var mensagem = new Mensagem
            {
                Conteudo = mensagemDto.Conteudo,
                RemetenteId = mensagemDto.RemetenteId,
                RemetenteTipo = mensagemDto.RemetenteTipo,
                DestinatarioId = mensagemDto.DestinatarioId,
                DestinatarioTipo = mensagemDto.DestinatarioTipo
            };

            _context.Mensagens.Add(mensagem);
            _context.SaveChanges();
            return Ok(mensagem);
        }

        
        [HttpPost("enviarParaTurma")]
        public IActionResult EnviarMensagemParaTurma(EnviarMensagemParaTurmaDto mensagemDto)
        {
            var mensagem = new Mensagem
            {
                Conteudo = mensagemDto.Conteudo,
                RemetenteId = mensagemDto.RemetenteId,
                RemetenteTipo = mensagemDto.RemetenteTipo,
                TurmaId = mensagemDto.TurmaId
            };

            _context.Mensagens.Add(mensagem);
            _context.SaveChanges();
            return Ok(mensagem);
        }
    }
}
