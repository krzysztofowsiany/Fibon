using Microsoft.AspNetCore.Mvc;

namespace Fibon.Api.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("")]
        public IActionResult Get() 
        => Content("Hello form Fibon SERVICE!");
    }
}