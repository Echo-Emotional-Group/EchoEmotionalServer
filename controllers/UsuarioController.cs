using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public ActionResult CriarUsuario([FromBody] Usuario usuario) {
            usuario.Id = Guid.NewGuid();
            //lugar para adicionar comando Add banco de dados
            return Ok(usuario);
        }
    }
}
