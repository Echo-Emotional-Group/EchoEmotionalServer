using Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Post : ControllerBase
    {
         private readonly DbEchoEmotional Contexto = new DbEchoEmotional();

          [HttpGet]
        public ActionResult<IEnumerable<Post>> ObterPosts()
        {
            try
            {
                var posts = Contexto.perfil_users.ToList();

                return Ok(posts);
            }
            catch
            {
                return StatusCode(500, "O problema foi sério, mas a gente passa bem!");
            }
        }
    }
}
