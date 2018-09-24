using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_app_example.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("TestResult");
        }
    }
}