using Microsoft.AspNetCore.Mvc;

namespace biblioBack.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {     
        [HttpGet("GetUsers")]
        public IEnumerable<string> GetUsers()
        {
            return new List<string> { "Sasha", "Pasha", "Dasha", "Kasha" };
        }
    }
}
