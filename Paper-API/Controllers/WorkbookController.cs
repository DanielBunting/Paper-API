using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Paper.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WorkbookController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWorkbooks()
        {
            return Ok();
        }
    }
}
