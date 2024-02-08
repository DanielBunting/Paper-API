using Microsoft.AspNetCore.Mvc;

namespace Paper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost("Apple")]
        public IActionResult AppleLogin()
        {
            // IF not validated return return Unauthrized. 
            // IF not created return 404. 
            // IF all good, return OK, with the User Profile.


            return Ok("Apple Login");
        }

        [HttpPost("Apple/Register")]
        public IActionResult AppleRegister()
        {
            // Should return 201 created at when implemented. Throw general stuff otherwise. Also, use the same protection/guard as login here. 
            return Ok("Apple Register");
        }

        [HttpPost("Google")]
        public IActionResult GoogleLogin()
        {
            // IF not validated return return Unauthrized. 
            // IF not created return 404. 
            // IF all good, return OK, with the User Profile.


            return Ok("Google Login");
        }

        [HttpPost("Google/Register")]
        public IActionResult GoogleRegister()
        {
            // Should return 201 created at when implemented. Throw general stuff otherwise. Also, use the same protection/guard as login here. 
            return Ok("Google Register");
        }


    }
}
