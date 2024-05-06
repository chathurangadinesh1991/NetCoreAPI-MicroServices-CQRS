using Microsoft.AspNetCore.Mvc;

namespace Payroll.APIGateway.Controllers
{
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] object user)
        {
            bool isSucessfull = true;
            try
            {
                // Login logics
                // Token genaration


                if (isSucessfull)
                    return Ok(); // Success results with token

                return Unauthorized();
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
