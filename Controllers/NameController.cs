using Microsoft.AspNetCore.Mvc;

namespace WebAPI_CC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var response = new { Name = "Colin Collins" }; 
            return Ok(response);
        }
    }
}