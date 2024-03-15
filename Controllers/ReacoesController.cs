using Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReacoesController : ControllerBase
    {
        
        private readonly DbEchoEmotional c = new DbEchoEmotional();

        [HttpGet]
        public ActionResult<IEnumerator<Reacao>> Listar()
        {
            try
            {
                var reacoes = c.reacoes.ToList();

                return Ok(reacoes);
            }
            catch
            {
                return StatusCode(500, "Não foi possível realizar operação.");
            }
        }
    }
}
