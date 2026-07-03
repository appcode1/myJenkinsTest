using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return $"Welcome! This is the HomeController of MyWebApi. {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}";
        }
    }
}
