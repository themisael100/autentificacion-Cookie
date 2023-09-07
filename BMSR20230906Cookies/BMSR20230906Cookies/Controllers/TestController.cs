using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BMSR20230906Cookies.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        static List<object> data = new List<object>();

        [HttpGet]
        public IEnumerable<object> Get()
        {
            return data;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(string name, string lastName)
        {
            data.Add(new {name, lastName});

            return Ok();
        }

        [Authorize]
        [HttpDelete]
        public IActionResult Delete()
        {
            data = new List<object>();

            return Ok();
        }
    }
}
