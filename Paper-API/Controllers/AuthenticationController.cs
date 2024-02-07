using Microsoft.AspNetCore.Mvc;

namespace Paper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        // Post to login. 
        // Will login if login avalible else return a registration page.


        // Post to register. 
        // Once registered, return the JWT.     

        // Post to sign in with apple.
        // IF not regitered, will be the register page.  

        // Post to register with Apple. 
        // IF registered will tll you to get fucked. 
    }
}
