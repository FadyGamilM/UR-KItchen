using Microsoft.AspNetCore.Mvc;
namespace UrKitchen.API.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
   public UserController()
   {
      
   }

   [HttpGet("")]
   public IActionResult GetAll()
   {
      return Ok("[]");
   }
}
