using _1zajecia.Services.Lab5;
using Microsoft.AspNetCore.Mvc;

namespace _1zajecia.Controllers.LAB5
{
    [ApiController]
    [Route("/lab5")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        [Route("GetSomeController")]

        public string GetSomeController()
        {
            var someClass = new SomeClass();
            return someClass.Print(null);
        }
    }
}
